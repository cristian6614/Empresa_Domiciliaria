using appDomicilios.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDomicilios
{
    public partial class frmEmpresaDomiciliaria : Form
    {
        string cadenaConexion = "Data Source = localhost; User ID = domicilios; Password = 1234";

        clsEmpresaDomiciliaria objempresa = new clsEmpresaDomiciliaria();
        clsCamaraComercio objcamcomercio = new clsCamaraComercio();


        public frmEmpresaDomiciliaria()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = null;
            int nit = 0;
            int resultado = 0;
            DateTimePicker fecha = new DateTimePicker();
            fecha.CustomFormat = "DD/MM/yyyy";
            fecha.Format = DateTimePickerFormat.Custom;

            int camNit = objcamcomercio.getcodigo();
           
            nombre = txtNombreEmp.Text;
            nit = int.Parse(txtNitEmp.Text);
            fecha = dtpFechaAperturaEmp;


            resultado = objempresa.registrarEmpresaDomiciliaria(nit,nombre,fecha, camNit);
            if (resultado > 0)
            {
                MessageBox.Show("Empresa Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empresa no registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNitEmp.Text = "";
            txtNombreEmp.Text = "";
            dtpFechaAperturaEmp = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbxCamaraComercioConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void btnConsultarCamComercio_Click(object sender, EventArgs e)
        {

            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            OracleCommand miComando = new OracleCommand("select camid from camaracomercio", miConexion);
            miConexion.Open();
            OracleDataReader registro = miComando.ExecuteReader();
            while (registro.Read()) {
                cbxCamaComer.Items.Add(registro["camId"].ToString());
            }
            miConexion.Close();        

            //creo un dataset vacio
            DataSet dsResultado = new DataSet();
            dsResultado = objcamcomercio.consultarRegistros();
            dgvDatos.DataSource = dsResultado;
            dgvDatos.DataMember = "ResultadoDatos";

        }

        private void lblIdCamCom_Click(object sender, EventArgs e)
        {

        }
    }
}
