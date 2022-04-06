using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DCYLabourClient.MODEL;
using DCYLabourClient.BLL;

namespace DCYLabourClient
{
    public partial class MainForm : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        PortListener portListener = PortListener.Instence;//实例化串口类
        public bool MainCard = false;//主卡槽是否有卡
        public string MainCardNum="";
        public bool isOnTask = false;//是否正在进行劳动任务
        public string SecCardNum = "";
        public bool SecCard = false;//副卡槽是否有卡
        TaskForm taskform;
        ToolForm toolform;
        TaskInfo currentTask;
        TaskFinishInfo currentFinishInfo;
        TaskBll tbll=new TaskBll();

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls=false;
        }

 

        private void MainForm_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);//自动调整控件窗口大小
            rtBoxTasking.SelectionAlignment = HorizontalAlignment.Center;//富文本框居中
            rtBoxTasking.Text = "无";
            portListener.OpenPort();//打开串口
            portListener.mainform = this;
            taskform = new TaskForm(this);
            toolform = new ToolForm(this);//创建子窗体
            OpenForm(taskform);
            SendKeys.Send("%");
            Test();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);//自动调整控件、窗口大小
        }

        private void OpenForm(Form objFrm)
        {

            HidePreForm();
            //嵌入子窗体到父窗体中，把添加学员信息嵌入到主窗体右侧
            objFrm.TopLevel = false; //将子窗体设置成非最高层，非顶级控件
            objFrm.WindowState = FormWindowState.Maximized;//将当前窗口设置成最大化
            objFrm.FormBorderStyle = FormBorderStyle.None;//去掉窗体边框
            objFrm.Parent = this.panel1;//指定子窗体显示的容器
            objFrm.Show();
        }

        private void HidePreForm()
        {
            foreach (Control item in this.panel1.Controls)
            {
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Hide();
                }

            }
        }

        /// <summary>
        /// 任务信息按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBtnTask_Click(object sender, EventArgs e)
        {
            OpenForm(taskform);
        }

        /// <summary>
        /// 器材管理按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBtnTool_Click(object sender, EventArgs e)
        {
            OpenForm(toolform);
        }

        public void LoadTask(TaskInfo task)
        {
            isOnTask = true;
            currentTask = task;
            TaskFinishInfo tfinf=tbll.GetFinishInfo(task.TaskID);
            if (tfinf != null)
            {
                currentFinishInfo = tfinf;
                SysShowMsg("加载任务成功！任务名称为：" + currentTask.TaskID + "." + currentTask.TaskName + "\n");
                rtBoxTasking.Text = currentTask.TaskID + "." + currentTask.TaskName;
                taskform.UpdateData(currentTask, currentFinishInfo);
            }
            else
            {
                tbll.AddFinishInfo(task.TaskID);
                currentFinishInfo= tbll.GetFinishInfo(task.TaskID);
                SysShowMsg("加载任务成功！任务名称为："+currentTask.TaskID+"."+currentTask.TaskName+"\n");
                rtBoxTasking.Text = currentTask.TaskID + "." + currentTask.TaskName;
                taskform.UpdateData(currentTask,currentFinishInfo);
                
            }
        }

        private void btnSelectTask_Click(object sender, EventArgs e)
        {
            if (isOnTask)
            {
                SysShowMsg("该终端正在进行劳动任务");
                return;
            }
            else if (!MainCard)
            {
                SysShowMsg("请先插入主卡以接收任务");
                return;
            }
            else
            {
                new Thread(delegate ()
                {
                    Application.Run(new TaskSelectForm(this,MainCardNum));
                }).Start();
            }
        }

        void SysShowMsg(string msg)
        {
            rtBoxSysInfo.Text = "[" + DateTime.Now.ToString("T") + "]"+msg+"\n" + rtBoxSysInfo.Text;
        }

        void Test()
        {
            MainCard = true;
            MainCardNum = "000555001";
        }
    }
}
