using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReportes : Form
    {
        private readonly Cl_ReporteLogica objReporteLogica =
            new Cl_ReporteLogica();

        private readonly Cl_MedicoLogica objMedicoLogica =
            new Cl_MedicoLogica();

        private readonly Cl_PacienteLogica objPacienteLogica =
            new Cl_PacienteLogica();

        private readonly Cl_CitaLogica objCitaLogica =
            new Cl_CitaLogica();

        private readonly PrintDocument documentoImpresion =
            new PrintDocument();

        private DataTable tablaReporte =
            new DataTable();

        private int filaImpresion = 0;

        public frmReportes()
        {
            InitializeComponent();

            documentoImpresion.PrintPage +=
                DocumentoImpresion_PrintPage;


            Cl_EstiloBotones.AplicarVarios(
        btnGenerar,
        btnLimpiar,
        btnImprimir,
        btnCerrar);

            documentoImpresion.PrintPage +=
                DocumentoImpresion_PrintPage;
        }

        private void frmReportes_Load(
            object sender,
            EventArgs e)
        {
            ConfigurarFechas();
            CargarEstados();
            CargarMedicos();
            CargarPacientes();
            ConfigurarGrid();
        }

        private void ConfigurarFechas()
        {
            dtpDesde.Format =
                DateTimePickerFormat.Short;

            dtpHasta.Format =
                DateTimePickerFormat.Short;

            DateTime fechaActual =
                DateTime.Today;

            dtpDesde.Value =
                new DateTime(
                    fechaActual.Year,
                    fechaActual.Month,
                    1);

            dtpHasta.Value =
                new DateTime(
                    fechaActual.Year,
                    fechaActual.Month,
                    DateTime.DaysInMonth(
                        fechaActual.Year,
                        fechaActual.Month));
        }

        private void CargarEstados()
        {
            try
            {
                DataTable origen =
                    objCitaLogica.ListarEstadosCita();

                DataTable tabla =
                    new DataTable();

                tabla.Columns.Add(
                    "id_estado",
                    typeof(int));

                tabla.Columns.Add(
                    "nombre",
                    typeof(string));

                tabla.Rows.Add(0, "Todos");

                foreach (DataRow fila in origen.Rows)
                {
                    tabla.Rows.Add(
                        Convert.ToInt32(
                            fila["id_estado"]),

                        Convert.ToString(
                            fila["nombre"]));
                }

                cboEstado.DataSource = null;
                cboEstado.DataSource = tabla;
                cboEstado.DisplayMember = "nombre";
                cboEstado.ValueMember = "id_estado";
                cboEstado.SelectedValue = 0;
                cboEstado.DropDownStyle =
                    ComboBoxStyle.DropDownList;
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

        private void CargarMedicos()
        {
            try
            {
                DataTable origen =
                    objMedicoLogica.ListarMedicosActivos();

                DataTable tabla = new DataTable();

                tabla.Columns.Add(
                    "id_medico",
                    typeof(int));

                tabla.Columns.Add(
                    "nombre_mostrar",
                    typeof(string));

                tabla.Rows.Add(0, "Todos");

                foreach (DataRow fila in origen.Rows)
                {
                    int idMedico =
                        Convert.ToInt32(
                            fila["id_medico"]);

                    string nombre = string.Empty;

                    if (origen.Columns.Contains(
                        "medico_especialidad"))
                    {
                        nombre =
                            Convert.ToString(
                                fila["medico_especialidad"]);
                    }
                    else if (origen.Columns.Contains("medico"))
                    {
                        nombre =
                            Convert.ToString(
                                fila["medico"]);

                        if (origen.Columns.Contains(
                            "especialidad"))
                        {
                            nombre += " - " +
                                Convert.ToString(
                                    fila["especialidad"]);
                        }
                    }
                    else
                    {
                        string nombres =
                            origen.Columns.Contains("nombres")
                            ? Convert.ToString(fila["nombres"])
                            : string.Empty;

                        string apellidos =
                            origen.Columns.Contains("apellidos")
                            ? Convert.ToString(fila["apellidos"])
                            : string.Empty;

                        nombre =
                            (nombres + " " + apellidos).Trim();
                    }

                    tabla.Rows.Add(
                        idMedico,
                        nombre);
                }

                cboMedico.DataSource = null;
                cboMedico.DisplayMember = "nombre_mostrar";
                cboMedico.ValueMember = "id_medico";
                cboMedico.DataSource = tabla;
                cboMedico.SelectedValue = 0;

                cboMedico.DropDownStyle =
                    ComboBoxStyle.DropDownList;
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

        private void CargarPacientes()
        {
            try
            {
                DataTable origen =
                    objPacienteLogica.ListarPacientesActivos();

                DataTable tabla = new DataTable();

                tabla.Columns.Add(
                    "id_paciente",
                    typeof(int));

                tabla.Columns.Add(
                    "nombre_mostrar",
                    typeof(string));

                tabla.Rows.Add(0, "Todos");

                foreach (DataRow fila in origen.Rows)
                {
                    int idPaciente =
                        Convert.ToInt32(
                            fila["id_paciente"]);

                    string nombre = string.Empty;

                    if (origen.Columns.Contains("paciente"))
                    {
                        nombre =
                            Convert.ToString(
                                fila["paciente"]);
                    }
                    else
                    {
                        string nombres =
                            origen.Columns.Contains("nombres")
                            ? Convert.ToString(fila["nombres"])
                            : string.Empty;

                        string apellidos =
                            origen.Columns.Contains("apellidos")
                            ? Convert.ToString(fila["apellidos"])
                            : string.Empty;

                        nombre =
                            (nombres + " " + apellidos).Trim();
                    }

                    tabla.Rows.Add(
                        idPaciente,
                        nombre);
                }

                cboPaciente.DataSource = null;
                cboPaciente.DisplayMember = "nombre_mostrar";
                cboPaciente.ValueMember = "id_paciente";
                cboPaciente.DataSource = tabla;
                cboPaciente.SelectedValue = 0;

                cboPaciente.DropDownStyle =
                    ComboBoxStyle.DropDownList;
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

        private int? ObtenerValorCombo(
            ComboBox combo)
        {
            if (combo.SelectedValue == null)
            {
                return null;
            }

            int valor =
                Convert.ToInt32(
                    combo.SelectedValue);

            if (valor <= 0)
            {
                return null;
            }

            return valor;
        }

        private void GenerarReporte()
        {
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

            int? idMedico =
                ObtenerValorCombo(cboMedico);

            int? idPaciente =
                ObtenerValorCombo(cboPaciente);

            int? idEstado =
                ObtenerValorCombo(cboEstado);

            tablaReporte =
                objReporteLogica.GenerarReporte(
                    dtpDesde.Value.Date,
                    dtpHasta.Value.Date,
                    idMedico,
                    idPaciente,
                    idEstado);

            dgvReportes.DataSource =
                tablaReporte;

            ConfigurarGrid();

            if (tablaReporte.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron citas con los filtros seleccionados.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ConfigurarGrid()
        {
            dgvReportes.AutoGenerateColumns = true;

            dgvReportes.ReadOnly = true;
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.AllowUserToResizeRows = false;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.MultiSelect = false;
            dgvReportes.AutoGenerateColumns = true;

            dgvReportes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvReportes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            OcultarColumna("id_cita");
            OcultarColumna("id_paciente");
            OcultarColumna("id_medico");
            OcultarColumna("id_estado");

            CambiarTitulo("fecha_cita", "Fecha");
            CambiarTitulo("hora_inicio", "Hora inicio");
            CambiarTitulo("hora_fin", "Hora fin");
            CambiarTitulo("cedula_paciente", "Cédula");
            CambiarTitulo("paciente", "Paciente");
            CambiarTitulo("medico", "Médico");
            CambiarTitulo("especialidad", "Especialidad");
            CambiarTitulo("motivo", "Motivo");
            CambiarTitulo("estado", "Estado");

            dgvReportes.ClearSelection();
        }

        private void OcultarColumna(
            string nombreColumna)
        {
            if (dgvReportes.Columns.Contains(
                nombreColumna))
            {
                dgvReportes
                    .Columns[nombreColumna]
                    .Visible = false;
            }
        }

        private void CambiarTitulo(
            string nombreColumna,
            string titulo)
        {
            if (dgvReportes.Columns.Contains(
                nombreColumna))
            {
                dgvReportes
                    .Columns[nombreColumna]
                    .HeaderText = titulo;
            }
        }

        private void btnGenerarReporte_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                GenerarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al generar el reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            ConfigurarFechas();

            if (cboEstado.Items.Count > 0)
            {
                cboEstado.SelectedValue = 0;
            }

            if (cboMedico.Items.Count > 0)
            {
                cboMedico.SelectedValue = 0;
            }

            if (cboPaciente.Items.Count > 0)
            {
                cboPaciente.SelectedValue = 0;
            }

            tablaReporte = new DataTable();

            dgvReportes.DataSource = null;
            dgvReportes.Rows.Clear();
            dgvReportes.ClearSelection();
        }

        private void btnImprimir_Click(
            object sender,
            EventArgs e)
        {
            if (dgvReportes.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Primero debe generar un reporte.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                filaImpresion = 0;

                PrintPreviewDialog vistaPrevia =
                    new PrintPreviewDialog();

                vistaPrevia.Document =
                    documentoImpresion;

                vistaPrevia.Width = 1000;
                vistaPrevia.Height = 700;

                vistaPrevia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al imprimir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DocumentoImpresion_PrintPage(
            object sender,
            PrintPageEventArgs e)
        {
            Font fuenteTitulo =
                new Font(
                    "Arial",
                    16,
                    FontStyle.Bold);

            Font fuenteEncabezado =
                new Font(
                    "Arial",
                    8,
                    FontStyle.Bold);

            Font fuenteTexto =
                new Font(
                    "Arial",
                    8,
                    FontStyle.Regular);

            float posicionX =
                e.MarginBounds.Left;

            float posicionY =
                e.MarginBounds.Top;

            e.Graphics.DrawString(
                "REPORTE DE CITAS MÉDICAS",
                fuenteTitulo,
                Brushes.Black,
                posicionX,
                posicionY);

            posicionY += 35;

            string filtros =
                "Desde: " +
                dtpDesde.Value.ToString("dd/MM/yyyy") +
                "   Hasta: " +
                dtpHasta.Value.ToString("dd/MM/yyyy");

            e.Graphics.DrawString(
                filtros,
                fuenteTexto,
                Brushes.Black,
                posicionX,
                posicionY);

            posicionY += 25;

            int columnasVisibles = 0;

            foreach (DataGridViewColumn columna
                in dgvReportes.Columns)
            {
                if (columna.Visible)
                {
                    columnasVisibles++;
                }
            }

            if (columnasVisibles == 0)
            {
                e.HasMorePages = false;
                return;
            }

            float anchoColumna =
                e.MarginBounds.Width /
                columnasVisibles;

            float altoFila = 30;

            float columnaX = posicionX;

            foreach (DataGridViewColumn columna
                in dgvReportes.Columns)
            {
                if (!columna.Visible)
                {
                    continue;
                }

                RectangleF rectangulo =
                    new RectangleF(
                        columnaX,
                        posicionY,
                        anchoColumna,
                        altoFila);

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    rectangulo.X,
                    rectangulo.Y,
                    rectangulo.Width,
                    rectangulo.Height);

                e.Graphics.DrawString(
                    columna.HeaderText,
                    fuenteEncabezado,
                    Brushes.Black,
                    rectangulo);

                columnaX += anchoColumna;
            }

            posicionY += altoFila;

            while (filaImpresion <
                dgvReportes.Rows.Count)
            {
                if (dgvReportes
                    .Rows[filaImpresion]
                    .IsNewRow)
                {
                    filaImpresion++;
                    continue;
                }

                columnaX = posicionX;

                foreach (DataGridViewColumn columna
                    in dgvReportes.Columns)
                {
                    if (!columna.Visible)
                    {
                        continue;
                    }

                    RectangleF rectangulo =
                        new RectangleF(
                            columnaX,
                            posicionY,
                            anchoColumna,
                            altoFila);

                    e.Graphics.DrawRectangle(
                        Pens.Black,
                        rectangulo.X,
                        rectangulo.Y,
                        rectangulo.Width,
                        rectangulo.Height);

                    string valor =
                        Convert.ToString(
                            dgvReportes
                                .Rows[filaImpresion]
                                .Cells[columna.Index]
                                .Value);

                    e.Graphics.DrawString(
                        valor,
                        fuenteTexto,
                        Brushes.Black,
                        rectangulo);

                    columnaX += anchoColumna;
                }

                posicionY += altoFila;
                filaImpresion++;

                if (posicionY + altoFila >
                    e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
            filaImpresion = 0;
        }

        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}