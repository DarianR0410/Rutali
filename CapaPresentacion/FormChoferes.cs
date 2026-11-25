using CapaNegocio;using System;using System.Data;using System.Windows.Forms;namespace CapaPresentacion
{
    public partial class FormChoferes : Form
    {
        private ChoferLogica logica = new ChoferLogica();

        public FormChoferes()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void FormChoferes_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            try
            {
                DataTable dt = logica.ListarChoferes();
                dgvChoferes.DataSource = null; 
                dgvChoferes.DataSource = dt;       
                dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                logica.RegistrarChofer(txtNombre.Text, txtApellido.Text, dtpFechaNac.Value, txtCedula.Text);

                MessageBox.Show("Chofer guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Clear();
                txtApellido.Clear();
                txtCedula.Clear();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void dgvChoferes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}