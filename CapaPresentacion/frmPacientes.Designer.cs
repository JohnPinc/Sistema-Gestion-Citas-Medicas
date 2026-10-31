namespace CapaPresentacion
{
    partial class frmPacientes
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
            grpDatosPaciente = new GroupBox();
            chkEstado = new CheckBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            cboGenero = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtCedula = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            label10 = new Label();
            dgvPacientes = new DataGridView();
            btnGuardar = new Button();
            button3 = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnHistorial = new Button();
            btnNuevo = new Button();
            lblTituloPacientes = new Label();
            grpDatosPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // grpDatosPaciente
            // 
            grpDatosPaciente.BackColor = Color.White;
            grpDatosPaciente.Controls.Add(chkEstado);
            grpDatosPaciente.Controls.Add(txtDireccion);
            grpDatosPaciente.Controls.Add(txtCorreo);
            grpDatosPaciente.Controls.Add(txtTelefono);
            grpDatosPaciente.Controls.Add(cboGenero);
            grpDatosPaciente.Controls.Add(dtpFechaNacimiento);
            grpDatosPaciente.Controls.Add(txtApellidos);
            grpDatosPaciente.Controls.Add(txtNombres);
            grpDatosPaciente.Controls.Add(txtCedula);
            grpDatosPaciente.Controls.Add(label8);
            grpDatosPaciente.Controls.Add(label7);
            grpDatosPaciente.Controls.Add(label6);
            grpDatosPaciente.Controls.Add(label5);
            grpDatosPaciente.Controls.Add(label4);
            grpDatosPaciente.Controls.Add(label3);
            grpDatosPaciente.Controls.Add(label2);
            grpDatosPaciente.Controls.Add(label1);
            grpDatosPaciente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpDatosPaciente.ForeColor = Color.MidnightBlue;
            grpDatosPaciente.Location = new Point(20, 20);
            grpDatosPaciente.Name = "grpDatosPaciente";
            grpDatosPaciente.Size = new Size(360, 430);
            grpDatosPaciente.TabIndex = 1;
            grpDatosPaciente.TabStop = false;
            grpDatosPaciente.Text = "Datos del paciente";
            // 
            // chkEstado
            // 
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.ForeColor = Color.Black;
            chkEstado.Location = new Point(145, 395);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(160, 25);
            chkEstado.TabIndex = 16;
            chkEstado.Text = "Paciente activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(145, 312);
            txtDireccion.MaxLength = 250;
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ScrollBars = ScrollBars.Vertical;
            txtDireccion.Size = new Size(190, 65);
            txtDireccion.TabIndex = 15;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(145, 272);
            txtCorreo.MaxLength = 150;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(190, 25);
            txtCorreo.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(145, 232);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 25);
            txtTelefono.TabIndex = 13;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cboGenero.Location = new Point(145, 192);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(190, 25);
            cboGenero.TabIndex = 12;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(145, 152);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.RightToLeft = RightToLeft.No;
            dtpFechaNacimiento.Size = new Size(190, 25);
            dtpFechaNacimiento.TabIndex = 11;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(145, 112);
            txtApellidos.MaxLength = 100;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(190, 25);
            txtApellidos.TabIndex = 10;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(145, 72);
            txtNombres.MaxLength = 100;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(190, 25);
            txtNombres.TabIndex = 9;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(145, 32);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(190, 25);
            txtCedula.TabIndex = 8;
            // 
            // label8
            // 
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 315);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 7;
            label8.Text = "Dirección:";
            // 
            // label7
            // 
            label7.ForeColor = Color.Black;
            label7.Location = new Point(20, 275);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 6;
            label7.Text = "Correo:";
            // 
            // label6
            // 
            label6.ForeColor = Color.Black;
            label6.Location = new Point(20, 115);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Apellidos:";
            // 
            // label5
            // 
            label5.ForeColor = Color.Black;
            label5.Location = new Point(20, 35);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 4;
            label5.Text = "Cédula:";
            // 
            // label4
            // 
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 75);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 3;
            label4.Text = "Nombres:";
            // 
            // label3
            // 
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 235);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 2;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 195);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "Género:";
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 155);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Fecha nacimiento:";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(400, 25);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 2;
            label9.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(465, 22);
            txtBuscar.MaxLength = 100;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(240, 23);
            txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(715, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 32);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(400, 65);
            label10.Name = "label10";
            label10.Size = new Size(250, 30);
            label10.TabIndex = 5;
            label10.Text = "LISTADO DE PACIENTES";
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.Location = new Point(400, 95);
            dgvPacientes.MultiSelect = false;
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(440, 355);
            dgvPacientes.TabIndex = 6;
            dgvPacientes.CellClick += dgvPacientes_CellClick;
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
            btnGuardar.Location = new Point(150, 470);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(345, 553);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
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
            btnModificar.Location = new Point(280, 470);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 40);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
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
            btnEliminar.Location = new Point(410, 470);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "DAR DE BAJA";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnCancelar.Location = new Point(540, 470);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.MediumSlateBlue;
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Location = new Point(670, 470);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(120, 40);
            btnHistorial.TabIndex = 13;
            btnHistorial.Text = "HISTORIAL";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
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
            btnNuevo.Location = new Point(20, 470);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lblTituloPacientes
            // 
            lblTituloPacientes.BackColor = Color.Transparent;
            lblTituloPacientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTituloPacientes.ForeColor = Color.MidnightBlue;
            lblTituloPacientes.Location = new Point(20, 15);
            lblTituloPacientes.Name = "lblTituloPacientes";
            lblTituloPacientes.Size = new Size(350, 40);
            lblTituloPacientes.TabIndex = 0;
            lblTituloPacientes.Text = "GESTIÓN DE PACIENTES";
            lblTituloPacientes.TextAlign = ContentAlignment.MiddleLeft;
            lblTituloPacientes.Visible = false;
            // 
            // frmPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(840, 540);
            Controls.Add(btnNuevo);
            Controls.Add(btnHistorial);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(button3);
            Controls.Add(btnGuardar);
            Controls.Add(dgvPacientes);
            Controls.Add(label10);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label9);
            Controls.Add(grpDatosPaciente);
            Controls.Add(lblTituloPacientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPacientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Pacientes\n";
            Load += frmPacientes_Load;
            grpDatosPaciente.ResumeLayout(false);
            grpDatosPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grpDatosPaciente;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCedula;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cboGenero;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private CheckBox chkEstado;
        private TextBox txtDireccion;
        private Label label9;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label10;
        private DataGridView dgvPacientes;
        private Button btnGuardar;
        private Button button3;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnHistorial;
        private Button btnNuevo;
        private Label lblTituloPacientes;
    }
}