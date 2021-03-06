﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Progress_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int rowMax = 10000;
            int colMax = 10000;
            decimal pcdDone;

            for (int i = 0; i < rowMax; i++)
            {
                button1.Enabled = false;
                for (int j = 0; j < colMax; j++)
                {
                    counter++;
                }
                pcdDone = (decimal)counter / (rowMax * colMax);
                //groupBox1.Text = ((int)(pcdDone * 100)).ToString() + " %";
                groupBox1.Refresh();

                label1.Width = Convert.ToInt32(pcdDone * (groupBox1.Width - 10));
            }
            button1.Enabled = true;
        }
    }
}
