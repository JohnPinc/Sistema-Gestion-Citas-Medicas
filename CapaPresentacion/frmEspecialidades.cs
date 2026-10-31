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
    public partial class frmEspecialidades : Form
    {

         private readonly Cl_EspecialidadLogica objLogica =
            new Cl_EspecialidadLogica();

        private int idEspecialidadSeleccionada = 0;

        public frmEspecialidades()
        {
            InitializeComponent();

            Cl_EstiloBotones.AplicarVarios(
        btnNuevo,
        btnGuardar,
        btnModificar,
        btnEliminar,
        btnCancelar,
        btnBuscar);
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            LimpiarControles();
            EstadoInicial();


        }

        private void CargarEspecialidades()
        {
            try
            {
                DataTable tabla = objLogica.ListarEspecialidades();

                dgvEspecialidades.DataSource = tabla;

                ConfigurarGrid();
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

        private void ConfigurarGrid()
        {
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.MultiSelect = false;
            dgvEspecialidades.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEspecialidades.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvEspecialidades.Columns.Contains("id_especialidad"))
            {
                dgvEspecialidades.Columns["id_especialidad"].Visible = false;
            }

            if (dgvEspecialidades.Columns.Contains("estado"))
            {
                dgvEspecialidades.Columns["estado"].Visible = false;
            }

            if (dgvEspecialidades.Columns.Contains("nombre"))
            {
                dgvEspecialidades.Columns["nombre"].HeaderText =
                    "Especialidad";
            }

            if (dgvEspecialidades.Columns.Contains("descripcion"))
            {
                dgvEspecialidades.Columns["descripcion"].HeaderText =
                    "Descripción";
            }

            if (dgvEspecialidades.Columns.Contains("nombre_estado"))
            {
                dgvEspecialidades.Columns["nombre_estado"].HeaderText =
                    "Estado";
            }

            dgvEspecialidades.ClearSelection();
        }

        private void LimpiarControles()
        {
            idEspecialidadSeleccionada = 0;

            txtNombre.Clear();
            txtDescripcion.Clear();
            txtBuscar.Clear();

            chkEstado.Checked = true;

            dgvEspecialidades.ClearSelection();
        }

        private void HabilitarControles(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtDescripcion.Enabled = habilitar;
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
        }

        private Cl_Especialidad ObtenerEspecialidad()
        {
            Cl_Especialidad especialidad = new Cl_Especialidad();

            especialidad.IdEspecialidad =
                idEspecialidadSeleccionada;

            especialidad.Nombre =
                txtNombre.Text.Trim();

            especialidad.Descripcion =
                txtDescripcion.Text.Trim();

            especialidad.Estado =
                chkEstado.Checked;

            return especialidad;
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

            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_Especialidad especialidad =
                    ObtenerEspecialidad();

                objLogica.RegistrarEspecialidad(especialidad);

                MessageBox.Show(
                    "Especialidad registrada correctamente.",
                    "Registro correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEspecialidades();
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
                if (idEspecialidadSeleccionada <= 0)
                {
                    MessageBox.Show(
                        "Seleccione una especialidad.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Cl_Especialidad especialidad =
                    ObtenerEspecialidad();

                objLogica.ModificarEspecialidad(especialidad);

                MessageBox.Show(
                    "Especialidad modificada correctamente.",
                    "Modificación correcta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEspecialidades();
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
                if (idEspecialidadSeleccionada <= 0)
                {
                    MessageBox.Show(
                        "Seleccione una especialidad.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea dar de baja la especialidad seleccionada?",
                    "Confirmar baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    objLogica.DarBajaEspecialidad(
                        idEspecialidadSeleccionada);

                    MessageBox.Show(
                        "Especialidad dada de baja correctamente.",
                        "Proceso correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarEspecialidades();
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
                dgvEspecialidades.DataSource =
                    objLogica.BuscarEspecialidades(
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

        private void dgvEspecialidades_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila =
                dgvEspecialidades.Rows[e.RowIndex];

            idEspecialidadSeleccionada =
                Convert.ToInt32(
                    fila.Cells["id_especialidad"].Value);

            txtNombre.Text =
                Convert.ToString(
                    fila.Cells["nombre"].Value);

            txtDescripcion.Text =
                Convert.ToString(
                    fila.Cells["descripcion"].Value);

            chkEstado.Checked =
                Convert.ToBoolean(
                    fila.Cells["estado"].Value);

            HabilitarControles(true);

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}

