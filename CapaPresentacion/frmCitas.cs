using CapaEntidades;
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
    public partial class frmCitas : Form
    {
        private readonly Cl_CitaLogica objCitaLogica =
            new Cl_CitaLogica();

        private readonly Cl_PacienteLogica objPacienteLogica =
            new Cl_PacienteLogica();

        private readonly Cl_MedicoLogica objMedicoLogica =
            new Cl_MedicoLogica();

        private int idCitaSeleccionada = 0;
        private bool cargandoCombos = false;

        public frmCitas()
        {
            InitializeComponent();

            Cl_EstiloBotones.AplicarVarios(
        btnNuevo,
        btnGuardar,
        btnModificar,
        btnCancelarCita,
        btnReprogramar,
        btnAtendida,
        btnNoAsistida,
        btnBuscar);
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            ConfigurarFechasHoras();
            CargarPacientes();
            CargarMedicos();
            CargarEstados();
            CargarCitas();
            LimpiarControles();
            EstadoInicial();
        }

        private void ConfigurarFechasHoras()
        {
            dtpFechaCita.Format = DateTimePickerFormat.Short;
            dtpFechaCita.MinDate = DateTime.Today;

            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.ShowUpDown = true;

            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.CustomFormat = "HH:mm";
            dtpHoraFin.ShowUpDown = true;

            txtEspecialidad.ReadOnly = true;
        }

        private void CargarPacientes()
        {
            try
            {
                DataTable tabla =
                    objPacienteLogica.ListarPacientesActivos();

                cboPaciente.DataSource = null;
                cboPaciente.DataSource = tabla;
                cboPaciente.DisplayMember = "paciente";
                cboPaciente.ValueMember = "id_paciente";
                cboPaciente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar pacientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarMedicos()
        {
            try
            {
                cargandoCombos = true;

                DataTable tabla =
                    objMedicoLogica.ListarMedicosActivos();

                cboMedico.DataSource = null;
                cboMedico.DataSource = tabla;
                cboMedico.DisplayMember = "medico_especialidad";
                cboMedico.ValueMember = "id_medico";
                cboMedico.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar médicos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                cargandoCombos = false;
            }
        }

        private void CargarEstados()
        {
            try
            {
                DataTable tabla =
                    objCitaLogica.ListarEstadosCita();

                cboEstado.DataSource = null;
                cboEstado.DataSource = tabla;
                cboEstado.DisplayMember = "nombre";
                cboEstado.ValueMember = "id_estado";
                cboEstado.SelectedValue = 1;
                cboEstado.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar estados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarCitas()
        {
            try
            {
                dgvCitas.DataSource =
                    objCitaLogica.ListarCitas();

                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar citas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            dgvCitas.ReadOnly = true;
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.MultiSelect = false;

            dgvCitas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvCitas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            OcultarColumna("id_cita");
            OcultarColumna("id_paciente");
            OcultarColumna("id_medico");
            OcultarColumna("id_estado");
            OcultarColumna("cedula_paciente");
            OcultarColumna("id_cita_origen");
            OcultarColumna("observaciones");
            OcultarColumna("hora_fin");

            CambiarTituloColumna("fecha_cita", "Fecha");
            CambiarTituloColumna("hora_inicio", "Hora");
            CambiarTituloColumna("paciente", "Paciente");
            CambiarTituloColumna("medico", "Médico");
            CambiarTituloColumna("especialidad", "Especialidad");
            CambiarTituloColumna("motivo", "Motivo");
            CambiarTituloColumna("estado", "Estado");

            dgvCitas.ClearSelection();
        }

        private void OcultarColumna(string nombre)
        {
            if (dgvCitas.Columns.Contains(nombre))
            {
                dgvCitas.Columns[nombre].Visible = false;
            }
        }

        private void CambiarTituloColumna(
            string nombre,
            string titulo)
        {
            if (dgvCitas.Columns.Contains(nombre))
            {
                dgvCitas.Columns[nombre].HeaderText = titulo;
            }
        }

        private void LimpiarControles()
        {
            idCitaSeleccionada = 0;

            cboPaciente.SelectedIndex = -1;
            cboMedico.SelectedIndex = -1;

            txtEspecialidad.Clear();
            txtMotivo.Clear();
            txtObservaciones.Clear();
            txtBuscar.Clear();

            dtpFechaCita.Value = DateTime.Today;

            dtpHoraInicio.Value =
                DateTime.Today.AddHours(8);

            dtpHoraFin.Value =
                DateTime.Today.AddHours(9);

            if (cboEstado.DataSource != null)
            {
                cboEstado.SelectedValue = 1;
            }

            dgvCitas.ClearSelection();
        }

        private void HabilitarControles(bool habilitar)
        {
            cboPaciente.Enabled = habilitar;
            cboMedico.Enabled = habilitar;
            dtpFechaCita.Enabled = habilitar;
            dtpHoraInicio.Enabled = habilitar;
            dtpHoraFin.Enabled = habilitar;
            txtMotivo.Enabled = habilitar;
            txtObservaciones.Enabled = habilitar;

            txtEspecialidad.Enabled = false;
            cboEstado.Enabled = false;
        }

        private void EstadoInicial()
        {
            HabilitarControles(false);

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelarCita.Enabled = false;
            btnReprogramar.Enabled = false;
            btnAtendida.Enabled = false;
            btnNoAsistida.Enabled = false;
        }

        private Cl_Cita ObtenerCita()
        {
            Cl_Cita cita = new Cl_Cita();

            cita.IdCita = idCitaSeleccionada;

            if (cboPaciente.SelectedValue != null)
            {
                cita.IdPaciente =
                    Convert.ToInt32(cboPaciente.SelectedValue);
            }

            if (cboMedico.SelectedValue != null)
            {
                cita.IdMedico =
                    Convert.ToInt32(cboMedico.SelectedValue);
            }

            if (cboEstado.SelectedValue != null)
            {
                cita.IdEstado =
                    Convert.ToInt32(cboEstado.SelectedValue);
            }

            cita.FechaCita =
                dtpFechaCita.Value.Date;

            cita.HoraInicio =
                dtpHoraInicio.Value.TimeOfDay;

            cita.HoraFin =
                dtpHoraFin.Value.TimeOfDay;

            cita.Motivo =
                txtMotivo.Text.Trim();

            cita.Observaciones =
                txtObservaciones.Text.Trim();

            return cita;
        }

        private DateTime ConvertirHora(object valor)
        {
            if (valor is TimeSpan hora)
            {
                return DateTime.Today.Add(hora);
            }

            TimeSpan horaConvertida =
                TimeSpan.Parse(Convert.ToString(valor));

            return DateTime.Today.Add(horaConvertida);
        }

        private void MostrarEspecialidadSeleccionada()
        {
            txtEspecialidad.Clear();

            if (cboMedico.SelectedItem is DataRowView fila)
            {
                if (fila.Row.Table.Columns.Contains("especialidad"))
                {
                    txtEspecialidad.Text =
                        Convert.ToString(fila["especialidad"]);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(true);

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelarCita.Enabled = false;
            btnReprogramar.Enabled = false;
            btnAtendida.Enabled = false;
            btnNoAsistida.Enabled = false;

            cboPaciente.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_Cita cita = ObtenerCita();

                int idCita =
                    objCitaLogica.RegistrarCita(cita);

                MessageBox.Show(
                    "Cita registrada correctamente. ID: " + idCita,
                    "Registro correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarCitas();
                LimpiarControles();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo registrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCitaSeleccionada <= 0)
                {
                    MessageBox.Show(
                        "Seleccione una cita.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Cl_Cita cita = ObtenerCita();

                objCitaLogica.ModificarCita(cita);

                MessageBox.Show(
                    "Cita modificada correctamente.",
                    "Modificación correcta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarCitas();
                LimpiarControles();
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo modificar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarCita_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (idCitaSeleccionada <= 0)
                {
                    MessageBox.Show(
                        "Seleccione una cita.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea cancelar la cita seleccionada?",
                    "Confirmar cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    objCitaLogica.CancelarCita(
                        idCitaSeleccionada,
                        txtObservaciones.Text.Trim());

                    MessageBox.Show(
                        "Cita cancelada correctamente.",
                        "Proceso correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCitas();
                    LimpiarControles();
                    EstadoInicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo cancelar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnAtendida_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCitaSeleccionada <= 0)
                {
                    MessageBox.Show(
                        "Seleccione una cita.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea marcar la cita como atendida?",
                    "Confirmar estado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    objCitaLogica.MarcarAtendida(
                        idCitaSeleccionada,
                        txtObservaciones.Text.Trim());

                    MessageBox.Show(
                        "Cita marcada como atendida.",
                        "Proceso correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCitas();
                    LimpiarControles();
                    EstadoInicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo cambiar el estado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnNoAsistida_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (idCitaSeleccionada <= 0)
                {
                    MessageBox.Show(
                        "Seleccione una cita.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea marcar la cita como no asistida?",
                    "Confirmar estado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    objCitaLogica.MarcarNoAsistida(
                        idCitaSeleccionada,
                        txtObservaciones.Text.Trim());

                    MessageBox.Show(
                        "Cita marcada como no asistida.",
                        "Proceso correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCitas();
                    LimpiarControles();
                    EstadoInicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo cambiar el estado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnReprogramar_Click(
            object sender,
            EventArgs e)
        {
            if (idCitaSeleccionada <= 0)
            {
                MessageBox.Show(
                    "Seleccione una cita para reprogramar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idPaciente =
                Convert.ToInt32(cboPaciente.SelectedValue);

            int idMedico =
                Convert.ToInt32(cboMedico.SelectedValue);

            frmReprogramarCita formulario =
                new frmReprogramarCita(
                    idCitaSeleccionada,
                    idPaciente,
                    idMedico,
                    cboPaciente.Text,
                    cboMedico.Text,
                    dtpFechaCita.Value.Date,
                    dtpHoraInicio.Value.TimeOfDay,
                    dtpHoraFin.Value.TimeOfDay,
                    cboEstado.Text);

            frmPrincipal principal =
                Application.OpenForms["frmPrincipal"]
                as frmPrincipal;

            if (principal != null)
            {
                principal.MostrarFormulario(
                    formulario,
                    "REPROGRAMAR CITA");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCitas.DataSource =
                    objCitaLogica.BuscarCitas(
                        txtBuscar.Text.Trim());

                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al buscar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cboMedico_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cargandoCombos)
            {
                return;
            }

            MostrarEspecialidadSeleccionada();
        }

        private void dgvCitas_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila =
                dgvCitas.Rows[e.RowIndex];

            idCitaSeleccionada =
                Convert.ToInt32(
                    fila.Cells["id_cita"].Value);

            cboPaciente.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_paciente"].Value);

            cboMedico.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_medico"].Value);

            int idEstado =
                Convert.ToInt32(
                    fila.Cells["id_estado"].Value);

            cboEstado.SelectedValue = idEstado;

            dtpFechaCita.Value =
                Convert.ToDateTime(
                    fila.Cells["fecha_cita"].Value);

            dtpHoraInicio.Value =
                ConvertirHora(
                    fila.Cells["hora_inicio"].Value);

            dtpHoraFin.Value =
                ConvertirHora(
                    fila.Cells["hora_fin"].Value);

            txtMotivo.Text =
                Convert.ToString(
                    fila.Cells["motivo"].Value);

            txtObservaciones.Text =
                Convert.ToString(
                    fila.Cells["observaciones"].Value);

            MostrarEspecialidadSeleccionada();

            bool citaProgramada = idEstado == 1;

            HabilitarControles(citaProgramada);

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = citaProgramada;
            btnCancelarCita.Enabled = citaProgramada;
            btnReprogramar.Enabled = citaProgramada;
            btnAtendida.Enabled = citaProgramada;
            btnNoAsistida.Enabled = citaProgramada;
        }
    }
}