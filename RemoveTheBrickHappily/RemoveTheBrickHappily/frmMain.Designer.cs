namespace RemoveTheBrickHappily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelgame = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.aim = new System.Windows.Forms.Label();
            this.labelaim = new System.Windows.Forms.Label();
            this.labelscore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelright = new System.Windows.Forms.Panel();
            this.labtext = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.NameforGame = new System.Windows.Forms.Label();
            this.Mypicture = new System.Windows.Forms.PictureBox();
            this.Bgm = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelgame.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mypicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bgm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelgame
            // 
            this.panelgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelgame.Controls.Add(this.panelTop);
            this.panelgame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgame.Location = new System.Drawing.Point(0, 0);
            this.panelgame.Name = "panelgame";
            this.panelgame.Size = new System.Drawing.Size(599, 666);
            this.panelgame.TabIndex = 3;
            this.panelgame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelgame_Paint);
            this.panelgame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelgame_MouseDown);
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.panelTop.Controls.Add(this.aim);
            this.panelTop.Controls.Add(this.labelaim);
            this.panelTop.Controls.Add(this.labelscore);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(599, 110);
            this.panelTop.TabIndex = 0;
            // 
            // aim
            // 
            this.aim.AutoSize = true;
            this.aim.Font = new System.Drawing.Font("书体坊兰亭体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aim.Image = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.aim.Location = new System.Drawing.Point(493, 60);
            this.aim.Name = "aim";
            this.aim.Size = new System.Drawing.Size(63, 33);
            this.aim.TabIndex = 4;
            this.aim.Text = "2000";
            // 
            // labelaim
            // 
            this.labelaim.AutoSize = true;
            this.labelaim.Image = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.labelaim.Location = new System.Drawing.Point(422, 20);
            this.labelaim.Name = "labelaim";
            this.labelaim.Size = new System.Drawing.Size(134, 18);
            this.labelaim.TabIndex = 3;
            this.labelaim.Text = "目标：得分大于";
            // 
            // labelscore
            // 
            this.labelscore.AutoSize = true;
            this.labelscore.BackColor = System.Drawing.Color.Gold;
            this.labelscore.Font = new System.Drawing.Font("书体坊兰亭体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelscore.Image = global::RemoveTheBrickHappily.Properties.Resources._0;
            this.labelscore.Location = new System.Drawing.Point(210, 43);
            this.labelscore.Name = "labelscore";
            this.labelscore.Size = new System.Drawing.Size(23, 28);
            this.labelscore.TabIndex = 1;
            this.labelscore.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.pictureBox1.Image = global::RemoveTheBrickHappily.Properties.Resources.ScorePanel;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 98);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelright
            // 
            this.panelright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelright.BackgroundImage = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.panelright.Controls.Add(this.Bgm);
            this.panelright.Controls.Add(this.labtext);
            this.panelright.Controls.Add(this.buttonStop);
            this.panelright.Controls.Add(this.btnStart);
            this.panelright.Controls.Add(this.NameforGame);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelright.Location = new System.Drawing.Point(599, 0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(215, 666);
            this.panelright.TabIndex = 2;
            // 
            // labtext
            // 
            this.labtext.AutoSize = true;
            this.labtext.Image = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.labtext.Location = new System.Drawing.Point(58, 20);
            this.labtext.Name = "labtext";
            this.labtext.Size = new System.Drawing.Size(116, 18);
            this.labtext.TabIndex = 3;
            this.labtext.Text = "剩余移动次数";
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::RemoveTheBrickHappily.Properties.Resources.redbtn;
            this.buttonStop.Image = global::RemoveTheBrickHappily.Properties.Resources.redbtn;
            this.buttonStop.Location = new System.Drawing.Point(51, 226);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(123, 47);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "暂停游戏";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::RemoveTheBrickHappily.Properties.Resources.greenbtn1;
            this.btnStart.Location = new System.Drawing.Point(51, 141);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始游戏";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // NameforGame
            // 
            this.NameforGame.AutoSize = true;
            this.NameforGame.Font = new System.Drawing.Font("书体坊兰亭体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameforGame.Image = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.NameforGame.Location = new System.Drawing.Point(72, 60);
            this.NameforGame.Name = "NameforGame";
            this.NameforGame.Size = new System.Drawing.Size(78, 64);
            this.NameforGame.TabIndex = 0;
            this.NameforGame.Text = "18";
            this.NameforGame.Click += new System.EventHandler(this.NameforGame_Click);
            // 
            // Mypicture
            // 
            this.Mypicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mypicture.Location = new System.Drawing.Point(0, 0);
            this.Mypicture.Name = "Mypicture";
            this.Mypicture.Size = new System.Drawing.Size(814, 666);
            this.Mypicture.TabIndex = 0;
            this.Mypicture.TabStop = false;
            // 
            // Bgm
            // 
            this.Bgm.Enabled = true;
            this.Bgm.Location = new System.Drawing.Point(176, 0);
            this.Bgm.Name = "Bgm";
            this.Bgm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Bgm.OcxState")));
            this.Bgm.Size = new System.Drawing.Size(39, 36);
            this.Bgm.TabIndex = 4;
            this.Bgm.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 666);
            this.Controls.Add(this.panelgame);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.Mypicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "消消乐";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelgame.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mypicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bgm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Mypicture;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Panel panelgame;
        private System.Windows.Forms.Label NameforGame;
        private System.Windows.Forms.Label labelscore;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelaim;
        private System.Windows.Forms.Label labtext;
        private System.Windows.Forms.Label aim;
        private AxWMPLib.AxWindowsMediaPlayer Bgm;
    }
}

