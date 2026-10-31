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
    public partial class frmMedicos : Form
    {
        private readonly Cl_MedicoLogica objMedicoLogica =
            new Cl_MedicoLogica();

        private readonly Cl_EspecialidadLogica objEspecialidadLogica =
            new Cl_EspecialidadLogica();

        private int idMedicoSeleccionado = 0;

        public frmMedicos()
        {
            InitializeComponent();
            Cl_EstiloBotones.AplicarVarios(
        btnNuevo,
        btnGuardar,
        btnModificar,
        btnEliminar,
        btnCancelar,
        btnHorarios,
        btnBuscar);
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            CargarMedicos();
            LimpiarControles();
            EstadoInicial();
        }

        private void CargarEspecialidades()
        {
            try
            {
                DataTable tabla =
                    objEspecialidadLogica.ListarEspecialidadesActivas();

                cboEspecialidad.DataSource = tabla;
                cboEspecialidad.DisplayMember = "nombre";
                cboEspecialidad.ValueMember = "id_especialidad";
                cboEspecialidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar especialidades",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarMedicos()
        {
            try
            {
                dgvMedicos.DataSource =
                    objMedicoLogica.ListarMedicos();

                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al cargar médicos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGrid()
        {
            dgvMedicos.ReadOnly = true;
            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AllowUserToDeleteRows = false;
            dgvMedicos.MultiSelect = false;

            dgvMedicos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvMedicos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvMedicos.Columns.Contains("id_medico"))
                dgvMedicos.Columns["id_medico"].Visible = false;

            if (dgvMedicos.Columns.Contains("id_especialidad"))
                dgvMedicos.Columns["id_especialidad"].Visible = false;

            if (dgvMedicos.Columns.Contains("nombres"))
                dgvMedicos.Columns["nombres"].Visible = false;

            if (dgvMedicos.Columns.Contains("apellidos"))
                dgvMedicos.Columns["apellidos"].Visible = false;

            if (dgvMedicos.Columns.Contains("estado"))
                dgvMedicos.Columns["estado"].Visible = false;

            if (dgvMedicos.Columns.Contains("cedula"))
                dgvMedicos.Columns["cedula"].HeaderText = "Cédula";

            if (dgvMedicos.Columns.Contains("numero_colegiatura"))
                dgvMedicos.Columns["numero_colegiatura"].HeaderText =
                    "Colegiatura";

            if (dgvMedicos.Columns.Contains("medico"))
                dgvMedicos.Columns["medico"].HeaderText = "Médico";

            if (dgvMedicos.Columns.Contains("especialidad"))
                dgvMedicos.Columns["especialidad"].HeaderText =
                    "Especialidad";

            if (dgvMedicos.Columns.Contains("telefono"))
                dgvMedicos.Columns["telefono"].HeaderText = "Teléfono";

            if (dgvMedicos.Columns.Contains("correo"))
                dgvMedicos.Columns["correo"].HeaderText = "Correo";

            if (dgvMedicos.Columns.Contains("nombre_estado"))
                dgvMedicos.Columns["nombre_estado"].HeaderText = "Estado";

            dgvMedicos.ClearSelection();
        }

        private void LimpiarControles()
        {
            idMedicoSeleccionado = 0;

            cboEspecialidad.SelectedIndex = -1;
            txtCedula.Clear();
            txtColegiatura.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtBuscar.Clear();

            chkEstado.Checked = true;

            dgvMedicos.ClearSelection();
        }

        private void HabilitarControles(bool habilitar)
        {
            cboEspecialidad.Enabled = habilitar;
            txtCedula.Enabled = habilitar;
            txtColegiatura.Enabled = habilitar;
            txtNombres.Enabled = habilitar;
            txtApellidos.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            txtCorreo.Enabled = habilitar;
            chkEstado.Enabled = habilitar;
        }

        private void EstadoInicial()
        {
            HabilitarControles(false);

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            btnHorarios.Enabled = false;
        }

        private Cl_Medico ObtenerMedico()
        {
            Cl_Medico medico = new Cl_Medico();

            medico.IdMedico = idMedicoSeleccionado;

            if (cboEspecialidad.SelectedValue != null)
            {
                medico.IdEspecialidad =
                    Convert.ToInt32(cboEspecialidad.SelectedValue);
            }

            medico.Cedula = txtCedula.Text.Trim();
            medico.NumeroColegiatura = txtColegiatura.Text.Trim();
            medico.Nombres = txtNombres.Text.Trim();
            medico.Apellidos = txtApellidos.Text.Trim();
            medico.Telefono = txtTelefono.Text.Trim();
            medico.Correo = txtCorreo.Text.Trim();
            medico.Estado = chkEstado.Checked;

            return medico;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles(true);

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnHorarios.Enabled = false;

            cboEspecialidad.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_Medico medico = ObtenerMedico();

                objMedicoLogica.RegistrarMedico(medico);

                MessageBox.Show(
                    "Médico registrado correctamente.",
                    "Registro correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarMedicos();
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
                if (idMedicoSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un médico.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Cl_Medico medico = ObtenerMedico();

                objMedicoLogica.ModificarMedico(medico);

                MessageBox.Show(
                    "Médico modificado correctamente.",
                    "Modificación correcta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarMedicos();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMedicoSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un médico.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea dar de baja al médico seleccionado?",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    objMedicoLogica.DarBajaMedico(
                        idMedicoSeleccionado);

                    MessageBox.Show(
                        "Médico dado de baja correctamente.",
                        "Proceso correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarMedicos();
                    LimpiarControles();
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
            LimpiarControles();
            EstadoInicial();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMedicos.DataSource =
                    objMedicoLogica.BuscarMedicos(
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

        private void dgvMedicos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila =
                dgvMedicos.Rows[e.RowIndex];

            idMedicoSeleccionado =
                Convert.ToInt32(
                    fila.Cells["id_medico"].Value);

            cboEspecialidad.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["id_especialidad"].Value);

            txtCedula.Text =
                Convert.ToString(
                    fila.Cells["cedula"].Value);

            txtColegiatura.Text =
                Convert.ToString(
                    fila.Cells["numero_colegiatura"].Value);

            txtNombres.Text =
                Convert.ToString(
                    fila.Cells["nombres"].Value);

            txtApellidos.Text =
                Convert.ToString(
                    fila.Cells["apellidos"].Value);

            txtTelefono.Text =
                Convert.ToString(
                    fila.Cells["telefono"].Value);

            txtCorreo.Text =
                Convert.ToString(
                    fila.Cells["correo"].Value);

            chkEstado.Checked =
                Convert.ToBoolean(
                    fila.Cells["estado"].Value);

            HabilitarControles(true);

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            btnHorarios.Enabled = true;
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            if (idMedicoSeleccionado <= 0)
            {
                MessageBox.Show(
                    "Seleccione un médico para configurar sus horarios.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            frmPrincipal principal =
                Application.OpenForms["frmPrincipal"] as frmPrincipal;

            if (principal != null)
            {
                principal.MostrarFormulario(
                    new frmHorariosMedico(idMedicoSeleccionado),
                    "HORARIOS DE ATENCIÓN");
            }
        }
    }
}