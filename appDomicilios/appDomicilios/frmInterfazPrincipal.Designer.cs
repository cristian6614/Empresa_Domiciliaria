namespace appDomicilios
{
    partial class frmInterfazPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "domicilios.com";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(65, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 331);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::appDomicilios.Properties.Resources.domicilios;
            this.pictureBox2.Location = new System.Drawing.Point(297, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(59, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "Gestionar Domiciliario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(59, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(196, 37);
            this.button5.TabIndex = 1;
            this.button5.Text = "Gestionar Empresa Domiciliaria";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(59, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 32);
            this.button6.TabIndex = 0;
            this.button6.Text = "registrar camara comercio";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmInterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "frmInterfazPrincipal";
            this.Text = "iInterfazPrincipal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}