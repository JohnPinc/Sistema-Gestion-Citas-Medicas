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
    public partial class frmHorariosMedico : Form
    {
        private readonly Cl_HorarioLogica objHorarioLogica =
            new Cl_HorarioLogica();

        private readonly Cl_MedicoLogica objMedicoLogica =
            new Cl_MedicoLogica();

        private int idHorarioSeleccionado = 0;
        private int idMedicoInicial = 0;
        private bool cargandoMedicos = false;

        public frmHorariosMedico()
        {
            InitializeComponent();

            Cl_EstiloBotones.AplicarVarios(
        btnNuevo,
        btnGuardar,
        btnModificar,
        btnEliminar,
        btnCancelar,
        btnSalir);
        }

        public frmHorariosMedico(int idMedico) : this()
        {
            idMedicoInicial = idMedico;
        }

        private void frmHorariosMedico_Load(object sender, EventArgs e)
        {
            ConfigurarHoras();
            CargarDiasSemana();
            CargarMedicos();
            LimpiarHorario();
            EstadoInicial();
            CargarHorarios();
        }

        private void ConfigurarHoras()
        {
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.ShowUpDown = true;

            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.CustomFormat = "HH:mm";
            dtpHoraFin.ShowUpDown = true;
        }

        private void CargarDiasSemana()
        {
            cboDiaSemana.Items.Clear();

            cboDiaSemana.Items.Add("Lunes");
            cboDiaSemana.Items.Add("Martes");
            cboDiaSemana.Items.Add("Miércoles");
            cboDiaSemana.Items.Add("Jueves");
            cboDiaSemana.Items.Add("Viernes");
            cboDiaSemana.Items.Add("Sábado");
            cboDiaSemana.Items.Add("Domingo");

            cboDiaSemana.SelectedIndex = -1;
        }

        private void CargarMedicos()
        {
            try
            {
                cargandoMedicos = true;

                DataTable tabla =
                    objMedicoLogica.ListarMedicosActivos();

                cboMedico.DataSource = null;
                cboMedico.DataSource = tabla;
                cboMedico.DisplayMember = "medico_especialidad";
                cboMedico.ValueMember = "id_medico";
                cboMedico.SelectedIndex = -1;

                if (idMedicoInicial > 0)
                {
                    cboMedico.SelectedValue = idMedicoInicial;
                }

                if (cboMedico.SelectedIndex < 0 &&
                    tabla.Rows.Count > 0)
                {
                    cboMedico.SelectedIndex = 0;
                }
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
                cargandoMedicos = false;
            }
        }

        private void CargarHorarios()
        {
            try
            {
                if (cboMedico.SelectedValue == null)
                {
                    dgvHorariosMedico.DataSource = null;
                    return;
                }

                int idMedico =
                    Convert.ToInt32(cboMedico.SelectedValue);

                dgvHorariosMedico.DataSource =
                    objHorarioLogica.ListarHorariosPorMedico(idMedico);

                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar horarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            dgvHorariosMedico.ReadOnly = true;
            dgvHorariosMedico.AllowUserToAddRows = false;
            dgvHorariosMedico.AllowUserToDeleteRows = false;
            dgvHorariosMedico.MultiSelect = false;

            dgvHorariosMedico.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHorariosMedico.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvHorariosMedico.Columns.Contains("id_horario"))
            {
                dgvHorariosMedico.Columns["id_horario"].Visible = false;
            }

            if (dgvHorariosMedico.Columns.Contains("id_medico"))
            {
                dgvHorariosMedico.Columns["id_medico"].Visible = false;
            }

            if (dgvHorariosMedico.Columns.Contains("dia_semana"))
            {
                dgvHorariosMedico.Columns["dia_semana"].Visible = false;
            }

            if (dgvHorariosMedico.Columns.Contains("estado"))
            {
                dgvHorariosMedico.Columns["estado"].Visible = false;
            }

            if (dgvHorariosMedico.Columns.Contains("nombre_dia"))
            {
                dgvHorariosMedico.Columns["nombre_dia"].HeaderText =
                    "Día";
            }

            if (dgvHorariosMedico.Columns.Contains("hora_inicio"))
            {
                dgvHorariosMedico.Columns["hora_inicio"].HeaderText =
                    "Hora inicio";
            }

            if (dgvHorariosMedico.Columns.Contains("hora_fin"))
            {
                dgvHorariosMedico.Columns["hora_fin"].HeaderText =
                    "Hora fin";
            }

            if (dgvHorariosMedico.Columns.Contains("nombre_estado"))
            {
                dgvHorariosMedico.Columns["nombre_estado"].HeaderText =
                    "Estado";
            }

            dgvHorariosMedico.ClearSelection();
        }

        private void LimpiarHorario()
        {
            idHorarioSeleccionado = 0;

            cboDiaSemana.SelectedIndex = -1;

            dtpHoraInicio.Value =
                DateTime.Today.AddHours(8);

            dtpHoraFin.Value =
                DateTime.Today.AddHours(9);

            chkEstado.Checked = true;

            dgvHorariosMedico.ClearSelection();
        }

        private void HabilitarControles(bool habilitar)
        {
            cboDiaSemana.Enabled = habilitar;
            dtpHoraInicio.Enabled = habilitar;
            dtpHoraFin.Enabled = habilitar;
            chkEstado.Enabled = habilitar;
        }

        private void EstadoInicial()
        {
            HabilitarControles(false);

            cboMedico.Enabled = true;

            btnNuevo.Enabled =
                cboMedico.SelectedValue != null;

            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private Cl_HorarioMedico ObtenerHorario()
        {
            Cl_HorarioMedico horario =
                new Cl_HorarioMedico();

            horario.IdHorario =
                idHorarioSeleccionado;

            if (cboMedico.SelectedValue != null)
            {
                horario.IdMedico =
                    Convert.ToInt32(cboMedico.SelectedValue);
            }

            horario.DiaSemana =
                cboDiaSemana.SelectedIndex + 1;

            horario.HoraInicio =
                dtpHoraInicio.Value.TimeOfDay;

            horario.HoraFin =
                dtpHoraFin.Value.TimeOfDay;

            horario.Estado =
                chkEstado.Checked;

            return horario;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (cboMedico.SelectedValue == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un médico.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            LimpiarHorario();
            HabilitarControles(true);

            cboMedico.Enabled = false;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;

            cboDiaSemana.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_HorarioMedico horario =
                    ObtenerHorario();

                objHorarioLogica.RegistrarHorario(horario);

                MessageBox.Show(
                    "Horario registrado correctamente.",
                    "Registro correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarHorarios();
                LimpiarHorario();
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
                if (idHorarioSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un horario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Cl_HorarioMedico horario =
                    ObtenerHorario();

                objHorarioLogica.ModificarHorario(horario);

                MessageBox.Show(
                    "Horario modificado correctamente.",
                    "Modificación correcta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarHorarios();
                LimpiarHorario();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idHorarioSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un horario.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea dar de baja el horario seleccionado?",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    objHorarioLogica.DarBajaHorario(
                        idHorarioSeleccionado);

                    MessageBox.Show(
                        "Horario dado de baja correctamente.",
                        "Proceso correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarHorarios();
                    LimpiarHorario();
                    EstadoInicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo dar de baja",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarHorario();
            EstadoInicial();
        }

        private void cboMedico_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cargandoMedicos)
            {
                return;
            }

            LimpiarHorario();
            EstadoInicial();
            CargarHorarios();
        }

        private void dgvHorariosMedico_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila =
                dgvHorariosMedico.Rows[e.RowIndex];

            idHorarioSeleccionado =
                Convert.ToInt32(
                    fila.Cells["id_horario"].Value);

            int diaSemana =
                Convert.ToInt32(
                    fila.Cells["dia_semana"].Value);

            cboDiaSemana.SelectedIndex =
                diaSemana - 1;

            dtpHoraInicio.Value =
                ConvertirHora(
                    fila.Cells["hora_inicio"].Value);

            dtpHoraFin.Value =
                ConvertirHora(
                    fila.Cells["hora_fin"].Value);

            chkEstado.Checked =
                Convert.ToBoolean(
                    fila.Cells["estado"].Value);

            HabilitarControles(true);

            cboMedico.Enabled = false;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal principal =
    Application.OpenForms["frmPrincipal"] as frmPrincipal;

            if (principal != null)
            {
                principal.MostrarFormulario(
                    new frmMedicos(),
                    "GESTIÓN DE MÉDICOS");
            }
        }
    }
}