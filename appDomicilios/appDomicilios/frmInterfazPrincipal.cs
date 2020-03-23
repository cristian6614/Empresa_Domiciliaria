﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDomicilios
{
    public partial class frmInterfazPrincipal : Form
    {
        public frmInterfazPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCamaraComercio obj = new frmCamaraComercio();
            this.Hide();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCamaraComercio obj = new frmCamaraComercio();
            this.Hide();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmEmpresaDomiciliaria obj = new frmEmpresaDomiciliaria();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDomiciliario obj = new frmDomiciliario();
            this.Hide();
            obj.Show();


        }
    }
}
