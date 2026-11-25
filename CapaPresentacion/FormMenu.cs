using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMenu : Form
    {
        private string rolUsuario;

        public FormMenu(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (rolUsuario == "Generico")
            {
                btnChoferes.Enabled = false;
                btnBuses.Enabled = false;
                btnRutas.Enabled = false;
            }
        }

        private void AbrirFormularioEnPanel(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormChoferes());
        }

        private void btnBuses_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormAutobuses());
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormRutas());
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormAsignaciones());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Formlogin login = new Formlogin();
            login.Show();
            this.Close();
        }
    }
}