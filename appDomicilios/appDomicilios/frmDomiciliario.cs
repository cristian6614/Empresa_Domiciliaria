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




            resultado = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInterfazPrincipal objInterfaz = new frmInterfazPrincipal();
            this.Hide();
            objInterfaz.Show();

        }
    }
}
