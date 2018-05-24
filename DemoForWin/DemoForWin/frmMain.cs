using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForWin
{
    public partial class frmMain : Form
    {
        private Game game;
        public frmMain()
        {
            InitializeComponent();
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
             game = new Game();
        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            this.Text = System.DateTime.Now.ToString();
            Graphics g = this.panelGame.CreateGraphics();
            game.Draw(g);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.panelGame.Invalidate();
        }
    }
}
