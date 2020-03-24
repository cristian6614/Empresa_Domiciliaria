namespace appDomicilios
{
    partial class frmDomiciliario
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbcGestionarDomiciliario = new System.Windows.Forms.TabControl();
            this.tbpRegistro = new System.Windows.Forms.TabPage();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tbpActualizar = new System.Windows.Forms.TabPage();
            this.tblEtiqueta = new System.Windows.Forms.Label();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.cbxAniosExperiencia = new System.Windows.Forms.ComboBox();
            this.tbpEliminar = new System.Windows.Forms.TabPage();
            this.tbcGestionarDomiciliario.SuspendLayout();
            this.tbpRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestionarDomiciliario
            // 
            this.tbcGestionarDomiciliario.Controls.Add(this.tbpRegistro);
            this.tbcGestionarDomiciliario.Controls.Add(this.tbpActualizar);
            this.tbcGestionarDomiciliario.Controls.Add(this.tbpEliminar);
            this.tbcGestionarDomiciliario.Location = new System.Drawing.Point(65, 46);
            this.tbcGestionarDomiciliario.Name = "tbcGestionarDomiciliario";
            this.tbcGestionarDomiciliario.SelectedIndex = 0;
            this.tbcGestionarDomiciliario.Size = new System.Drawing.Size(538, 354);
            this.tbcGestionarDomiciliario.TabIndex = 1;
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.Controls.Add(this.cbxAniosExperiencia);
            this.tbpRegistro.Controls.Add(this.rbInactivo);
            this.tbpRegistro.Controls.Add(this.rbActivo);
            this.tbpRegistro.Controls.Add(this.btnVolver);
            this.tbpRegistro.Controls.Add(this.label5);
            this.tbpRegistro.Controls.Add(this.label3);
            this.tbpRegistro.Controls.Add(this.txtApellido);
            this.tbpRegistro.Controls.Add(this.label1);
            this.tbpRegistro.Controls.Add(this.label4);
            this.tbpRegistro.Controls.Add(this.label2);
            this.tbpRegistro.Controls.Add(this.btnRegistrar);
            this.tbpRegistro.Controls.Add(this.txtNombre);
            this.tbpRegistro.Controls.Add(this.txtId);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(530, 328);
            this.tbpRegistro.TabIndex = 0;
            this.tbpRegistro.Text = "Registrar";
            this.tbpRegistro.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(140, 258);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "años experiencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "estado";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(210, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "id";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(368, 258);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(210, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // tbpActualizar
            // 
            this.tbpActualizar.Location = new System.Drawing.Point(4, 22);
            this.tbpActualizar.Name = "tbpActualizar";
            this.tbpActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpActualizar.Size = new System.Drawing.Size(530, 328);
            this.tbpActualizar.TabIndex = 1;
            this.tbpActualizar.Text = "Actualizar";
            this.tbpActualizar.UseVisualStyleBackColor = true;
            // 
            // tblEtiqueta
            // 
            this.tblEtiqueta.AutoSize = true;
            this.tblEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblEtiqueta.Location = new System.Drawing.Point(301, 27);
            this.tblEtiqueta.Name = "tblEtiqueta";
            this.tblEtiqueta.Size = new System.Drawing.Size(91, 16);
            this.tblEtiqueta.TabIndex = 9;
            this.tblEtiqueta.Text = "Domiciliario";
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(187, 165);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 18;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(253, 165);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbInactivo.TabIndex = 19;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // cbxAniosExperiencia
            // 
            this.cbxAniosExperiencia.FormattingEnabled = true;
            this.cbxAniosExperiencia.Items.AddRange(new object[] {
            "menor de 5 años",
            "5 y 10 años",
            "de 11 a 20 años",
            "mas de 20 años"});
            this.cbxAniosExperiencia.Location = new System.Drawing.Point(210, 131);
            this.cbxAniosExperiencia.Name = "cbxAniosExperiencia";
            this.cbxAniosExperiencia.Size = new System.Drawing.Size(121, 21);
            this.cbxAniosExperiencia.TabIndex = 20;
            // 
            // tbpEliminar
            // 
            this.tbpEliminar.Location = new System.Drawing.Point(4, 22);
            this.tbpEliminar.Name = "tbpEliminar";
            this.tbpEliminar.Size = new System.Drawing.Size(530, 328);
            this.tbpEliminar.TabIndex = 2;
            this.tbpEliminar.Text = "Eliminar";
            this.tbpEliminar.UseVisualStyleBackColor = true;
            // 
            // frmDomiciliario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 443);
            this.Controls.Add(this.tblEtiqueta);
            this.Controls.Add(this.tbcGestionarDomiciliario);
            this.Name = "frmDomiciliario";
            this.Text = "Domiciliario";
            this.tbcGestionarDomiciliario.ResumeLayout(false);
            this.tbpRegistro.ResumeLayout(false);
            this.tbpRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tbcGestionarDomiciliario;
        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TabPage tbpActualizar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tblEtiqueta;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.ComboBox cbxAniosExperiencia;
        private System.Windows.Forms.TabPage tbpEliminar;
    }
}