namespace MyGDI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btuStart = new System.Windows.Forms.Button();
            this.MyBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.Control;
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Controls.Add(this.btuStart);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 569);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1457, 100);
            this.panelBottom.TabIndex = 0;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottom_Paint);
            // 
            // btuStart
            // 
            this.btuStart.Location = new System.Drawing.Point(364, 25);
            this.btuStart.Name = "btuStart";
            this.btuStart.Size = new System.Drawing.Size(75, 23);
            this.btuStart.TabIndex = 0;
            this.btuStart.Text = "开始";
            this.btuStart.UseVisualStyleBackColor = true;
            this.btuStart.Click += new System.EventHandler(this.btuStart_Click);
            // 
            // MyBox
            // 
            this.MyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyBox.Location = new System.Drawing.Point(0, 0);
            this.MyBox.Name = "MyBox";
            this.MyBox.Size = new System.Drawing.Size(1457, 569);
            this.MyBox.TabIndex = 1;
            this.MyBox.TabStop = false;
            this.MyBox.Click += new System.EventHandler(this.MyBox_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 669);
            this.Controls.Add(this.MyBox);
            this.Controls.Add(this.panelBottom);
            this.Name = "frmMain";
            this.Text = "GDI绘图";
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btuStart;
        private System.Windows.Forms.PictureBox MyBox;
        private System.Windows.Forms.Timer timer1;
    }
}

