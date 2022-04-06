using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCYLabourClient
{
    public partial class TaskForm : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public MainForm mainform;
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
                    rtb.Text = "无";
                }
            }
        }

        public void UpdateData(int key,string value)
        {

        }
    }
}
