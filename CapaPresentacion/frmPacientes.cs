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
    public partial class frmPacientes : Form
    {
        private readonly Cl_PacienteLogica objLogica =
            new Cl_PacienteLogica();

        private int idPacienteSeleccionado = 0;

        public frmPacientes()
        {
            InitializeComponent();
            Cl_EstiloBotones.AplicarVarios(
        btnNuevo,
        btnGuardar,
        btnModificar,
        btnEliminar,
        btnCancelar,
        btnHistorial,
        btnBuscar);
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            CargarGeneros();
            CargarPacientes();
            LimpiarControles();
            EstadoInicial();
        }

        private void CargarGeneros()
        {
            cboGenero.Items.Clear();

            cboGenero.Items.Add("Masculino");
            cboGenero.Items.Add("Femenino");
            cboGenero.Items.Add("Otro");

            cboGenero.SelectedIndex = -1;
        }

        private void CargarPacientes()
        {
            try
            {
                DataTable tabla = objLogica.ListarPacientes();

                dgvPacientes.DataSource = tabla;

                ConfigurarGrid();
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

        private void ConfigurarGrid()
        {
            dgvPacientes.ReadOnly = true;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.MultiSelect = false;

            dgvPacientes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPacientes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvPacientes.Columns.Contains("id_paciente"))
            {
                dgvPacientes.Columns["id_paciente"].Visible = false;
            }

            if (dgvPacientes.Columns.Contains("estado"))
            {
                dgvPacientes.Columns["estado"].Visible = false;
            }

            if (dgvPacientes.Columns.Contains("cedula"))
            {
                dgvPacientes.Columns["cedula"].HeaderText = "Cédula";
            }

            if (dgvPacientes.Columns.Contains("nombres"))
            {
                dgvPacientes.Columns["nombres"].HeaderText = "Nombres";
            }

            if (dgvPacientes.Columns.Contains("apellidos"))
            {
                dgvPacientes.Columns["apellidos"].HeaderText = "Apellidos";
            }

            if (dgvPacientes.Columns.Contains("fecha_nacimiento"))
            {
                dgvPacientes.Columns["fecha_nacimiento"].HeaderText =
                    "Fecha de nacimiento";
            }

            if (dgvPacientes.Columns.Contains("genero"))
            {
                dgvPacientes.Columns["genero"].HeaderText = "Género";
            }

            if (dgvPacientes.Columns.Contains("telefono"))
            {
                dgvPacientes.Columns["telefono"].HeaderText = "Teléfono";
            }

            if (dgvPacientes.Columns.Contains("correo"))
            {
                dgvPacientes.Columns["correo"].HeaderText = "Correo";
            }

            if (dgvPacientes.Columns.Contains("direccion"))
            {
                dgvPacientes.Columns["direccion"].HeaderText = "Dirección";
            }

            if (dgvPacientes.Columns.Contains("nombre_estado"))
            {
                dgvPacientes.Columns["nombre_estado"].HeaderText = "Estado";
            }

            dgvPacientes.ClearSelection();
        }

        private void LimpiarControles()
        {
            idPacienteSeleccionado = 0;

            txtCedula.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtBuscar.Clear();

            dtpFechaNacimiento.Value = DateTime.Today;
            cboGenero.SelectedIndex = -1;
            chkEstado.Checked = true;

            dgvPacientes.ClearSelection();
        }

        private void HabilitarControles(bool habilitar)
        {
            txtCedula.Enabled = habilitar;
            txtNombres.Enabled = habilitar;
            txtApellidos.Enabled = habilitar;
            dtpFechaNacimiento.Enabled = habilitar;
            cboGenero.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            txtCorreo.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;
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
            btnHistorial.Enabled = false;
        }

        private Cl_Paciente ObtenerPaciente()
        {
            Cl_Paciente paciente = new Cl_Paciente();

            paciente.IdPaciente = idPacienteSeleccionado;
            paciente.Cedula = txtCedula.Text.Trim();
            paciente.Nombres = txtNombres.Text.Trim();
            paciente.Apellidos = txtApellidos.Text.Trim();
            paciente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            paciente.Genero = cboGenero.Text;
            paciente.Telefono = txtTelefono.Text.Trim();
            paciente.Correo = txtCorreo.Text.Trim();
            paciente.Direccion = txtDireccion.Text.Trim();
            paciente.Estado = chkEstado.Checked;

            return paciente;
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
            btnHistorial.Enabled = false;

            txtCedula.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_Paciente paciente = ObtenerPaciente();

                objLogica.RegistrarPaciente(paciente);

                MessageBox.Show(
                    "Paciente registrado correctamente.",
                    "Registro correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPacientes();
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
                if (idPacienteSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un paciente.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Cl_Paciente paciente = ObtenerPaciente();

                objLogica.ModificarPaciente(paciente);

                MessageBox.Show(
                    "Paciente modificado correctamente.",
                    "Modificación correcta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarPacientes();
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
                if (idPacienteSeleccionado <= 0)
                {
                    MessageBox.Show(
                        "Seleccione un paciente.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea dar de baja al paciente seleccionado?",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    objLogica.DarBajaPaciente(
                        idPacienteSeleccionado);

                    MessageBox.Show(
                        "Paciente dado de baja correctamente.",
                        "Proceso correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarPacientes();
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
                dgvPacientes.DataSource =
                    objLogica.BuscarPacientes(
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

        private void dgvPacientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila =
                dgvPacientes.Rows[e.RowIndex];

            idPacienteSeleccionado =
                Convert.ToInt32(
                    fila.Cells["id_paciente"].Value);

            txtCedula.Text =
                Convert.ToString(
                    fila.Cells["cedula"].Value);

            txtNombres.Text =
                Convert.ToString(
                    fila.Cells["nombres"].Value);

            txtApellidos.Text =
                Convert.ToString(
                    fila.Cells["apellidos"].Value);

            dtpFechaNacimiento.Value =
                Convert.ToDateTime(
                    fila.Cells["fecha_nacimiento"].Value);

            cboGenero.Text =
                Convert.ToString(
                    fila.Cells["genero"].Value);

            txtTelefono.Text =
                Convert.ToString(
                    fila.Cells["telefono"].Value);

            txtCorreo.Text =
                Convert.ToString(
                    fila.Cells["correo"].Value);

            txtDireccion.Text =
                Convert.ToString(
                    fila.Cells["direccion"].Value);

            chkEstado.Checked =
                Convert.ToBoolean(
                    fila.Cells["estado"].Value);

            HabilitarControles(true);

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
            btnHistorial.Enabled = true;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (idPacienteSeleccionado <= 0)
            {
                MessageBox.Show(
                    "Seleccione un paciente para consultar su historial.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string nombreCompleto =
                txtNombres.Text.Trim() + " " +
                txtApellidos.Text.Trim();

            frmHistorialPaciente formulario =
                new frmHistorialPaciente(
                    idPacienteSeleccionado,
                    nombreCompleto);

            frmPrincipal principal =
                Application.OpenForms["frmPrincipal"]
                as frmPrincipal;

            if (principal != null)
            {
                principal.MostrarFormulario(
                    formulario,
                    "HISTORIAL DE CITAS DEL PACIENTE");
            }
        }

    }
}