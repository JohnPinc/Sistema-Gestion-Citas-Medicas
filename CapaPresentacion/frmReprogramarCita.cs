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
    public partial class frmReprogramarCita : Form
    {
        private readonly Cl_CitaLogica objCitaLogica =
             new Cl_CitaLogica();

        private int idCitaSeleccionada = 0;
        private int idPacienteSeleccionado = 0;
        private int idMedicoSeleccionado = 0;

        private string nombrePaciente = string.Empty;
        private string nombreMedico = string.Empty;
        private string estadoActual = string.Empty;

        private DateTime fechaActual;
        private TimeSpan horaInicioActual;
        private TimeSpan horaFinActual;

        private bool disponibilidadConfirmada = false;

        // Constructor necesario para abrir el diseñador.
        public frmReprogramarCita()
        {
            InitializeComponent();

            Cl_EstiloBotones.AplicarVarios(
        btnVerificarDisponibilidad,
        btnConfirmar,
        btnCancelar);
        }

        // Constructor utilizado desde frmCitas.
        public frmReprogramarCita(
        int idCita,
        int idPaciente,
            int idMedico,
         string paciente,
            string medico,
         DateTime fecha,
         TimeSpan horaInicio,
          TimeSpan horaFin,
          string estado) : this()
        {
            idCitaSeleccionada = idCita;
            idPacienteSeleccionado = idPaciente;
            idMedicoSeleccionado = idMedico;

            nombrePaciente = paciente;
            nombreMedico = medico;
            fechaActual = fecha.Date;
            horaInicioActual = horaInicio;
            horaFinActual = horaFin;
            estadoActual = estado;
        }

        private void frmReprogramarCita_Load(
            object sender,
            EventArgs e)
        {
            ConfigurarControles();
            MostrarDatosCita();
            PrepararNuevaFecha();
        }

        private void ConfigurarControles()
        {
            dtpNuevaFecha.Format =
                DateTimePickerFormat.Short;

            dtpNuevaFecha.MinDate =
                DateTime.Today;

            dtpNuevaHoraInicio.Format =
                DateTimePickerFormat.Custom;

            dtpNuevaHoraInicio.CustomFormat =
                "HH:mm";

            dtpNuevaHoraInicio.ShowUpDown = true;

            dtpNuevaHoraFin.Format =
                DateTimePickerFormat.Custom;

            dtpNuevaHoraFin.CustomFormat =
                "HH:mm";

            dtpNuevaHoraFin.ShowUpDown = true;

            btnConfirmar.Enabled = false;

            lblDisponibilidad.Text =
                "Sin verificar";

            lblDisponibilidad.ForeColor =
                Color.Gray;
        }

        private void MostrarDatosCita()
        {
            lblIdCita.Text =
                idCitaSeleccionada.ToString();

            lblPaciente.Text =
                nombrePaciente;

            lblMedico.Text =
                nombreMedico;

            lblFechaActual.Text =
                fechaActual.ToString("dd/MM/yyyy");

            lblHorarioActual.Text =
                horaInicioActual.ToString(@"hh\:mm")
                + " - "
                + horaFinActual.ToString(@"hh\:mm");

            lblEstadoActual.Text =
                estadoActual;
        }

        private void PrepararNuevaFecha()
        {
            if (fechaActual < DateTime.Today)
            {
                dtpNuevaFecha.Value =
                    DateTime.Today;
            }
            else
            {
                dtpNuevaFecha.Value =
                    fechaActual;
            }

            dtpNuevaHoraInicio.Value =
                DateTime.Today.Add(horaInicioActual);

            dtpNuevaHoraFin.Value =
                DateTime.Today.Add(horaFinActual);
        }

        private void ReiniciarDisponibilidad()
        {
            disponibilidadConfirmada = false;

            btnConfirmar.Enabled = false;

            lblDisponibilidad.Text =
                "Sin verificar";

            lblDisponibilidad.ForeColor =
                Color.Gray;
        }

        private void btnVerificarDisponibilidad_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DataTable resultado =
                    objCitaLogica.ValidarDisponibilidad(
                        idPacienteSeleccionado,
                        idMedicoSeleccionado,
                        dtpNuevaFecha.Value.Date,
                        dtpNuevaHoraInicio.Value.TimeOfDay,
                        dtpNuevaHoraFin.Value.TimeOfDay,
                        idCitaSeleccionada);

                if (resultado.Rows.Count == 0)
                {
                    throw new Exception(
                        "No se pudo verificar la disponibilidad.");
                }

                bool disponible =
                    Convert.ToBoolean(
                        resultado.Rows[0]["disponible"]);

                string mensaje =
                    Convert.ToString(
                        resultado.Rows[0]["mensaje"]);

                lblDisponibilidad.Text = mensaje;

                if (disponible)
                {
                    disponibilidadConfirmada = true;
                    btnConfirmar.Enabled = true;

                    lblDisponibilidad.ForeColor =
                        Color.SeaGreen;
                }
                else
                {
                    disponibilidadConfirmada = false;
                    btnConfirmar.Enabled = false;

                    lblDisponibilidad.ForeColor =
                        Color.Firebrick;
                }
            }
            catch (Exception ex)
            {
                disponibilidadConfirmada = false;
                btnConfirmar.Enabled = false;

                lblDisponibilidad.Text =
                    ex.Message;

                lblDisponibilidad.ForeColor =
                    Color.Firebrick;

                MessageBox.Show(
                    ex.Message,
                    "Disponibilidad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!disponibilidadConfirmada)
                {
                    MessageBox.Show(
                        "Primero debe verificar la disponibilidad.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta =
                    MessageBox.Show(
                        "¿Desea confirmar la reprogramación de la cita?",
                        "Confirmar reprogramación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                {
                    return;
                }

                int nuevaCita =
                    objCitaLogica.ReprogramarCita(
                        idCitaSeleccionada,
                        dtpNuevaFecha.Value.Date,
                        dtpNuevaHoraInicio.Value.TimeOfDay,
                        dtpNuevaHoraFin.Value.TimeOfDay,
                        string.Empty);

                MessageBox.Show(
                    "Cita reprogramada correctamente. Nueva cita: "
                    + nuevaCita,
                    "Proceso correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                RegresarACitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo reprogramar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            RegresarACitas();
        }

        private void RegresarACitas()
        {
            frmPrincipal principal =
                Application.OpenForms["frmPrincipal"]
                as frmPrincipal;

            if (principal != null)
            {
                principal.MostrarFormulario(
                    new frmCitas(),
                    "GESTIÓN DE CITAS MÉDICAS");
            }
        }

        private void dtpNuevaFecha_ValueChanged(
            object sender,
            EventArgs e)
        {
            ReiniciarDisponibilidad();
        }

        private void dtpNuevaHoraInicio_ValueChanged(
            object sender,
            EventArgs e)
        {
            ReiniciarDisponibilidad();
        }

        private void dtpNuevaHoraFin_ValueChanged(
            object sender,
            EventArgs e)
        {
            ReiniciarDisponibilidad();
        }
    }
}