using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormAsignaciones : Form
    {
        private AsignacionLogica logica = new AsignacionLogica();

        public FormAsignaciones()
        {
            InitializeComponent();
            CargarTabla();
            RefrescarTodo();
        }

        private void FormAsignaciones_Load(object sender, EventArgs e)
        {
            RefrescarTodo();
        }

        private void RefrescarTodo()
        {
            CargarCombos();
            CargarTabla();
        }

        private void CargarCombos()
        {
            try
            {
                cmbChoferes.DataSource = logica.CargarChoferesDisponibles();
                cmbChoferes.DisplayMember = "Nombre";
                cmbChoferes.ValueMember = "IdChofer";
                cmbChoferes.SelectedIndex = -1;
                cmbAutobuses.DataSource = logica.CargarAutobusesDisponibles();
                cmbAutobuses.DisplayMember = "Placa";
                cmbAutobuses.ValueMember = "IdAutobus";
                cmbAutobuses.SelectedIndex = -1;
                cmbRutas.DataSource = logica.CargarRutasDisponibles();
                cmbRutas.DisplayMember = "NombreRuta";
                cmbRutas.ValueMember = "IdRuta";
                cmbRutas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listas de disponibilidad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTabla()
        {
            try
            {
                dgvAsignaciones.DataSource = null;
                dgvAsignaciones.DataSource = logica.ListarAsignacionesActivas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla de asignaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            try
            {
                logica.GuardarAsignacion(cmbChoferes.SelectedValue, cmbAutobuses.SelectedValue, cmbRutas.SelectedValue);

                MessageBox.Show("Asignación realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }
    }
}