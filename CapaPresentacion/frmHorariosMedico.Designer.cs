namespace CapaPresentacion
{
    partial class frmHorariosMedico
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
            grpDatosHorario = new GroupBox();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            cboDiaSemana = new ComboBox();
            chkEstado = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            dgvHorariosMedico = new DataGridView();
            label10 = new Label();
            lblMedico = new Label();
            cboMedico = new ComboBox();
            btnSalir = new Button();
            grpDatosHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorariosMedico).BeginInit();
            SuspendLayout();
            // 
            // grpDatosHorario
            // 
            grpDatosHorario.BackColor = Color.White;
            grpDatosHorario.Controls.Add(dtpHoraFin);
            grpDatosHorario.Controls.Add(dtpHoraInicio);
            grpDatosHorario.Controls.Add(cboDiaSemana);
            grpDatosHorario.Controls.Add(chkEstado);
            grpDatosHorario.Controls.Add(label6);
            grpDatosHorario.Controls.Add(label5);
            grpDatosHorario.Controls.Add(label4);
            grpDatosHorario.Controls.Add(label1);
            grpDatosHorario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpDatosHorario.ForeColor = Color.MidnightBlue;
            grpDatosHorario.Location = new Point(20, 70);
            grpDatosHorario.Name = "grpDatosHorario";
            grpDatosHorario.Size = new Size(350, 330);
            grpDatosHorario.TabIndex = 3;
            grpDatosHorario.TabStop = false;
            grpDatosHorario.Text = "Datos del horario";
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.Location = new Point(145, 185);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new Size(175, 25);
            dtpHoraFin.TabIndex = 22;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.Format = DateTimePickerFormat.Time;
            dtpHoraInicio.Location = new Point(145, 125);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(175, 25);
            dtpHoraInicio.TabIndex = 21;
            // 
            // cboDiaSemana
            // 
            cboDiaSemana.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDiaSemana.FormattingEnabled = true;
            cboDiaSemana.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            cboDiaSemana.Location = new Point(145, 65);
            cboDiaSemana.Name = "cboDiaSemana";
            cboDiaSemana.Size = new Size(175, 25);
            cboDiaSemana.TabIndex = 17;
            // 
            // chkEstado
            // 
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.ForeColor = Color.Black;
            chkEstado.Location = new Point(145, 245);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(160, 25);
            chkEstado.TabIndex = 16;
            chkEstado.Text = "Horario activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.ForeColor = Color.Black;
            label6.Location = new Point(20, 128);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Hora de inicio:";
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
            label4.Location = new Point(20, 68);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 3;
            label4.Text = "Día de la semana:";
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 185);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Hora de finalización:";
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
            btnNuevo.Location = new Point(85, 427);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 25;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(605, 427);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(475, 427);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "DAR DE BAJA";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnModificar.Location = new Point(345, 427);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 40);
            btnModificar.TabIndex = 22;
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
            btnGuardar.Location = new Point(215, 427);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvHorariosMedico
            // 
            dgvHorariosMedico.AllowUserToAddRows = false;
            dgvHorariosMedico.AllowUserToDeleteRows = false;
            dgvHorariosMedico.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvHorariosMedico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHorariosMedico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHorariosMedico.BackgroundColor = Color.White;
            dgvHorariosMedico.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHorariosMedico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHorariosMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHorariosMedico.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHorariosMedico.EnableHeadersVisualStyles = false;
            dgvHorariosMedico.Location = new Point(390, 110);
            dgvHorariosMedico.MultiSelect = false;
            dgvHorariosMedico.Name = "dgvHorariosMedico";
            dgvHorariosMedico.ReadOnly = true;
            dgvHorariosMedico.RowHeadersVisible = false;
            dgvHorariosMedico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorariosMedico.Size = new Size(430, 290);
            dgvHorariosMedico.TabIndex = 30;
            dgvHorariosMedico.CellClick += dgvHorariosMedico_CellClick;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(390, 70);
            label10.Name = "label10";
            label10.Size = new Size(350, 30);
            label10.TabIndex = 29;
            label10.Text = "LISTADO DE HORARIOS DEL MÉDICO";
            // 
            // lblMedico
            // 
            lblMedico.ForeColor = Color.MidnightBlue;
            lblMedico.Location = new Point(20, 22);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new Size(75, 28);
            lblMedico.TabIndex = 31;
            lblMedico.Text = "MÉDICO:";
            lblMedico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboMedico
            // 
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(100, 22);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(420, 25);
            cboMedico.TabIndex = 32;
            cboMedico.SelectedIndexChanged += cboMedico_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(345, 488);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 40);
            btnSalir.TabIndex = 33;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmHorariosMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(840, 540);
            Controls.Add(btnSalir);
            Controls.Add(cboMedico);
            Controls.Add(lblMedico);
            Controls.Add(dgvHorariosMedico);
            Controls.Add(label10);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(grpDatosHorario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHorariosMedico";
            Text = "Horarios de atención";
            Load += frmHorariosMedico_Load;
            grpDatosHorario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHorariosMedico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosHorario;
        private ComboBox cboDiaSemana;
        private CheckBox chkEstado;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private DataGridView dgvHorariosMedico;
        private Label label10;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFin;
        private Label lblMedico;
        private ComboBox cboMedico;
        private Button btnSalir;
    }
}