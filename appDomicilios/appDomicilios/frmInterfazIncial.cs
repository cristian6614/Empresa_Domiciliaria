using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace appDomicilios
{
    public partial class frmInterfazIncial : Form
    {
        public frmInterfazIncial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleConnection orac = new OracleConnection("DATA SOURCE = xe ; PASSWORD=1234; USER ID = domicilios;");
            orac.Open();
            MessageBox.Show("Conectado");
            frmInterfazPrincipal obj = new frmInterfazPrincipal();
            this.Hide();
            obj.Show();

        }
    }
}
