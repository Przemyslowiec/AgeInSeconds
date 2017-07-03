﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeInSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seconds_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DateTime date = dateTimePicker1.Value.Date;
                DateTime now = DateTime.Now;
                TimeSpan a = now - date;
                seconds_textBox.Text = Math.Round( a.TotalSeconds,0).ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
