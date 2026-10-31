using System.Drawing.Drawing2D;
namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        private Form formularioActivo = null;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "INICIO";
            AbrirFormulario(new frmInicio());
          
            AplicarEstiloBotones();

            lblTitulo.Text = "INICIO";

            AbrirFormulario(
                new frmInicio());
        }
        private void AbrirFormulario(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(formulario);
            pnlContenedor.Tag = formulario;

            formulario.BringToFront();
            formulario.Show();
        }
        public void MostrarFormulario(Form formulario, string titulo)
        {
            lblTitulo.Text = titulo;
            AbrirFormulario(formulario);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "GESTIÓN DE PACIENTES";
            AbrirFormulario(new frmPacientes());
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "GESTIÓN DE MÉDICOS";
            AbrirFormulario(new frmMedicos());
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "GESTIÓN DE ESPECIALIDADES";
            AbrirFormulario(new frmEspecialidades());
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "HORARIOS DE ATENCIÓN";
            AbrirFormulario(new frmHorariosMedico());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "GESTIÓN DE CITAS MÉDICAS";
            AbrirFormulario(new frmCitas());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "REPORTES DE CITAS MÉDICAS";
            AbrirFormulario(new frmReportes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
       "¿Desea salir del sistema?",
       "Confirmar salida",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "INICIO";

            AbrirFormulario(
                new frmInicio());
        }
        private void RedondearBoton(Button boton, int radio)
        {
            GraphicsPath ruta = new GraphicsPath();

            ruta.StartFigure();

            ruta.AddArc(
                0,
                0,
                radio,
                radio,
                180,
                90);

            ruta.AddArc(
                boton.Width - radio,
                0,
                radio,
                radio,
                270,
                90);

            ruta.AddArc(
                boton.Width - radio,
                boton.Height - radio,
                radio,
                radio,
                0,
                90);

            ruta.AddArc(
                0,
                boton.Height - radio,
                radio,
                radio,
                90,
                90);

            ruta.CloseFigure();

            boton.Region = new Region(ruta);
        }
        private void AplicarEstiloBotones()
        {
            Button[] botones =
            {
        btnInicio,
        btnPacientes,
        btnMedicos,
        btnEspecialidades,
        btnHorarios,
        btnCitas,
        btnReportes,
        btnSalir
    };

            foreach (Button boton in botones)
            {
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 0;

                boton.Size = new Size(210, 50);

                boton.Font = new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold);

                boton.TextAlign =
                    ContentAlignment.MiddleCenter;

                boton.Cursor =
                    Cursors.Hand;

                RedondearBoton(boton, 18);

                ConfigurarColorHover(boton);
            }
            btnSalir.FlatAppearance.MouseOverBackColor =
             Color.FromArgb(220, 70, 70);

            btnSalir.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(170, 50, 50);

        }
        private void ConfigurarColorHover(Button boton)
        {
            boton.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(55, 115, 165);

            boton.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(40, 90, 135);
        }
    }
}