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
    public partial class camaraComercio : Form
    {
        public camaraComercio()
        {
            InitializeComponent();
        }

        //cuando se presiona el boton registrar
        private void button1_Click(object sender, EventArgs e)
        {
            String Nombre = null;
            int identificacion = 0;
            Nombre = txtIdentificacion.Text;
            identificacion = int.Parse (txtNombre.Text);


        }
    }
}
