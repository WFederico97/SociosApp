namespace SociosApp
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxCriterios = new System.Windows.Forms.GroupBox();
            this.dataGridViewSociosApp = new System.Windows.Forms.DataGridView();
            this.id_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.comboBoxApp = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelApp = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonDetalle = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBoxCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSociosApp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCriterios
            // 
            this.groupBoxCriterios.Controls.Add(this.dataGridViewSociosApp);
            this.groupBoxCriterios.Controls.Add(this.buttonConsultar);
            this.groupBoxCriterios.Controls.Add(this.comboBoxApp);
            this.groupBoxCriterios.Controls.Add(this.textBoxEmail);
            this.groupBoxCriterios.Controls.Add(this.labelApp);
            this.groupBoxCriterios.Controls.Add(this.labelEmail);
            this.groupBoxCriterios.Location = new System.Drawing.Point(79, 44);
            this.groupBoxCriterios.Name = "groupBoxCriterios";
            this.groupBoxCriterios.Size = new System.Drawing.Size(933, 507);
            this.groupBoxCriterios.TabIndex = 1;
            this.groupBoxCriterios.TabStop = false;
            this.groupBoxCriterios.Text = "Criterios";
            this.groupBoxCriterios.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewSociosApp
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewSociosApp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewSociosApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSociosApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSociosApp.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewSociosApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSociosApp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewSociosApp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewSociosApp.ColumnHeadersHeight = 29;
            this.dataGridViewSociosApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_socio,
            this.email,
            this.aplicacion});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSociosApp.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewSociosApp.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSociosApp.Location = new System.Drawing.Point(38, 234);
            this.dataGridViewSociosApp.Name = "dataGridViewSociosApp";
            this.dataGridViewSociosApp.RowHeadersWidth = 51;
            this.dataGridViewSociosApp.RowTemplate.Height = 24;
            this.dataGridViewSociosApp.Size = new System.Drawing.Size(858, 254);
            this.dataGridViewSociosApp.TabIndex = 5;
            this.dataGridViewSociosApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_socio
            // 
            this.id_socio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_socio.HeaderText = "Id";
            this.id_socio.MinimumWidth = 6;
            this.id_socio.Name = "id_socio";
            this.id_socio.Visible = false;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.email.DefaultCellStyle = dataGridViewCellStyle18;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // aplicacion
            // 
            this.aplicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.aplicacion.DefaultCellStyle = dataGridViewCellStyle19;
            this.aplicacion.HeaderText = "Application";
            this.aplicacion.MinimumWidth = 6;
            this.aplicacion.Name = "aplicacion";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(738, 149);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(158, 73);
            this.buttonConsultar.TabIndex = 4;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // comboBoxApp
            // 
            this.comboBoxApp.FormattingEnabled = true;
            this.comboBoxApp.Location = new System.Drawing.Point(109, 127);
            this.comboBoxApp.Name = "comboBoxApp";
            this.comboBoxApp.Size = new System.Drawing.Size(300, 24);
            this.comboBoxApp.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(113, 39);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(296, 22);
            this.textBoxEmail.TabIndex = 2;
            // 
            // labelApp
            // 
            this.labelApp.AutoSize = true;
            this.labelApp.Location = new System.Drawing.Point(35, 135);
            this.labelApp.Name = "labelApp";
            this.labelApp.Size = new System.Drawing.Size(32, 16);
            this.labelApp.TabIndex = 1;
            this.labelApp.Text = "App";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(35, 39);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(117, 577);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(103, 73);
            this.buttonNuevo.TabIndex = 6;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(226, 577);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(103, 73);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(335, 577);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(103, 73);
            this.buttonBorrar.TabIndex = 8;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonDetalle
            // 
            this.buttonDetalle.Location = new System.Drawing.Point(514, 577);
            this.buttonDetalle.Name = "buttonDetalle";
            this.buttonDetalle.Size = new System.Drawing.Size(103, 73);
            this.buttonDetalle.TabIndex = 9;
            this.buttonDetalle.Text = "Ver Detalle";
            this.buttonDetalle.UseVisualStyleBackColor = true;
            this.buttonDetalle.Click += new System.EventHandler(this.buttonDetalle_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(872, 577);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(103, 73);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 662);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonDetalle);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.groupBoxCriterios);
            this.Name = "Form1";
            this.Text = "FormSocios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCriterios.ResumeLayout(false);
            this.groupBoxCriterios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSociosApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCriterios;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DataGridView dataGridViewSociosApp;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.ComboBox comboBoxApp;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelApp;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonDetalle;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacion;
    }
}

