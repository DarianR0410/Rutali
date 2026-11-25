namespace CapaPresentacion
{
    partial class FormMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAsignaciones = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnBuses = new System.Windows.Forms.Button();
            this.btnChoferes = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();

            this.pnlMenu.BackColor = System.Drawing.Color.Navy;
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnAsignaciones);
            this.pnlMenu.Controls.Add(this.btnRutas);
            this.pnlMenu.Controls.Add(this.btnBuses);
            this.pnlMenu.Controls.Add(this.btnChoferes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 553);
            this.pnlMenu.TabIndex = 0;

            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 503);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(250, 50);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            this.btnAsignaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignaciones.FlatAppearance.BorderSize = 0;
            this.btnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaciones.ForeColor = System.Drawing.Color.White;
            this.btnAsignaciones.Location = new System.Drawing.Point(0, 150);
            this.btnAsignaciones.Name = "btnAsignaciones";
            this.btnAsignaciones.Size = new System.Drawing.Size(250, 50);
            this.btnAsignaciones.TabIndex = 3;
            this.btnAsignaciones.Text = "ASIGNACIONES";
            this.btnAsignaciones.UseVisualStyleBackColor = true;
            this.btnAsignaciones.Click += new System.EventHandler(this.btnAsignaciones_Click);

            this.btnRutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRutas.FlatAppearance.BorderSize = 0;
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.ForeColor = System.Drawing.Color.White;
            this.btnRutas.Location = new System.Drawing.Point(0, 100);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(250, 50);
            this.btnRutas.TabIndex = 2;
            this.btnRutas.Text = "RUTAS";
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);

            this.btnBuses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuses.FlatAppearance.BorderSize = 0;
            this.btnBuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuses.ForeColor = System.Drawing.Color.White;
            this.btnBuses.Location = new System.Drawing.Point(0, 50);
            this.btnBuses.Name = "btnBuses";
            this.btnBuses.Size = new System.Drawing.Size(250, 50);
            this.btnBuses.TabIndex = 1;
            this.btnBuses.Text = "AUTOBUSES";
            this.btnBuses.UseVisualStyleBackColor = true;
            this.btnBuses.Click += new System.EventHandler(this.btnBuses_Click);

            this.btnChoferes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChoferes.FlatAppearance.BorderSize = 0;
            this.btnChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoferes.ForeColor = System.Drawing.Color.White;
            this.btnChoferes.Location = new System.Drawing.Point(0, 0);
            this.btnChoferes.Name = "btnChoferes";
            this.btnChoferes.Size = new System.Drawing.Size(250, 50);
            this.btnChoferes.TabIndex = 0;
            this.btnChoferes.Text = "GESTIÓN DE CHOFERES";
            this.btnChoferes.UseVisualStyleBackColor = true;
            this.btnChoferes.Click += new System.EventHandler(this.btnChoferes_Click);

            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(250, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(732, 553);
            this.pnlContenedor.TabIndex = 8;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Autobuses - Menú Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnChoferes;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAsignaciones;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnBuses;
    }
}