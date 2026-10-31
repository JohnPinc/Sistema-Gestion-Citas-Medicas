namespace CapaPresentacion
{
    partial class frmReprogramarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpCitaActual = new GroupBox();
            lblEstadoActual = new TextBox();
            lblHorarioActual = new TextBox();
            lblFechaActual = new TextBox();
            lblPaciente = new Label();
            lblIdCita = new Label();
            label8 = new Label();
            lblMedico = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            grpNuevaFecha = new GroupBox();
            btnVerificarDisponibilidad = new Button();
            lblTextoDisponibilidad = new Label();
            dtpNuevaHoraFin = new DateTimePicker();
            dtpNuevaHoraInicio = new DateTimePicker();
            dtpNuevaFecha = new DateTimePicker();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            lblDisponibilidad = new Label();
            label16 = new Label();
            grpCitaActual.SuspendLayout();
            grpNuevaFecha.SuspendLayout();
            SuspendLayout();
            // 
            // grpCitaActual
            // 
            grpCitaActual.BackColor = Color.White;
            grpCitaActual.Controls.Add(lblEstadoActual);
            grpCitaActual.Controls.Add(lblHorarioActual);
            grpCitaActual.Controls.Add(lblFechaActual);
            grpCitaActual.Controls.Add(lblPaciente);
            grpCitaActual.Controls.Add(lblIdCita);
            grpCitaActual.Controls.Add(label8);
            grpCitaActual.Controls.Add(lblMedico);
            grpCitaActual.Controls.Add(label6);
            grpCitaActual.Controls.Add(label5);
            grpCitaActual.Controls.Add(label4);
            grpCitaActual.Controls.Add(label3);
            grpCitaActual.Controls.Add(label2);
            grpCitaActual.Controls.Add(label1);
            grpCitaActual.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpCitaActual.ForeColor = Color.MidnightBlue;
            grpCitaActual.Location = new Point(20, 20);
            grpCitaActual.Name = "grpCitaActual";
            grpCitaActual.Size = new Size(380, 360);
            grpCitaActual.TabIndex = 3;
            grpCitaActual.TabStop = false;
            grpCitaActual.Text = "Información de la cita actual";
            // 
            // lblEstadoActual
            // 
            lblEstadoActual.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoActual.Location = new Point(160, 270);
            lblEstadoActual.MaxLength = 100;
            lblEstadoActual.Name = "lblEstadoActual";
            lblEstadoActual.Size = new Size(190, 25);
            lblEstadoActual.TabIndex = 25;
            lblEstadoActual.Text = "Programada";
            // 
            // lblHorarioActual
            // 
            lblHorarioActual.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHorarioActual.Location = new Point(160, 225);
            lblHorarioActual.MaxLength = 100;
            lblHorarioActual.Name = "lblHorarioActual";
            lblHorarioActual.Size = new Size(190, 25);
            lblHorarioActual.TabIndex = 24;
            lblHorarioActual.Text = "--:-- - --:--";
            // 
            // lblFechaActual
            // 
            lblFechaActual.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaActual.Location = new Point(160, 180);
            lblFechaActual.MaxLength = 100;
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(190, 25);
            lblFechaActual.TabIndex = 23;
            lblFechaActual.Text = "--/--/----";
            // 
            // lblPaciente
            // 
            lblPaciente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaciente.ForeColor = Color.Black;
            lblPaciente.Location = new Point(160, 90);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(190, 25);
            lblPaciente.TabIndex = 22;
            lblPaciente.Text = "Sin seleccionar";
            // 
            // lblIdCita
            // 
            lblIdCita.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdCita.ForeColor = Color.Black;
            lblIdCita.Location = new Point(160, 45);
            lblIdCita.Name = "lblIdCita";
            lblIdCita.Size = new Size(190, 25);
            lblIdCita.TabIndex = 21;
            lblIdCita.Text = "0";
            // 
            // label8
            // 
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 45);
            label8.Name = "label8";
            label8.Size = new Size(130, 25);
            label8.TabIndex = 20;
            label8.Text = "ID cita:";
            // 
            // lblMedico
            // 
            lblMedico.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedico.Location = new Point(160, 135);
            lblMedico.MaxLength = 100;
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(190, 25);
            lblMedico.TabIndex = 14;
            lblMedico.Text = "Sin seleccionar";
            // 
            // label6
            // 
            label6.ForeColor = Color.Black;
            label6.Location = new Point(20, 135);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 5;
            label6.Text = "Médico:";
            // 
            // label5
            // 
            label5.ForeColor = Color.Black;
            label5.Location = new Point(400, 73);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 4;
            label5.Text = "Especialidad:";
            // 
            // label4
            // 
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 90);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 3;
            label4.Text = "Paciente:";
            // 
            // label3
            // 
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 270);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 2;
            label3.Text = "Estado actual:";
            // 
            // label2
            // 
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 225);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 1;
            label2.Text = "Horario actual:";
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 180);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(480, 425);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 45);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SeaGreen;
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnConfirmar.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(215, 425);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(245, 45);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "CONFIRMAR REPROGRAMACIÓN";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // grpNuevaFecha
            // 
            grpNuevaFecha.BackColor = Color.White;
            grpNuevaFecha.Controls.Add(btnVerificarDisponibilidad);
            grpNuevaFecha.Controls.Add(lblTextoDisponibilidad);
            grpNuevaFecha.Controls.Add(dtpNuevaHoraFin);
            grpNuevaFecha.Controls.Add(dtpNuevaHoraInicio);
            grpNuevaFecha.Controls.Add(dtpNuevaFecha);
            grpNuevaFecha.Controls.Add(label10);
            grpNuevaFecha.Controls.Add(label12);
            grpNuevaFecha.Controls.Add(label13);
            grpNuevaFecha.Controls.Add(lblDisponibilidad);
            grpNuevaFecha.Controls.Add(label16);
            grpNuevaFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpNuevaFecha.ForeColor = Color.MidnightBlue;
            grpNuevaFecha.Location = new Point(420, 20);
            grpNuevaFecha.Name = "grpNuevaFecha";
            grpNuevaFecha.Size = new Size(400, 360);
            grpNuevaFecha.TabIndex = 26;
            grpNuevaFecha.TabStop = false;
            grpNuevaFecha.Text = "Nueva fecha y hora";
            // 
            // btnVerificarDisponibilidad
            // 
            btnVerificarDisponibilidad.BackColor = Color.SteelBlue;
            btnVerificarDisponibilidad.Cursor = Cursors.Hand;
            btnVerificarDisponibilidad.FlatAppearance.BorderSize = 0;
            btnVerificarDisponibilidad.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnVerificarDisponibilidad.FlatStyle = FlatStyle.Flat;
            btnVerificarDisponibilidad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificarDisponibilidad.ForeColor = Color.White;
            btnVerificarDisponibilidad.Location = new Point(90, 220);
            btnVerificarDisponibilidad.Name = "btnVerificarDisponibilidad";
            btnVerificarDisponibilidad.Size = new Size(230, 42);
            btnVerificarDisponibilidad.TabIndex = 30;
            btnVerificarDisponibilidad.Text = " VERIFICAR DISPONIBILIDAD";
            btnVerificarDisponibilidad.UseVisualStyleBackColor = false;
            btnVerificarDisponibilidad.Click += btnVerificarDisponibilidad_Click;
            // 
            // lblTextoDisponibilidad
            // 
            lblTextoDisponibilidad.ForeColor = Color.Black;
            lblTextoDisponibilidad.Location = new Point(45, 290);
            lblTextoDisponibilidad.Name = "lblTextoDisponibilidad";
            lblTextoDisponibilidad.Size = new Size(120, 28);
            lblTextoDisponibilidad.TabIndex = 29;
            lblTextoDisponibilidad.Text = "Disponibilidad:";
            // 
            // dtpNuevaHoraFin
            // 
            dtpNuevaHoraFin.Format = DateTimePickerFormat.Time;
            dtpNuevaHoraFin.Location = new Point(160, 165);
            dtpNuevaHoraFin.Name = "dtpNuevaHoraFin";
            dtpNuevaHoraFin.ShowUpDown = true;
            dtpNuevaHoraFin.Size = new Size(210, 25);
            dtpNuevaHoraFin.TabIndex = 28;
            dtpNuevaHoraFin.ValueChanged += dtpNuevaHoraFin_ValueChanged;
            // 
            // dtpNuevaHoraInicio
            // 
            dtpNuevaHoraInicio.Format = DateTimePickerFormat.Time;
            dtpNuevaHoraInicio.Location = new Point(160, 110);
            dtpNuevaHoraInicio.Name = "dtpNuevaHoraInicio";
            dtpNuevaHoraInicio.ShowUpDown = true;
            dtpNuevaHoraInicio.Size = new Size(210, 25);
            dtpNuevaHoraInicio.TabIndex = 27;
            dtpNuevaHoraInicio.ValueChanged += dtpNuevaHoraInicio_ValueChanged;
            // 
            // dtpNuevaFecha
            // 
            dtpNuevaFecha.Format = DateTimePickerFormat.Short;
            dtpNuevaFecha.Location = new Point(160, 55);
            dtpNuevaFecha.Name = "dtpNuevaFecha";
            dtpNuevaFecha.Size = new Size(210, 25);
            dtpNuevaFecha.TabIndex = 26;
            dtpNuevaFecha.ValueChanged += dtpNuevaFecha_ValueChanged;
            // 
            // label10
            // 
            label10.ForeColor = Color.Black;
            label10.Location = new Point(25, 55);
            label10.Name = "label10";
            label10.Size = new Size(125, 25);
            label10.TabIndex = 20;
            label10.Text = "Nueva fecha:";
            // 
            // label12
            // 
            label12.ForeColor = Color.Black;
            label12.Location = new Point(400, 73);
            label12.Name = "label12";
            label12.Size = new Size(125, 25);
            label12.TabIndex = 4;
            label12.Text = "Especialidad:";
            // 
            // label13
            // 
            label13.ForeColor = Color.Black;
            label13.Location = new Point(25, 110);
            label13.Name = "label13";
            label13.Size = new Size(125, 28);
            label13.TabIndex = 3;
            label13.Text = "Hora de inicio:";
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisponibilidad.ForeColor = Color.Black;
            lblDisponibilidad.Location = new Point(170, 290);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(180, 28);
            lblDisponibilidad.TabIndex = 2;
            lblDisponibilidad.Text = "Sin verificar";
            // 
            // label16
            // 
            label16.ForeColor = Color.Black;
            label16.Location = new Point(25, 165);
            label16.Name = "label16";
            label16.Size = new Size(141, 28);
            label16.TabIndex = 0;
            label16.Text = "Hora de finalización:";
            // 
            // frmReprogramarCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(840, 540);
            Controls.Add(grpNuevaFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(grpCitaActual);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReprogramarCita";
            Text = "frmReprogramarCita";
            Load += frmReprogramarCita_Load;
            grpCitaActual.ResumeLayout(false);
            grpCitaActual.PerformLayout();
            grpNuevaFecha.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCitaActual;
        private Label label8;
        private TextBox lblMedico;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label lblPaciente;
        private Label lblIdCita;
        private TextBox lblFechaActual;
        private TextBox lblEstadoActual;
        private TextBox lblHorarioActual;
        private GroupBox grpNuevaFecha;
        private DateTimePicker dtpNuevaFecha;
        private TextBox textBox2;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label lblDisponibilidad;
        private Label label15;
        private Label label16;
        private DateTimePicker dtpNuevaHoraFin;
        private DateTimePicker dtpNuevaHoraInicio;
        private Label lblTextoDisponibilidad;
        private Button btnVerificarDisponibilidad;
    }
}