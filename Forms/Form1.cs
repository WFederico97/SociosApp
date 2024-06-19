using SociosApp.Classes;
using SociosApp.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SociosApp
{
    public partial class Form1 : Form
    {
        private DataAccess dataAccess;
        public Form1()
        {
            InitializeComponent();

            dataAccess = new DataAccess();
            buttonDetalle.Enabled = false;
            buttonEditar.Enabled = false;
            buttonBorrar.Enabled = false;
            dataGridViewSociosApp.SelectionChanged += DataGridViewSociosApp_SelectionChanged;
        }

        private void DataGridViewSociosApp_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSociosApp.CurrentRow != null && dataGridViewSociosApp.CurrentRow.Cells[0].Value != null && !string.IsNullOrEmpty(dataGridViewSociosApp.CurrentRow.Cells[0].Value.ToString()))
            {
                buttonDetalle.Enabled = true;  // Habilitar el botón "Detalle"
                buttonEditar.Enabled = true;  // Habilitar el botón "Editar"
                buttonBorrar.Enabled = true;  // Habilitar el botón "Borrar"
            }
            else
            {
                buttonDetalle.Enabled = false;  // Deshabilitar el botón "Detalle"
                buttonEditar.Enabled = false;  // Deshabilitar el botón "Editar"
                buttonBorrar.Enabled = false;  // Deshabilitar el botón "Borrar"
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            DataTable dataTable = dataAccess.ConsultarCombos("aplicaciones"); //Consulto la tabla aplicaciones
            comboBoxApp.DataSource = dataTable; //Cargo el comboBox con los datos del dataTable
            comboBoxApp.ValueMember = dataTable.Columns[0].ColumnName; //Indico que el valor del comboBox es el valor de la columna 0
            comboBoxApp.DisplayMember = dataTable.Columns[1].ColumnName; //Indico que el valor a mostrar en el comboBox es el valor de la columna 1
            comboBoxApp.SelectedIndex = -1;
        }
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            string consultaSocio = "SELECT  s.id_socio, s.email, a.nombre_app FROM socios s " +
                "JOIN aplicaciones a ON s.aplicacion = a.id_app";
            if (!string.IsNullOrEmpty(textBoxEmail.Text))
            {
                consultaSocio += " WHERE s.email LIKE '%" + textBoxEmail.Text + "%'";
            }
            if (comboBoxApp.SelectedIndex != -1 && !string.IsNullOrEmpty(textBoxEmail.Text))
            {
                consultaSocio += " AND s.aplicacion = " + comboBoxApp.SelectedValue;
            }
            if(comboBoxApp.SelectedIndex != -1 && string.IsNullOrEmpty(textBoxEmail.Text))
            {
                consultaSocio += " WHERE s.aplicacion = " + comboBoxApp.SelectedValue;
            }
            CargarGrilla(consultaSocio);
        }

        private void CargarGrilla(string consultaSocio)
        {
            DataTable dataTable = dataAccess.ConsultarBd(consultaSocio);
            dataGridViewSociosApp.Rows.Clear();
            foreach(DataRow row in dataTable.Rows)
            {
                dataGridViewSociosApp.Rows.Add(row[0], row[1], row[2]);
            }
        }

        private void buttonDetalle_Click(object sender, EventArgs e)
        {
            int nroSocio = Convert.ToInt32(dataGridViewSociosApp.CurrentRow.Cells[0].Value);
            FormDetalles formDetalles = new FormDetalles(nroSocio, FormDetalles.Modo.Ver);
            formDetalles.ShowDialog();
        }
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            FormDetalles form = new FormDetalles(0,FormDetalles.Modo.Nuevo);
            form.ShowDialog();
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int nroSocio = Convert.ToInt32(dataGridViewSociosApp.CurrentRow.Cells[0].Value);
            FormDetalles form = new FormDetalles(nroSocio, FormDetalles.Modo.Editar);
            form.ShowDialog();
        }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int nroSocio = Convert.ToInt32(dataGridViewSociosApp.CurrentRow.Cells[0].Value);
            FormDetalles form = new FormDetalles(nroSocio, FormDetalles.Modo.Eliminar);
            form.ShowDialog();
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro de que quiere abandonar la aplicacion ?", 
                "Cerrar", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
