using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.Xml;

namespace DCYLabourClient
{
    public class PortListener
    {
        private static PortListener _Instence;
        public static PortListener Instence
        {
            get
            {
                if (_Instence == null)
                {
                    _Instence = new PortListener();
                }
                return _Instence;
            }
        }

        private bool isPortListening = false;//是否没有执行完invoke相关操作
        private bool isPortClosing = false;//是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke
        public bool IsPortOpen { get; set; }//监听端口是否打开
        protected long received_count = 0;//接收计数
        public string IP = "";  //本机IP
        //获取 端口号 例：COM1
        private string PortName = System.Configuration.ConfigurationManager.AppSettings["PortName"];
        //默认分配1页内存，并始终限制不允许超过
        private List<byte> buffer = new List<byte>(4096);
        public static SerialPort comPort = new SerialPort();
        public MainForm mainform;//主窗体初始化时将其实例赋给该值，以实现PortListener反向操控MainForm
        

        //监视器 初始化
        private PortListener()
        {
            //初始化SerialPort对象
            comPort.NewLine = "\r\n";
            comPort.RtsEnable = true;
            comPort.DataReceived += comm_DataReceived;
            
        }


        public void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (isPortListening) return;

            System.Threading.Thread.Sleep(500);
        }
        

        public void OpenPort()
        {
            //判断是否存在需要的端口
            List<String> portList = new List<string>();
            portList.AddRange(SerialPort.GetPortNames());
            if (!(portList.IndexOf(PortName) >= 0))
            {
                MessageBox.Show("计算机本机没有对应端口{0}，请修改配置文件!", PortName);
            }

            //如果串口已打开，则关闭它
            if (comPort.IsOpen)
            {
                isPortClosing = true;
                while (isPortListening)
                    Application.DoEvents();
                comPort.Close();
                isPortClosing = false;
            }
            else
            {
                // 设置端口参数
                comPort.BaudRate = int.Parse("9600");
                comPort.DataBits = int.Parse("8");
                comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                comPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                comPort.PortName = PortName;

                // 打开串口
                try
                {
                    comPort.Open();
                }
                catch
                {
                    //捕获到异常信息，创建一个新的comm对象，之前的不能用了。
                    comPort = new SerialPort();
                    MessageBox.Show("端口被占用，请重启系统！", "提示", MessageBoxButtons.OK);
                }
            }

            IsPortOpen = comPort.IsOpen;

        }
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        /// <summary>
        /// 上位机向下位机发送控制命令
        /// </summary>
        /// <param name="text">命令为16进制字符串</param>
        public void Send(string text)
        {

            byte[] data = HexStringToByteArray(text);
            if (comPort.IsOpen)
            {
                //comport.Open();
                comPort.Write(data, 0, data.Length);
                //comport.Close();
            }
            else
                MessageBox.Show("串口已关闭！", "提示", MessageBoxButtons.OK);

        }
        public string Checksum(string[] arr)
        {

            int sum = 0;
            string c = "";

            for (int i = 0; i < arr.Length; i++)
            {
                sum += int.Parse(arr[i], System.Globalization.NumberStyles.HexNumber);

                c += arr[i] + " ";
            }

            string a = sum.ToString("X2");
            string[] b = { a.Substring(a.Length - 2, 2) };
            c += b[0];
            return c;
        }
        public bool CheckIp(string ip1)
        {
            Ping ping = new Ping();
            bool bRet = false;
            try
            {
                Ping pingSend = new Ping();
                PingReply reply = pingSend.Send(ip1, 1000);
                if (reply.Status == IPStatus.Success)
                {
                    bRet = true;
                }
                else
                {
                    bRet = false;
                }
            }
            catch (Exception)
            {
                bRet = false;
            }

            return bRet;
        }

        //获取配置数据
        public static string PzHq(string name)
        {
            //创建一个xml对象
            //创建一个xml对象
            XmlDocument xmlDoc = new XmlDocument();
            //加载xml文件
            xmlDoc.Load("endpoint.xml");
            XmlNode node = xmlDoc.SelectSingleNode("connString");

            string server = node.Attributes[name].Value;

            return server;
        }

    }
}
