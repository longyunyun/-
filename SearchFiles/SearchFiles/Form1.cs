using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace SearchFiles
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
         
                string[] dirs = Directory.GetFiles(@"e:\", textBox1.Text, SearchOption.AllDirectories);
                foreach (string dir in dirs)
                {
                ListBox listBox1 = this.listBox1;
                    this.result.Text=result.Text+(dir+"\r\n") ;
               this.listBox1.Items.Add("dir");
                }

            this.Text = ($"共{this.listBox1.Items.Count}个结果");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}