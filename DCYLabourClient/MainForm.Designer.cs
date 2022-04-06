namespace DCYLabourClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtBoxSecCard = new DCYLabourClient.RichTextBoxTM();
            this.labelSecCard = new System.Windows.Forms.Label();
            this.rtBoxMainCard = new DCYLabourClient.RichTextBoxTM();
            this.labelMainCard = new System.Windows.Forms.Label();
            this.rtBoxTasking = new DCYLabourClient.RichTextBoxTM();
            this.labelTaskCon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBtnTask = new System.Windows.Forms.PictureBox();
            this.picBtnTool = new System.Windows.Forms.PictureBox();
            this.picBtnAc = new System.Windows.Forms.PictureBox();
            this.panelHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnAc)).BeginInit();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rtBoxSecCard);
            this.groupBox1.Controls.Add(this.labelSecCard);
            this.groupBox1.Controls.Add(this.rtBoxMainCard);
            this.groupBox1.Controls.Add(this.labelMainCard);
            this.groupBox1.Controls.Add(this.rtBoxTasking);
            this.groupBox1.Controls.Add(this.labelTaskCon);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 40F);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 988);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前任务状态";
            // 
            // rtBoxSecCard
            // 
            this.rtBoxSecCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtBoxSecCard.Font = new System.Drawing.Font("楷体", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtBoxSecCard.Location = new System.Drawing.Point(12, 365);
            this.rtBoxSecCard.MaxLength = 100;
            this.rtBoxSecCard.Multiline = false;
            this.rtBoxSecCard.Name = "rtBoxSecCard";
            this.rtBoxSecCard.ReadOnly = true;
            this.rtBoxSecCard.Size = new System.Drawing.Size(420, 57);
            this.rtBoxSecCard.TabIndex = 5;
            this.rtBoxSecCard.Text = "";
            // 
            // labelSecCard
            // 
            this.labelSecCard.AutoSize = true;
            this.labelSecCard.Font = new System.Drawing.Font("黑体", 25F);
            this.labelSecCard.Location = new System.Drawing.Point(6, 318);
            this.labelSecCard.Name = "labelSecCard";
            this.labelSecCard.Size = new System.Drawing.Size(287, 34);
            this.labelSecCard.TabIndex = 4;
            this.labelSecCard.Text = "当前副卡槽插卡：";
            // 
            // rtBoxMainCard
            // 
            this.rtBoxMainCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtBoxMainCard.Font = new System.Drawing.Font("楷体", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtBoxMainCard.Location = new System.Drawing.Point(12, 237);
            this.rtBoxMainCard.MaxLength = 100;
            this.rtBoxMainCard.Multiline = false;
            this.rtBoxMainCard.Name = "rtBoxMainCard";
            this.rtBoxMainCard.ReadOnly = true;
            this.rtBoxMainCard.Size = new System.Drawing.Size(420, 57);
            this.rtBoxMainCard.TabIndex = 3;
            this.rtBoxMainCard.Text = "";
            // 
            // labelMainCard
            // 
            this.labelMainCard.AutoSize = true;
            this.labelMainCard.Font = new System.Drawing.Font("黑体", 25F);
            this.labelMainCard.Location = new System.Drawing.Point(6, 190);
            this.labelMainCard.Name = "labelMainCard";
            this.labelMainCard.Size = new System.Drawing.Size(287, 34);
            this.labelMainCard.TabIndex = 2;
            this.labelMainCard.Text = "当前主卡槽插卡：";
            // 
            // rtBoxTasking
            // 
            this.rtBoxTasking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtBoxTasking.Font = new System.Drawing.Font("楷体", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtBoxTasking.Location = new System.Drawing.Point(12, 111);
            this.rtBoxTasking.MaxLength = 100;
            this.rtBoxTasking.Multiline = false;
            this.rtBoxTasking.Name = "rtBoxTasking";
            this.rtBoxTasking.ReadOnly = true;
            this.rtBoxTasking.Size = new System.Drawing.Size(420, 57);
            this.rtBoxTasking.TabIndex = 1;
            this.rtBoxTasking.Text = "";
            // 
            // labelTaskCon
            // 
            this.labelTaskCon.AutoSize = true;
            this.labelTaskCon.Font = new System.Drawing.Font("黑体", 25F);
            this.labelTaskCon.Location = new System.Drawing.Point(6, 64);
            this.labelTaskCon.Name = "labelTaskCon";
            this.labelTaskCon.Size = new System.Drawing.Size(287, 34);
            this.labelTaskCon.TabIndex = 0;
            this.labelTaskCon.Text = "终端进行中任务：";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(502, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 2;
            // 
            // picBtnTask
            // 
            this.picBtnTask.Image = ((System.Drawing.Image)(resources.GetObject("picBtnTask.Image")));
            this.picBtnTask.Location = new System.Drawing.Point(502, 108);
            this.picBtnTask.Name = "picBtnTask";
            this.picBtnTask.Size = new System.Drawing.Size(434, 128);
            this.picBtnTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnTask.TabIndex = 4;
            this.picBtnTask.TabStop = false;
            this.picBtnTask.Click += new System.EventHandler(this.picBtnTask_Click);
            // 
            // picBtnTool
            // 
            this.picBtnTool.Image = ((System.Drawing.Image)(resources.GetObject("picBtnTool.Image")));
            this.picBtnTool.Location = new System.Drawing.Point(971, 108);
            this.picBtnTool.Name = "picBtnTool";
            this.picBtnTool.Size = new System.Drawing.Size(434, 128);
            this.picBtnTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnTool.TabIndex = 5;
            this.picBtnTool.TabStop = false;
            this.picBtnTool.Click += new System.EventHandler(this.picBtnTool_Click);
            // 
            // picBtnAc
            // 
            this.picBtnAc.Image = ((System.Drawing.Image)(resources.GetObject("picBtnAc.Image")));
            this.picBtnAc.Location = new System.Drawing.Point(1434, 108);
            this.picBtnAc.Name = "picBtnAc";
            this.picBtnAc.Size = new System.Drawing.Size(434, 128);
            this.picBtnAc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnAc.TabIndex = 6;
            this.picBtnAc.TabStop = false;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.Red;
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1921, 66);
            this.panelHead.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "重庆市第三十八中学   智慧劳动教育管理终端";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DCYLabourClient.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.picBtnAc);
            this.Controls.Add(this.picBtnTool);
            this.Controls.Add(this.picBtnTask);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnAc)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private RichTextBoxTM rtBoxSecCard;
        private System.Windows.Forms.Label labelSecCard;
        public RichTextBoxTM rtBoxMainCard;
        private System.Windows.Forms.Label labelMainCard;
        private RichTextBoxTM rtBoxTasking;
        private System.Windows.Forms.Label labelTaskCon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBtnTask;
        private System.Windows.Forms.PictureBox picBtnTool;
        private System.Windows.Forms.PictureBox picBtnAc;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label label1;
    }
}

