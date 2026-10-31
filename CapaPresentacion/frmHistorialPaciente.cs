using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmHistorialPaciente : Form
    {
        private readonly Cl_CitaLogica objCitaLogica =
             new Cl_CitaLogica();

        private int idPacienteSeleccionado = 0;
        private string nombrePacienteSeleccionado =
            string.Empty;

        // Constructor necesario para abrir el diseñador.
        public frmHistorialPaciente()
        {
            InitializeComponent();
            Cl_EstiloBotones.AplicarVarios(
        btnConsultar,
        btnLimpiar,
        btnCerrar);

        }

        // Constructor utilizado desde frmPacientes.
        public frmHistorialPaciente(
            int idPaciente,
            string nombrePaciente) : this()
        {
            idPacienteSeleccionado = idPaciente;
            nombrePacienteSeleccionado = nombrePaciente;
        }

        private void frmHistorialPaciente_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                ConfigurarFechas();
                CargarPacienteSeleccionado();
                CargarEstados();
                ConsultarHistorial(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar el historial",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarFechas()
        {
            dtpDesde.Format =
                DateTimePickerFormat.Short;

            dtpHasta.Format =
                DateTimePickerFormat.Short;

            dtpDesde.Value =
                new DateTime(
                    DateTime.Today.Year,
                    1,
                    1);

            dtpHasta.Value =
                DateTime.Today.AddYears(1);
        }

        private void CargarPacienteSeleccionado()
        {
            DataTable tablaPaciente =
                new DataTable();

            tablaPaciente.Columns.Add(
                "id_paciente",
                typeof(int));

            tablaPaciente.Columns.Add(
                "paciente",
                typeof(string));

            tablaPaciente.Rows.Add(
                idPacienteSeleccionado,
                nombrePacienteSeleccionado);

            cboPaciente.DataSource = null;
            cboPaciente.DataSource = tablaPaciente;
            cboPaciente.DisplayMember = "paciente";
            cboPaciente.ValueMember = "id_paciente";
            cboPaciente.SelectedIndex = 0;

            cboPaciente.Enabled = false;
        }

        private void CargarEstados()
        {
            DataTable tablaEstados =
                objCitaLogica.ListarEstadosCita();

            DataRow filaTodos =
                tablaEstados.NewRow();

            filaTodos["id_estado"] = 0;
            filaTodos["nombre"] = "Todos";

            tablaEstados.Rows.InsertAt(
                filaTodos,
                0);

            cboEstado.DataSource = null;
            cboEstado.DataSource = tablaEstados;
            cboEstado.DisplayMember = "nombre";
            cboEstado.ValueMember = "id_estado";
            cboEstado.SelectedIndex = 0;
        }

        private void ConsultarHistorial(
            bool mostrarMensaje)
        {
            if (idPacienteSeleccionado <= 0)
            {
                MessageBox.Show(
                    "No se recibió un paciente válido.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dtpDesde.Value.Date >
                dtpHasta.Value.Date)
            {
                MessageBox.Show(
                    "La fecha desde no puede ser mayor que la fecha hasta.",
                    "Fechas incorrectas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int? idEstado = null;

            if (cboEstado.SelectedValue != null)
            {
                int estadoSeleccionado =
                    Convert.ToInt32(
                        cboEstado.SelectedValue);

                if (estadoSeleccionado > 0)
                {
                    idEstado = estadoSeleccionado;
                }
            }

            DataTable tabla =
                objCitaLogica.HistorialPaciente(
                    idPacienteSeleccionado,
                    dtpDesde.Value.Date,
                    dtpHasta.Value.Date,
                    idEstado);

            dgvHistorial.DataSource = tabla;

            ConfigurarGrid();

            if (mostrarMensaje &&
                tabla.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron citas para el paciente con los filtros seleccionados.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ConfigurarGrid()
        {
            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.MultiSelect = false;

            dgvHistorial.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHistorial.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            OcultarColumna("id_cita");
            OcultarColumna("id_paciente");
            OcultarColumna("id_medico");
            OcultarColumna("id_estado");

            CambiarTitulo("fecha_cita", "Fecha");
            CambiarTitulo("hora_inicio", "Hora inicio");
            CambiarTitulo("hora_fin", "Hora fin");
            CambiarTitulo("medico", "Médico");
            CambiarTitulo("especialidad", "Especialidad");
            CambiarTitulo("motivo", "Motivo");
            CambiarTitulo("observaciones", "Observaciones");
            CambiarTitulo("estado", "Estado");

            dgvHistorial.ClearSelection();
        }

        private void OcultarColumna(
            string nombreColumna)
        {
            if (dgvHistorial.Columns.Contains(
                nombreColumna))
            {
                dgvHistorial
                    .Columns[nombreColumna]
                    .Visible = false;
            }
        }

        private void CambiarTitulo(
            string nombreColumna,
            string titulo)
        {
            if (dgvHistorial.Columns.Contains(
                nombreColumna))
            {
                dgvHistorial
                    .Columns[nombreColumna]
                    .HeaderText = titulo;
            }
        }

        private void btnConsultar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                ConsultarHistorial(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al consultar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            dtpDesde.Value =
                new DateTime(
                    DateTime.Today.Year,
                    1,
                    1);

            dtpHasta.Value =
                DateTime.Today.AddYears(1);

            cboEstado.SelectedIndex = 0;

            ConsultarHistorial(false);
        }

        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            frmPrincipal principal =
                Application.OpenForms["frmPrincipal"]
                as frmPrincipal;

            if (principal != null)
            {
                principal.MostrarFormulario(
                    new frmPacientes(),
                    "GESTIÓN DE PACIENTES");
            }
        }
    }
}
