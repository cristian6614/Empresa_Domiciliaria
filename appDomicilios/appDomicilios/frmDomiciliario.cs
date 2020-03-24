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
    public partial class frmDomiciliario : Form
    {
        public frmDomiciliario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //registrar domiciliario

            String varApellido, varNombre, varAnios, varEstado = "";
            int varId, resultado;

            varId = int.Parse(txtId.Text);
            varNombre = txtNombre.Text;
            varApellido = txtApellido.Text;
            if (rbActivo.Checked)
            {
                varEstado = "hembra";
            }
            else if (rbInactivo.Checked)
            {
                varEstado = "macho";
            }
            varAnios = cbxAniosExperiencia.Text;

            /* enviar resultado a la logica.domiciliario*/
              resultado = 0;
            /* mensaje en pantalla*/
            if (resultado > 0)
            {
                MessageBox.Show("Domiciliario Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Domiciliario No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInterfazPrincipal objInterfaz = new frmInterfazPrincipal();
            this.Hide();
            objInterfaz.Show();

        }
    }
}
