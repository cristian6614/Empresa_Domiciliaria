namespace appDomicilios
{
    partial class frmCamaraComercio
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
            this.tblNombre = new System.Windows.Forms.Label();
            this.tblIdentificacion = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.tblEtiqueta = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(41, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 297);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnVolver);
            this.tabPage1.Controls.Add(this.tblNombre);
            this.tabPage1.Controls.Add(this.tblIdentificacion);
            this.tabPage1.Controls.Add(this.lbMensaje);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtIdentificacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblNombre
            // 
            this.tblNombre.AutoSize = true;
            this.tblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblNombre.Location = new System.Drawing.Point(163, 120);
            this.tblNombre.Name = "tblNombre";
            this.tblNombre.Size = new System.Drawing.Size(67, 16);
            this.tblNombre.TabIndex = 8;
            this.tblNombre.Text = "Nombre:";
            // 
            // tblIdentificacion
            // 
            this.tblIdentificacion.AutoSize = true;
            this.tblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblIdentificacion.Location = new System.Drawing.Point(146, 79);
            this.tblIdentificacion.Name = "tblIdentificacion";
            this.tblIdentificacion.Size = new System.Drawing.Size(100, 16);
            this.tblIdentificacion.TabIndex = 7;
            this.tblIdentificacion.Text = "Identificación";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(121, 29);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(313, 16);
            this.lbMensaje.TabIndex = 6;
            this.lbMensaje.Text = "Ingrese los datos de la camara de comercio";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(359, 211);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(302, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(302, 79);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 3;
            // 
            // tblEtiqueta
            // 
            this.tblEtiqueta.AutoSize = true;
            this.tblEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblEtiqueta.Location = new System.Drawing.Point(289, 21);
            this.tblEtiqueta.Name = "tblEtiqueta";
            this.tblEtiqueta.Size = new System.Drawing.Size(132, 16);
            this.tblEtiqueta.TabIndex = 8;
            this.tblEtiqueta.Text = "Camara Comercio";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(171, 211);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // CamaraComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 375);
            this.Controls.Add(this.tblEtiqueta);
            this.Controls.Add(this.tabControl1);
            this.Name = "CamaraComercio";
            this.Text = "camaraComercio";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label tblNombre;
        private System.Windows.Forms.Label tblIdentificacion;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label tblEtiqueta;
        private System.Windows.Forms.Button btnVolver;
    }
}