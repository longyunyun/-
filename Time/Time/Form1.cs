﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer1.Interval = int.Parse(numericUpDown1.Text) * 1000;

            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Start();
      

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {


            MessageBox.Show("时间到");
            this.Close();

        }
    }
}
