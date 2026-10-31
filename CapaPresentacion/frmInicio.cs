using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmInicio : Form
    {
        private System.Windows.Forms.Timer reloj;

        public frmInicio()
        {
            InitializeComponent();
            CrearPanelInicio();
        }

        private void CrearPanelInicio()
        {
            this.Controls.Clear();
            this.BackColor = Color.FromArgb(244, 246, 249);

            CrearBienvenida();
            CrearTarjetas();
            CrearAccesosRapidos();
            CrearFechaHora();
        }

        private void CrearBienvenida()
        {
            Panel pnlBienvenida = new Panel();

            pnlBienvenida.Location = new Point(25, 20);
            pnlBienvenida.Size = new Size(790, 90);
            pnlBienvenida.BackColor = Color.White;

            Label lblBienvenida = new Label();

            lblBienvenida.Text =
                "BIENVENIDO AL SISTEMA DE CITAS MÉDICAS";

            lblBienvenida.Location = new Point(25, 18);
            lblBienvenida.Size = new Size(720, 30);

            lblBienvenida.Font =
                new Font(
                    "Segoe UI",
                    16,
                    FontStyle.Bold);

            lblBienvenida.ForeColor =
                Color.FromArgb(13, 54, 93);

            Label lblDescripcion = new Label();

            lblDescripcion.Text =
                "Administre pacientes, médicos, horarios, citas y reportes desde un solo lugar.";

            lblDescripcion.Location =
                new Point(27, 52);

            lblDescripcion.Size =
                new Size(720, 25);

            lblDescripcion.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Regular);

            lblDescripcion.ForeColor =
                Color.DimGray;

            pnlBienvenida.Controls.Add(lblBienvenida);
            pnlBienvenida.Controls.Add(lblDescripcion);

            this.Controls.Add(pnlBienvenida);
        }

        private void CrearTarjetas()
        {
            Panel tarjetaPacientes =
                CrearTarjeta(
                    "PACIENTES",
                    "Registro, modificación e historial",
                    Color.FromArgb(52, 152, 219),
                    25);

            Panel tarjetaMedicos =
                CrearTarjeta(
                    "MÉDICOS",
                    "Especialidades y horarios",
                    Color.FromArgb(46, 204, 113),
                    225);

            Panel tarjetaCitas =
                CrearTarjeta(
                    "CITAS MÉDICAS",
                    "Programación y seguimiento",
                    Color.FromArgb(241, 196, 15),
                    425);

            Panel tarjetaReportes =
                CrearTarjeta(
                    "REPORTES",
                    "Consultas e impresión",
                    Color.FromArgb(155, 89, 182),
                    625);

            this.Controls.Add(tarjetaPacientes);
            this.Controls.Add(tarjetaMedicos);
            this.Controls.Add(tarjetaCitas);
            this.Controls.Add(tarjetaReportes);
        }

        private Panel CrearTarjeta(
            string titulo,
            string descripcion,
            Color color,
            int posicionX)
        {
            Panel tarjeta = new Panel();

            tarjeta.Location =
                new Point(posicionX, 130);

            tarjeta.Size =
                new Size(185, 120);

            tarjeta.BackColor =
                Color.White;

            Panel barraSuperior =
                new Panel();

            barraSuperior.Dock =
                DockStyle.Top;

            barraSuperior.Height = 8;
            barraSuperior.BackColor = color;

            Label lblTitulo =
                new Label();

            lblTitulo.Text = titulo;

            lblTitulo.Location =
                new Point(15, 25);

            lblTitulo.Size =
                new Size(155, 25);

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(13, 54, 93);

            Label lblDescripcion =
                new Label();

            lblDescripcion.Text =
                descripcion;

            lblDescripcion.Location =
                new Point(15, 58);

            lblDescripcion.Size =
                new Size(155, 45);

            lblDescripcion.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Regular);

            lblDescripcion.ForeColor =
                Color.DimGray;

            tarjeta.Controls.Add(barraSuperior);
            tarjeta.Controls.Add(lblTitulo);
            tarjeta.Controls.Add(lblDescripcion);

            return tarjeta;
        }

        private void CrearAccesosRapidos()
        {
            Panel pnlAccesos =
                new Panel();

            pnlAccesos.Location =
                new Point(25, 275);

            pnlAccesos.Size =
                new Size(790, 190);

            pnlAccesos.BackColor =
                Color.White;

            Label lblTitulo =
                new Label();

            lblTitulo.Text =
                "ACCESOS RÁPIDOS";

            lblTitulo.Location =
                new Point(25, 20);

            lblTitulo.Size =
                new Size(300, 25);

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    12,
                    FontStyle.Bold);

            lblTitulo.ForeColor =
                Color.FromArgb(13, 54, 93);

            Button btnPacientes =
                CrearBoton(
                    "GESTIONAR PACIENTES",
                    25,
                    Color.FromArgb(52, 152, 219));

            Button btnMedicos =
                CrearBoton(
                    "GESTIONAR MÉDICOS",
                    215,
                    Color.FromArgb(46, 150, 90));

            Button btnCitas =
                CrearBoton(
                    "GESTIONAR CITAS",
                    405,
                    Color.FromArgb(218, 165, 32));

            Button btnReportes =
                CrearBoton(
                    "VER REPORTES",
                    595,
                    Color.FromArgb(125, 91, 207));

            btnPacientes.Click += btnPacientes_Click;
            btnMedicos.Click += btnMedicos_Click;
            btnCitas.Click += btnCitas_Click;
            btnReportes.Click += btnReportes_Click;

            Cl_EstiloBotones.AplicarVarios(
    btnPacientes,
    btnMedicos,
    btnCitas,
    btnReportes);

            pnlAccesos.Controls.Add(lblTitulo);
            pnlAccesos.Controls.Add(btnPacientes);
            pnlAccesos.Controls.Add(btnMedicos);
            pnlAccesos.Controls.Add(btnCitas);
            pnlAccesos.Controls.Add(btnReportes);



            this.Controls.Add(pnlAccesos);
        }

        private Button CrearBoton(
            string texto,
            int posicionX,
            Color color)
        {
            Button boton = new Button();

            boton.Text = texto;

            boton.Location =
                new Point(posicionX, 75);

            boton.Size =
                new Size(165, 55);

            boton.BackColor = color;
            boton.ForeColor = Color.White;

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize = 0;

            boton.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold);

            boton.TextAlign =
                ContentAlignment.MiddleCenter;

            boton.Cursor =
                Cursors.Hand;

            return boton;
        }

        private void CrearFechaHora()
        {
            Label lblFechaHora =
                new Label();

            lblFechaHora.Name =
                "lblFechaHora";

            lblFechaHora.Location =
                new Point(25, 490);

            lblFechaHora.Size =
                new Size(790, 25);

            lblFechaHora.TextAlign =
                ContentAlignment.MiddleRight;

            lblFechaHora.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Regular);

            lblFechaHora.ForeColor =
                Color.DimGray;

            this.Controls.Add(lblFechaHora);

            reloj = new System.Windows.Forms.Timer();
            reloj.Interval = 1000;
            reloj.Tick += Reloj_Tick;
            reloj.Start();

            ActualizarFechaHora();
        }

        private void Reloj_Tick(
            object sender,
            EventArgs e)
        {
            ActualizarFechaHora();
        }

        private void ActualizarFechaHora()
        {
            Control[] controles =
                this.Controls.Find(
                    "lblFechaHora",
                    true);

            if (controles.Length > 0)
            {
                controles[0].Text =
                    DateTime.Now.ToString(
                        "dddd, dd 'de' MMMM 'de' yyyy - HH:mm:ss");
            }
        }

        private void btnPacientes_Click(
            object sender,
            EventArgs e)
        {
            AbrirModulo(
                new frmPacientes(),
                "GESTIÓN DE PACIENTES");
        }

        private void btnMedicos_Click(
            object sender,
            EventArgs e)
        {
            AbrirModulo(
                new frmMedicos(),
                "GESTIÓN DE MÉDICOS");
        }

        private void btnCitas_Click(
            object sender,
            EventArgs e)
        {
            AbrirModulo(
                new frmCitas(),
                "GESTIÓN DE CITAS MÉDICAS");
        }

        private void btnReportes_Click(
            object sender,
            EventArgs e)
        {
            AbrirModulo(
                new frmReportes(),
                "REPORTES DE CITAS MÉDICAS");
        }

        private void AbrirModulo(
            Form formulario,
            string titulo)
        {
            frmPrincipal principal =
                Application.OpenForms["frmPrincipal"]
                as frmPrincipal;

            if (principal != null)
            {
                principal.MostrarFormulario(
                    formulario,
                    titulo);
            }
        }
    }
}