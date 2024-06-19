using SociosApp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SociosApp.Forms
{
    public partial class FormDetalles : Form
    {
        public enum Modo
        {
            Nuevo,
            Ver,
            Editar,
            Eliminar
        }
        int nroSocio;
        Modo accion;
        DataAccess dataAccess = new DataAccess();
        Socio socio = new Socio();
        List<Parameters> parameters = new List<Parameters>();
        public FormDetalles()
        {
            InitializeComponent();
            textBoxSocio.Enabled = false;
        }
        public FormDetalles(int nroSocio, Modo accion)
        {
            InitializeComponent();
            this.accion = accion;
            this.nroSocio = nroSocio;
            textBoxSocio.Enabled = false;

        }
        private void FormDetalles_Load(object sender, EventArgs e)
        {
            CargarCombo();
            if (accion != Modo.Nuevo)
            {
                CargarSocio(nroSocio);
                if(accion == Modo.Editar)
                {
                    textBoxEmail.Enabled = true;
                    comboBoxApp.Enabled = true;
                }
                else if(accion == Modo.Eliminar)
                {
                    textBoxEmail.Enabled = false;
                    comboBoxApp.Enabled = false;
                }
            }
        }

        private void CargarSocio(int nroSocio)
        {
            string querySocio = $"SELECT * FROM socios WHERE id_socio = {nroSocio} ";
            DataTable dataTable = dataAccess.ConsultarBd(querySocio);
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                socio.IdSocio = Convert.ToInt32(row[0]);
                socio.EmailSocio = Convert.ToString(row[1]);
                socio.Aplicacion = Convert.ToInt32(row[2]);

                textBoxEmail.Text = socio.EmailSocio;
                textBoxSocio.Text = socio.IdSocio.ToString();
                comboBoxApp.SelectedValue = socio.Aplicacion;
            }

        }

        private void CargarCombo()
        {
            DataTable dataTable = dataAccess.ConsultarCombos("aplicaciones");
            comboBoxApp.DataSource = dataTable;
            comboBoxApp.ValueMember = dataTable.Columns[0].ColumnName;
            comboBoxApp.DisplayMember = dataTable.Columns[1].ColumnName;
            comboBoxApp.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            socio.IdSocio = Convert.ToInt32(textBoxSocio.Text);
            socio.EmailSocio = textBoxEmail.Text;
            socio.Aplicacion = Convert.ToInt32(comboBoxApp.SelectedValue);
            if (accion == Modo.Nuevo)
            {
                NuevoSocio();
               
            }
            else if (accion == Modo.Editar)
            {
                EditarSocio(nroSocio);
            }
            else if (accion == Modo.Eliminar)
            {
                EliminarSocio(nroSocio);
            }
            this.Close();
        }

        private void EditarSocio(int nroSocio)
        {
            string queryEditar = $"UPDATE socios SET email = @email, aplicacion = @aplicacion WHERE id_socio ={nroSocio}";
            parameters.Add(new Parameters("@email", socio.EmailSocio));
            parameters.Add(new Parameters("@aplicacion", socio.Aplicacion));
            int affectedRows = dataAccess.ActualizarBd(queryEditar, parameters);
            if (affectedRows == 0)
            {
                MessageBox.Show("No se pudo insertar el socio");
            }
            else
            {
                MessageBox.Show("Socio insertado correctamente");
            }
        }

        private void EliminarSocio(int nroSocio)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el socio?", 
                "Eliminar Socio", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string queryInsert = $"DELETE from socios WHERE id_socio = {nroSocio}";
                int affectedRows = dataAccess.ActualizarBd(queryInsert);
                if(affectedRows == 0)
                {
                    MessageBox.Show("No se pudo eliminar el socio");
                }
                else
                {
                    MessageBox.Show("Socio eliminado correctamente");
                }
            }
        }


        private void NuevoSocio()
        {
            string queryInsert = "INSERT INTO socios (email, aplicacion) VALUES(@email,@aplicacion)";
            parameters.Add(new Parameters("@email", socio.EmailSocio));
            parameters.Add(new Parameters("@aplicacion", socio.Aplicacion));
            int affectedRows = dataAccess.ActualizarBd(queryInsert, parameters);
            if(affectedRows == 0)
            {
                MessageBox.Show("No se pudo insertar el socio");
            }
            else
            {
                MessageBox.Show("Socio Modificado correctamente");
            }
        }
    }
}
