using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveTheBrickHappily
{
    public partial class frmMain : Form
    {
        private Game game;
        SoundPlayer sp = new SoundPlayer(Properties.Resources.GameSceneBGM_01);

        private int n = 1;
        public frmMain()
        {
            InitializeComponent();
            //循环播放        
            Bgm.settings.setMode("loop", true);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
           // sp.PlayLooping();
            Bgm.URL = Application.StartupPath +@"\GameSceneBGM.mp3";
            Bgm.Ctlcontrols.play();

        }
        /// <summary>
        /// 游戏开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
             n = 1;
            this.Text = "消消乐——第"+n+"关";
            this.labelscore.Text = "0";

            game = new Game(this.panelgame.Width, this.panelgame.Height);
       
            Graphics g = this.panelgame.CreateGraphics();

           
            this.aim.Text = "2000";//目标最小
            this.NameforGame.Text = game.step.ToString();
            game.Draw(g);
            game.isclean(g);
            game.Down(g);
            game.score = 0;//分数清零

            this.btnStart.Text = "重新开始";
            this.buttonStop.Text = "暂停游戏";
            this.buttonStop.Image = Properties.Resources.redbtn;

        }

        private void panelgame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panelgame.CreateGraphics();
            g.DrawImage(Properties.Resources.bg, 0, 0,this.panelgame.Width,this.panelgame.Height);
        }
      
        /// <summary>
        /// 点击鼠标刷新分数 步数 判断是否游戏继续
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelgame_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.buttonStop.Text == "暂停游戏")
            {
                game.Mouse(e.X, e.Y, this.panelgame.CreateGraphics());
                this.NameforGame.Text = game.step.ToString();
                this.labelscore.Text = game.score.ToString();
                if (Convert.ToInt32(this.labelscore.Text )>=Convert.ToInt32( this.aim.Text))
                {
                    if (MessageBox.Show("恭喜闯关成功，还想继续挑战自己吗?再来一关？", "闯关成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                    {
                       
                        n +=1;
                        this.Text = "消消乐——第"+n+"关";
                      
                        this.aim.Text = Convert.ToString(Convert.ToInt32(this.aim.Text) + 2000);//目标分数变化
                        this.labelscore.Text = "0";

                        this.btnStart.Text = "重新开始";
                        this.buttonStop.Text = "暂停游戏";
                        this.buttonStop.Image = Properties.Resources.redbtn;
                        game = new Game(this.panelgame.Width, this.panelgame.Height);
                        game.step = game.step -= 2;
                        this.NameforGame.Text = game.step.ToString();
                        Graphics g = this.panelgame.CreateGraphics();
                        game.Draw(g);
                        game.isclean(g);
                        game.Down(g);
                        game.score = 0;

                    }
                }
                if (this.NameforGame.Text == "0")
                {
                    MessageBox.Show("Game over!");

                }
            }
          
        }

        private void NameforGame_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.buttonStop.Text == "继续游戏")
            {
                this.buttonStop.Text = "暂停游戏";
                this.buttonStop.Image = Properties.Resources.redbtn;

                Bgm.URL = Application.StartupPath + @"\GameSceneBGM.mp3";
                Bgm.Ctlcontrols.play();
            }
            else
            {
                this.buttonStop.Text = "继续游戏";
                this.buttonStop.Image = Properties.Resources.greenbtn1;
              
                Bgm.Ctlcontrols.stop();

            }

        }

      
    }
}
