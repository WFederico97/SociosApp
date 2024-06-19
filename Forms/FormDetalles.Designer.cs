namespace SociosApp.Forms
{
    partial class FormDetalles
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
            this.labelTxtSocio = new System.Windows.Forms.Label();
            this.labelTxtEmail = new System.Windows.Forms.Label();
            this.labelCBApp = new System.Windows.Forms.Label();
            this.textBoxSocio = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxApp = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTxtSocio
            // 
            this.labelTxtSocio.AutoSize = true;
            this.labelTxtSocio.Location = new System.Drawing.Point(75, 50);
            this.labelTxtSocio.Name = "labelTxtSocio";
            this.labelTxtSocio.Size = new System.Drawing.Size(73, 16);
            this.labelTxtSocio.TabIndex = 0;
            this.labelTxtSocio.Text = "Nro Socio :";
            // 
            // labelTxtEmail
            // 
            this.labelTxtEmail.AutoSize = true;
            this.labelTxtEmail.Location = new System.Drawing.Point(75, 110);
            this.labelTxtEmail.Name = "labelTxtEmail";
            this.labelTxtEmail.Size = new System.Drawing.Size(47, 16);
            this.labelTxtEmail.TabIndex = 1;
            this.labelTxtEmail.Text = "Email :";
            // 
            // labelCBApp
            // 
            this.labelCBApp.AutoSize = true;
            this.labelCBApp.Location = new System.Drawing.Point(75, 177);
            this.labelCBApp.Name = "labelCBApp";
            this.labelCBApp.Size = new System.Drawing.Size(76, 16);
            this.labelCBApp.TabIndex = 2;
            this.labelCBApp.Text = "Aplicacion :";
            // 
            // textBoxSocio
            // 
            this.textBoxSocio.Location = new System.Drawing.Point(165, 50);
            this.textBoxSocio.Name = "textBoxSocio";
            this.textBoxSocio.Size = new System.Drawing.Size(322, 22);
            this.textBoxSocio.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(165, 110);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(322, 22);
            this.textBoxEmail.TabIndex = 4;
            // 
            // comboBoxApp
            // 
            this.comboBoxApp.FormattingEnabled = true;
            this.comboBoxApp.Location = new System.Drawing.Point(165, 174);
            this.comboBoxApp.Name = "comboBoxApp";
            this.comboBoxApp.Size = new System.Drawing.Size(322, 24);
            this.comboBoxApp.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(148, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 52);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(378, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 52);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 526);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBoxApp);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSocio);
            this.Controls.Add(this.labelCBApp);
            this.Controls.Add(this.labelTxtEmail);
            this.Controls.Add(this.labelTxtSocio);
            this.Name = "FormDetalles";
            this.Text = "FormDetalles";
            this.Load += new System.EventHandler(this.FormDetalles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTxtSocio;
        private System.Windows.Forms.Label labelTxtEmail;
        private System.Windows.Forms.Label labelCBApp;
        private System.Windows.Forms.TextBox textBoxSocio;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxApp;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}