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
            this.Mypicture = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelgame = new System.Windows.Forms.Panel();
            this.NameforGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Mypicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelgame.SuspendLayout();
            this.SuspendLayout();
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(44, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始游戏";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(599, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 666);
            this.panel1.TabIndex = 2;
            // 
            // panelgame
            // 
            this.panelgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelgame.Controls.Add(this.NameforGame);
            this.panelgame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgame.Location = new System.Drawing.Point(0, 0);
            this.panelgame.Name = "panelgame";
            this.panelgame.Size = new System.Drawing.Size(599, 666);
            this.panelgame.TabIndex = 3;
            this.panelgame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelgame_Paint);
            this.panelgame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelgame_MouseDown);
            // 
            // NameforGame
            // 
            this.NameforGame.AutoSize = true;
            this.NameforGame.Font = new System.Drawing.Font("书体坊兰亭体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameforGame.Image = global::RemoveTheBrickHappily.Properties.Resources.greenbtn;
            this.NameforGame.Location = new System.Drawing.Point(12, 18);
            this.NameforGame.Name = "NameforGame";
            this.NameforGame.Size = new System.Drawing.Size(202, 64);
            this.NameforGame.TabIndex = 0;
            this.NameforGame.Text = "   步数   ";
            this.NameforGame.Click += new System.EventHandler(this.NameforGame_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 666);
            this.Controls.Add(this.panelgame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Mypicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "消消乐";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mypicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelgame.ResumeLayout(false);
            this.panelgame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Mypicture;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelgame;
        private System.Windows.Forms.Label NameforGame;
    }
}

