namespace CapaPresentacion
{
    partial class frmCitas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grpDatosCita = new GroupBox();
            txtObservaciones = new TextBox();
            label12 = new Label();
            cboEstado = new ComboBox();
            label11 = new Label();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            dtpFechaCita = new DateTimePicker();
            cboMedico = new ComboBox();
            label8 = new Label();
            txtMotivo = new TextBox();
            cboPaciente = new ComboBox();
            txtEspecialidad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnNuevo = new Button();
            btnAtendida = new Button();
            btnReprogramar = new Button();
            btnCancelarCita = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            dgvCitas = new DataGridView();
            label10 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label9 = new Label();
            btnNoAsistida = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpDatosCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // grpDatosCita
            // 
            grpDatosCita.BackColor = Color.White;
            grpDatosCita.Controls.Add(txtObservaciones);
            grpDatosCita.Controls.Add(label12);
            grpDatosCita.Controls.Add(cboEstado);
            grpDatosCita.Controls.Add(label11);
            grpDatosCita.Controls.Add(dtpHoraFin);
            grpDatosCita.Controls.Add(dtpHoraInicio);
            grpDatosCita.Controls.Add(dtpFechaCita);
            grpDatosCita.Controls.Add(cboMedico);
            grpDatosCita.Controls.Add(label8);
            grpDatosCita.Controls.Add(txtMotivo);
            grpDatosCita.Controls.Add(cboPaciente);
            grpDatosCita.Controls.Add(txtEspecialidad);
            grpDatosCita.Controls.Add(label7);
            grpDatosCita.Controls.Add(label6);
            grpDatosCita.Controls.Add(label5);
            grpDatosCita.Controls.Add(label4);
            grpDatosCita.Controls.Add(label3);
            grpDatosCita.Controls.Add(label2);
            grpDatosCita.Controls.Add(label1);
            grpDatosCita.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpDatosCita.ForeColor = Color.MidnightBlue;
            grpDatosCita.Location = new Point(20, 20);
            grpDatosCita.Name = "grpDatosCita";
            grpDatosCita.Size = new Size(350, 390);
            grpDatosCita.TabIndex = 3;
            grpDatosCita.TabStop = false;
            grpDatosCita.Text = "Datos de la cita";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(125, 331);
            txtObservaciones.MaxLength = 500;
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(205, 45);
            txtObservaciones.TabIndex = 28;
            // 
            // label12
            // 
            label12.ForeColor = Color.Black;
            label12.Location = new Point(15, 330);
            label12.Name = "label12";
            label12.Size = new Size(105, 27);
            label12.TabIndex = 27;
            label12.Text = "Observaciones:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Programada", "Atendida", "Cancelada", "Reprogramada", "No Asistida" });
            cboEstado.Location = new Point(125, 294);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(205, 25);
            cboEstado.TabIndex = 26;
            // 
            // label11
            // 
            label11.ForeColor = Color.Black;
            label11.Location = new Point(15, 294);
            label11.Name = "label11";
            label11.Size = new Size(105, 27);
            label11.TabIndex = 25;
            label11.Text = "Estado:";
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.Location = new Point(125, 220);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new Size(205, 25);
            dtpHoraFin.TabIndex = 24;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.Format = DateTimePickerFormat.Time;
            dtpHoraInicio.Location = new Point(125, 183);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(205, 25);
            dtpHoraInicio.TabIndex = 23;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Format = DateTimePickerFormat.Short;
            dtpFechaCita.Location = new Point(125, 146);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(205, 25);
            dtpFechaCita.TabIndex = 22;
            // 
            // cboMedico
            // 
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(125, 72);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(205, 25);
            cboMedico.TabIndex = 21;
            cboMedico.SelectedIndexChanged += cboMedico_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.ForeColor = Color.Black;
            label8.Location = new Point(15, 35);
            label8.Name = "label8";
            label8.Size = new Size(105, 27);
            label8.TabIndex = 20;
            label8.Text = "Paciente:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(125, 257);
            txtMotivo.MaxLength = 250;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(205, 25);
            txtMotivo.TabIndex = 19;
            // 
            // cboPaciente
            // 
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(125, 35);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(205, 25);
            cboPaciente.TabIndex = 17;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.BackColor = Color.White;
            txtEspecialidad.Location = new Point(125, 109);
            txtEspecialidad.MaxLength = 30;
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.ReadOnly = true;
            txtEspecialidad.Size = new Size(205, 25);
            txtEspecialidad.TabIndex = 10;
            // 
            // label7
            // 
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 257);
            label7.Name = "label7";
            label7.Size = new Size(105, 27);
            label7.TabIndex = 6;
            label7.Text = "Motivo:";
            // 
            // label6
            // 
            label6.ForeColor = Color.Black;
            label6.Location = new Point(15, 109);
            label6.Name = "label6";
            label6.Size = new Size(105, 27);
            label6.TabIndex = 5;
            label6.Text = "Especialidad:";
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
            label4.Location = new Point(15, 72);
            label4.Name = "label4";
            label4.Size = new Size(105, 27);
            label4.TabIndex = 3;
            label4.Text = "Médico:";
            // 
            // label3
            // 
            label3.ForeColor = Color.Black;
            label3.Location = new Point(15, 220);
            label3.Name = "label3";
            label3.Size = new Size(105, 27);
            label3.TabIndex = 2;
            label3.Text = "Hora fin:";
            // 
            // label2
            // 
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 183);
            label2.Name = "label2";
            label2.Size = new Size(105, 27);
            label2.TabIndex = 1;
            label2.Text = "Hora inicio:";
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 146);
            label1.Name = "label1";
            label1.Size = new Size(105, 27);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.SteelBlue;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(108, 425);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(110, 40);
            btnNuevo.TabIndex = 27;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAtendida
            // 
            btnAtendida.BackColor = Color.SeaGreen;
            btnAtendida.Cursor = Cursors.Hand;
            btnAtendida.FlatAppearance.BorderSize = 0;
            btnAtendida.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            btnAtendida.FlatStyle = FlatStyle.Flat;
            btnAtendida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtendida.ForeColor = Color.White;
            btnAtendida.Location = new Point(275, 475);
            btnAtendida.Name = "btnAtendida";
            btnAtendida.Size = new Size(140, 40);
            btnAtendida.TabIndex = 26;
            btnAtendida.Text = "ATENDIDA";
            btnAtendida.UseVisualStyleBackColor = false;
            btnAtendida.Click += btnAtendida_Click;
            // 
            // btnReprogramar
            // 
            btnReprogramar.BackColor = Color.MediumSlateBlue;
            btnReprogramar.Cursor = Cursors.Hand;
            btnReprogramar.FlatAppearance.BorderSize = 0;
            btnReprogramar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnReprogramar.FlatStyle = FlatStyle.Flat;
            btnReprogramar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReprogramar.ForeColor = Color.White;
            btnReprogramar.Location = new Point(603, 425);
            btnReprogramar.Name = "btnReprogramar";
            btnReprogramar.Size = new Size(130, 40);
            btnReprogramar.TabIndex = 25;
            btnReprogramar.Text = "REPROGRAMAR";
            btnReprogramar.UseVisualStyleBackColor = false;
            btnReprogramar.Click += btnReprogramar_Click;
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.BackColor = Color.IndianRed;
            btnCancelarCita.Cursor = Cursors.Hand;
            btnCancelarCita.FlatAppearance.BorderSize = 0;
            btnCancelarCita.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnCancelarCita.FlatStyle = FlatStyle.Flat;
            btnCancelarCita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarCita.ForeColor = Color.White;
            btnCancelarCita.Location = new Point(468, 425);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Size = new Size(125, 40);
            btnCancelarCita.TabIndex = 24;
            btnCancelarCita.Text = "CANCELAR CITA";
            btnCancelarCita.UseVisualStyleBackColor = false;
            btnCancelarCita.Click += btnCancelarCita_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Goldenrod;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(348, 425);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 40);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SeaGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(228, 425);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 40);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCitas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCitas.EnableHeadersVisualStyles = false;
            dgvCitas.Location = new Point(390, 95);
            dgvCitas.MultiSelect = false;
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersVisible = false;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(430, 315);
            dgvCitas.TabIndex = 32;
            dgvCitas.CellClick += dgvCitas_CellClick;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(390, 60);
            label10.Name = "label10";
            label10.Size = new Size(300, 30);
            label10.TabIndex = 31;
            label10.Text = "LISTADO DE CITAS MÉDICAS";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(700, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 32);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(455, 20);
            txtBuscar.MaxLength = 100;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(235, 23);
            txtBuscar.TabIndex = 29;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(390, 23);
            label9.Name = "label9";
            label9.Size = new Size(65, 27);
            label9.TabIndex = 28;
            label9.Text = "Buscar:";
            // 
            // btnNoAsistida
            // 
            btnNoAsistida.BackColor = Color.DarkOrange;
            btnNoAsistida.Cursor = Cursors.Hand;
            btnNoAsistida.FlatAppearance.BorderSize = 0;
            btnNoAsistida.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            btnNoAsistida.FlatStyle = FlatStyle.Flat;
            btnNoAsistida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNoAsistida.ForeColor = Color.White;
            btnNoAsistida.Location = new Point(425, 475);
            btnNoAsistida.Name = "btnNoAsistida";
            btnNoAsistida.Size = new Size(140, 40);
            btnNoAsistida.TabIndex = 33;
            btnNoAsistida.Text = "NO ASISTIDA";
            btnNoAsistida.UseVisualStyleBackColor = false;
            btnNoAsistida.Click += btnNoAsistida_Click;
            // 
            // frmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 540);
            Controls.Add(btnNoAsistida);
            Controls.Add(dgvCitas);
            Controls.Add(label10);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label9);
            Controls.Add(btnNuevo);
            Controls.Add(btnAtendida);
            Controls.Add(btnReprogramar);
            Controls.Add(btnCancelarCita);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatosCita);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCitas";
            Text = "GESTIÓN DE CITAS MÉDICAS";
            Load += frmCitas_Load;
            grpDatosCita.ResumeLayout(false);
            grpDatosCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatosCita;
        private Label label8;
        private TextBox txtMotivo;
        private ComboBox cboPaciente;
        private TextBox txtEspecialidad;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNuevo;
        private Button btnAtendida;
        private Button btnReprogramar;
        private Button btnCancelarCita;
        private Button btnModificar;
        private Button btnGuardar;
        private DataGridView dgvCitas;
        private Label label10;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label9;
        private ComboBox cboMedico;
        private DateTimePicker dtpHoraFin;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpFechaCita;
        private TextBox txtObservaciones;
        private Label label12;
        private ComboBox cboEstado;
        private Label label11;
        private Button btnNoAsistida;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}