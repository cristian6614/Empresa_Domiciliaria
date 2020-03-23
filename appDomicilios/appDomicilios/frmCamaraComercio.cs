using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appDomicilios.logica; // <-
namespace appDomicilios
{
    public partial class frmCamaraComercio : Form
    {
        public frmCamaraComercio()
        {
            InitializeComponent();
        }

        clsCamaraComercio objCamara = new clsCamaraComercio();
        //cuando se presiona el boton registrar
        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = null;
            int identificacion = 0, resultado = 0;
            nombre = txtNombre.Text;
            identificacion = int.Parse (txtIdentificacion.Text);

            objCamara.setcodigo(identificacion);
            objCamara.setnombre(nombre);
            resultado = objCamara.registrarCamaraComercio();
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
