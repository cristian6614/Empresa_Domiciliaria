using appDomicilios.logica;
using System;
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
    public partial class frmEmpresaDomiciliaria : Form
    {
        public frmEmpresaDomiciliaria()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        clsEmpresaDomiciliaria objempresa = new clsEmpresaDomiciliaria();
        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = null;
            int nit = 0;
            int resultado = 0;
            DateTimePicker fecha = new DateTimePicker();
            nombre = txtNombreEmp.Text;
            nit = int.Parse(txtNitEmp.Text);
            fecha = dtpFechaAperturaEmp;


            resultado = objempresa.registrarEmpresaDomiciliaria(nit,nombre,fecha);
            if (resultado > 0)
            {
                MessageBox.Show("Camara de Comercio Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Camara de comercio no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
        }
    }
}
