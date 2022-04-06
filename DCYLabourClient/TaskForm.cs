using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCYLabourClient.MODEL;
using DCYLabourClient.BLL;

namespace DCYLabourClient
{
    public partial class TaskForm : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public MainForm mainform;
        UserInfBll ubll=new UserInfBll();
        public List<string> listpresent=new List<string>();
        public TaskForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);//自动调整控件窗口大小
            TextAdust();
        }

        private void TaskForm_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);//自动调整控件、窗口大小
        }

        /// <summary>
        /// 所有富文本框居中显示
        /// </summary>
        void TextAdust()
        {
            foreach(Control control in this.Controls)
            {
                if(control is RichTextBoxTM)
                {
                    RichTextBoxTM rtb= (RichTextBoxTM)control;
                    rtb.SelectionAlignment = HorizontalAlignment.Center;
                    rtb.Font = new Font("华文新魏",15f);
                    rtb.Text = "";
                }
            }
        }

        public void UpdateData(TaskInfo tinf,TaskFinishInfo tfinf)
        {
            txtGroupName.Text = tinf.TaskGroup;
            txtClass.Text = tinf.TaskClass.ToString();
            txtTeacher.Text = ubll.GetTNameByUid(tinf.TaskTUid);
            txtStuCap.Text = ubll.GetStuNameByCard(tinf.TaskStuCapID);
            UpdatePresentInf(tinf.TaskStus);
            txtTaskName.Text = tinf.TaskName;
            txtFanDiTime.Text = tfinf.FanDiTime;
            txtChuCao.Text= tfinf.ChuCao;
            txtDiKuaiW.Text=tfinf.DiKuaiW;
            txtDiKuaiH.Text = tfinf.DiKuaiH;
            txtDiKuaiArea.Text = tfinf.DiKuaiArea;
            txtFanDiPicURL.Text= tfinf.FanDiPicURL;
            txtZhengDiTime.Text=tfinf.ZhengDiTime;
            txtLongGui.Text = tfinf.LongGui;
            txtLongGou1.Text = tfinf.LongGou1;
            txtLongGou2.Text = tfinf.LongGou2;
            txtLongGou3.Text = tfinf.LongGou3;
            txtLongGou4.Text = tfinf.LongGou4;
            txtLongGou5.Text = tfinf.LongGou5;
            txtZhengDiPicURL.Text = tfinf.ZhengDiPicURL;
            txtCeLiangTime.Text = tfinf.CeLiangTime;
            txtHuanJingTemp.Text = tfinf.HuanJingTemp;
            txtHuanJingWet.Text = tfinf.HuanJingWet;
            txtTuRangTemp.Text = tfinf.TuRangTemp;
            txtTuRangLight.Text = tfinf.TuRangLight;
            txtTuRangWet.Text = tfinf.TuRangWet;
            txtTuRangPH.Text = tfinf.TuRangPH;
            txtTuRangPicURL.Text = tfinf.CeLiangPicURL;
            txtCuoShiTime.Text = tfinf.CuoShiTime;
            txtShiFei.Text = tfinf.CuoShiShiFei.ToString();
            txtShaChong.Text=tfinf.CuoShiShaChong.ToString();
            txtJiaoGuan.Text=tfinf.CuoShiJiaoGuan.ToString();
            txtGuangZhao.Text = tfinf.CuoShiGuangZhao.ToString();
            txtMieChong.Text = tfinf.CuoShiMieChong.ToString();
            txtPenSa.Text = tfinf.CuoShiPenSa.ToString();
            txtCuoShiPicURL.Text = tfinf.CuoShiPicURL;
            txtZuoWuTime.Text = tfinf.ZuoWuTime;
            txtZuoWuJieDuan.Text = tfinf.ZuoWuJieDuan;
            txtZuoWuYanSe.Text = tfinf.ZuoWuYanSe;
            txtZuoWuH.Text = tfinf.ZuoWuH;
            txtZuoWuNum1.Text = tfinf.ZuoWuNum1.ToString();
            txtZuoWuNum2.Text=tfinf.ZuoWuNum2.ToString();
            txtZuoWuShouHuo.Text=tfinf.ZuoWuShouHuo.ToString();
            txtZuoWuPicURL.Text = tfinf.ZuoWuPicURL;

        }

        /// <summary>
        /// 更新签到信息
        /// </summary>
        /// <param name="listpresent"></param>
        public void UpdatePresentInf(string taskstus)
        {
            var arr=taskstus.Split(',');
            List<string> list = new List<string>();
            list.AddRange(arr);
            List<string> listnp=new List<string>();
            listnp=list.Except(listpresent).ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listpresent.Count; i++)
            {
                sb.Append(ubll.GetStuNameByCard(listpresent[i]) + "(已签到) ");
            }
            txtPresent.Text = sb.ToString();
            if (listnp.Count > 0)
            {
                sb = new StringBuilder();
                for(int i = 0; i < listnp.Count; i++)
                {
                    sb.Append(ubll.GetStuNameByCard(listnp[i])+"(未签到) ");
                }
                txtPresent.Text += sb.ToString();
            }
        }

    }
}
