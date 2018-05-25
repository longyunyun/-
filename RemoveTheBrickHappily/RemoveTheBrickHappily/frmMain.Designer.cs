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
            this.panelgame = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelscore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameforGame = new System.Windows.Forms.Label();
            this.panelright = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.Mypicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelgame.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mypicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelgame
            // 
            this.panelgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelgame.Controls.Add(this.panel1);
            this.panelgame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgame.Location = new System.Drawing.Point(0, 0);
            this.panelgame.Name = "panelgame";
            this.panelgame.Size = new System.Drawing.Size(599, 666);
            this.panelgame.TabIndex = 3;
            this.panelgame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelgame_Paint);
            this.panelgame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelgame_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelscore);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 110);
            this.panel1.TabIndex = 0;
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
            // panelright
            // 
            this.panelright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelright.BackgroundImage = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.panelright.Controls.Add(this.label2);
            this.panelright.Controls.Add(this.buttonStop);
            this.panelright.Controls.Add(this.btnStart);
            this.panelright.Controls.Add(this.NameforGame);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelright.Location = new System.Drawing.Point(599, 0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(215, 666);
            this.panelright.TabIndex = 2;
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
            // Mypicture
            // 
            this.Mypicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mypicture.Location = new System.Drawing.Point(0, 0);
            this.Mypicture.Name = "Mypicture";
            this.Mypicture.Size = new System.Drawing.Size(814, 666);
            this.Mypicture.TabIndex = 0;
            this.Mypicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.label1.Location = new System.Drawing.Point(412, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "目标：得分大于2000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::RemoveTheBrickHappily.Properties.Resources.bg;
            this.label2.Location = new System.Drawing.Point(58, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "剩余移动次数";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mypicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Mypicture;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Panel panelgame;
        private System.Windows.Forms.Label NameforGame;
        private System.Windows.Forms.Label labelscore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

