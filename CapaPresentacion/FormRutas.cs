using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormRutas : Form
    {
        private RutaLogica logica = new RutaLogica();

        public FormRutas()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void FormRutas_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            try
            {
                dgvRutas.DataSource = null;
                dgvRutas.DataSource = logica.ListarRutas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar rutas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                logica.RegistrarRuta(txtNombreRuta.Text.Trim());
                MessageBox.Show("Ruta registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreRuta.Clear();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}