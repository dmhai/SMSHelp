﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMSBase.Base;
namespace SMSHelp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {                       
            var clsaima = new ZhiJingSMSBase();
            Console.WriteLine(clsaima.Login("lin01ok","6565810ok"));
            Console.WriteLine(clsaima.Token);
            Console.WriteLine(clsaima.GetPhoneMsg("21472","13556489648",out string aa));
            Console.WriteLine(clsaima.ErrMsg);
        }
    }
}
