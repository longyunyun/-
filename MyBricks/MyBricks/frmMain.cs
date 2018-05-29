using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBricks
{
    public partial class frmMain : Form
    {
        private Game game;
        public frmMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //开关时钟
            this.timerGame.Enabled = !this.timerGame.Enabled;
            this.panelgame.Invalidate();

        }

        private void panelgame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panelgame.CreateGraphics();
            game.Draw(g);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            game = new Game(this.panelgame.Width,this.panelgame.Height);
            game.gameover += Game_gameover;
        }

        private void Game_gameover()
        {//真正的响应程序
         //  throw new NotImplementedException();
            this.timerGame.Enabled = false;
            MessageBox.Show("Game Over");
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {//游戏走一步
            game.Step();
            //重绘游戏区域
            this.panelgame.Invalidate();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            game.move(e.KeyCode.ToString());
            this.panelgame.Invalidate();
        }
    }
}
