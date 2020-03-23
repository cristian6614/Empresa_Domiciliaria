namespace appDomicilios
{
    partial class frmEmpresaDomiciliaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpFechaAperturaEmp = new System.Windows.Forms.DateTimePicker();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.btnRegistratEmprDom = new System.Windows.Forms.Button();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.txtNitEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarCamComercio = new System.Windows.Forms.Button();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(70, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 297);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlConsulta);
            this.tabPage1.Controls.Add(this.dtpFechaAperturaEmp);
            this.tabPage1.Controls.Add(this.lblFechaApertura);
            this.tabPage1.Controls.Add(this.btnRegistratEmprDom);
            this.tabPage1.Controls.Add(this.txtNombreEmp);
            this.tabPage1.Controls.Add(this.txtNitEmp);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dtpFechaAperturaEmp
            // 
            this.dtpFechaAperturaEmp.Location = new System.Drawing.Point(118, 125);
            this.dtpFechaAperturaEmp.Name = "dtpFechaAperturaEmp";
            this.dtpFechaAperturaEmp.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAperturaEmp.TabIndex = 8;
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Location = new System.Drawing.Point(6, 131);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(80, 13);
            this.lblFechaApertura.TabIndex = 7;
            this.lblFechaApertura.Text = "Fecha Apertura";
            // 
            // btnRegistratEmprDom
            // 
            this.btnRegistratEmprDom.Location = new System.Drawing.Point(143, 198);
            this.btnRegistratEmprDom.Name = "btnRegistratEmprDom";
            this.btnRegistratEmprDom.Size = new System.Drawing.Size(75, 23);
            this.btnRegistratEmprDom.TabIndex = 5;
            this.btnRegistratEmprDom.Text = "Registrar";
            this.btnRegistratEmprDom.UseVisualStyleBackColor = true;
            this.btnRegistratEmprDom.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(118, 77);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmp.TabIndex = 4;
            this.txtNombreEmp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNitEmp
            // 
            this.txtNitEmp.Location = new System.Drawing.Point(118, 37);
            this.txtNitEmp.Name = "txtNitEmp";
            this.txtNitEmp.Size = new System.Drawing.Size(100, 20);
            this.txtNitEmp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nit Empresa";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(609, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa Domiciliaria";
            // 
            // btnConsultarCamComercio
            // 
            this.btnConsultarCamComercio.Location = new System.Drawing.Point(58, 26);
            this.btnConsultarCamComercio.Name = "btnConsultarCamComercio";
            this.btnConsultarCamComercio.Size = new System.Drawing.Size(170, 23);
            this.btnConsultarCamComercio.TabIndex = 9;
            this.btnConsultarCamComercio.Text = "Consultar Camaras de Comercio";
            this.btnConsultarCamComercio.UseVisualStyleBackColor = true;
            this.btnConsultarCamComercio.Click += new System.EventHandler(this.btnConsultarCamComercio_Click);
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.dgvDatos);
            this.pnlConsulta.Controls.Add(this.btnConsultarCamComercio);
            this.pnlConsulta.Location = new System.Drawing.Point(324, 6);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(282, 257);
            this.pnlConsulta.TabIndex = 10;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(3, 55);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(276, 202);
            this.dgvDatos.TabIndex = 1;
            // 
            // frmEmpresaDomiciliaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEmpresaDomiciliaria";
            this.Text = "EmpresaDomiciliaria";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRegistratEmprDom;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.TextBox txtNitEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaAperturaEmp;
        private System.Windows.Forms.Label lblFechaApertura;
        private System.Windows.Forms.Button btnConsultarCamComercio;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}