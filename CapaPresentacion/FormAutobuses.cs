using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormAutobuses : Form
    {
        private AutobusLogica logica = new AutobusLogica();

        public FormAutobuses()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void FormAutobuses_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            try
            {
                dgvAutobuses.DataSource = null;
                dgvAutobuses.DataSource = logica.ListarAutobuses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar autobuses: " + ex.Message);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                logica.RegistrarAutobus(
                    txtMarca.Text.Trim(),
                    txtModelo.Text.Trim(),
                    txtPlaca.Text.Trim(),
                    txtColor.Text.Trim(),
                    txtAnio.Text.Trim()
                );

                MessageBox.Show("Autobús registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMarca.Clear();
                txtModelo.Clear();
                txtPlaca.Clear();
                txtColor.Clear();
                txtAnio.Clear();

                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvAutobuses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}