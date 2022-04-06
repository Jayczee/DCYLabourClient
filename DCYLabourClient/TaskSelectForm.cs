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
    public partial class TaskSelectForm : Form
    {
        string stucapcardnum;//组长卡号
        List<TaskInfo> list;
        TaskBll tbll=new TaskBll();
        MainForm mainform;
        TaskSelectForm tsfm;

        //调用API
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow(); //获得本窗体的句柄
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);//设置此窗体为活动窗体
                                                                   //定义变量,句柄类型
        public IntPtr han;

        public TaskSelectForm()
        {
            InitializeComponent();
        }

        public TaskSelectForm(MainForm mainfrom,string stucapcardnum)
        {
            InitializeComponent();
            this.stucapcardnum = stucapcardnum;
            this.mainform = mainfrom;
            tsfm = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (han != GetForegroundWindow())
            {
                SetForegroundWindow(han);
            }
        }

        private void TaskSelectForm_Load(object sender, EventArgs e)
        {
            han = this.Handle;
            timer1.Enabled = true;
            list = tbll.GetTaskList(stucapcardnum);
            if (list == null)
            {
                labelMsg.Text = "无任务";
                labelMsg.Visible = true;
            }
            else
            {
                labelMsg.Visible = false;
                DataTable dt=new DataTable();
                dt.Columns.Add("任务ID", typeof(Int32));
                dt.Columns.Add("任务名称",typeof(string));
                dt.Columns.Add("任务开始时间",typeof (string));
                for(int i = 0; i < list.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["任务ID"] = list[i].TaskID;
                    dr["任务名称"]=list[i].TaskName;
                    dr["任务开始时间"] = list[i].TaskStartTime;
                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==0)
            {
                labelMsg.Text = "请先选择任务";
                labelMsg.Visible = true;
            }
            else
            {
                labelMsg.Visible = false;
                int taskid = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["任务ID"].Value.ToString());
                foreach(TaskInfo inf in list)
                {
                    if (inf.TaskID == taskid)
                    {
                        mainform.LoadTask(inf);
                        this.Close();
                        this.Dispose();
                    }
                }
            }
        }
    }
}
