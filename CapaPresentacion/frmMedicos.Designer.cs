namespace CapaPresentacion
{
    partial class frmMedicos
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
            grpDatosMedico = new GroupBox();
            label8 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            cboEspecialidad = new ComboBox();
            chkEstado = new CheckBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtColegiatura = new TextBox();
            txtCedula = new TextBox();
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
            dgvMedicos = new DataGridView();
            btnNuevo = new Button();
            btnHorarios = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            grpDatosMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            SuspendLayout();
            // 
            // grpDatosMedico
            // 
            grpDatosMedico.BackColor = Color.White;
            grpDatosMedico.Controls.Add(label8);
            grpDatosMedico.Controls.Add(txtCorreo);
            grpDatosMedico.Controls.Add(txtTelefono);
            grpDatosMedico.Controls.Add(cboEspecialidad);
            grpDatosMedico.Controls.Add(chkEstado);
            grpDatosMedico.Controls.Add(txtApellidos);
            grpDatosMedico.Controls.Add(txtNombres);
            grpDatosMedico.Controls.Add(txtColegiatura);
            grpDatosMedico.Controls.Add(txtCedula);
            grpDatosMedico.Controls.Add(label7);
            grpDatosMedico.Controls.Add(label6);
            grpDatosMedico.Controls.Add(label5);
            grpDatosMedico.Controls.Add(label4);
            grpDatosMedico.Controls.Add(label3);
            grpDatosMedico.Controls.Add(label2);
            grpDatosMedico.Controls.Add(label1);
            grpDatosMedico.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpDatosMedico.ForeColor = Color.MidnightBlue;
            grpDatosMedico.Location = new Point(20, 20);
            grpDatosMedico.Name = "grpDatosMedico";
            grpDatosMedico.Size = new Size(360, 380);
            grpDatosMedico.TabIndex = 2;
            grpDatosMedico.TabStop = false;
            grpDatosMedico.Text = "Datos del médico";
            // 
            // label8
            // 
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 35);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 20;
            label8.Text = "Especialidad:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(145, 288);
            txtCorreo.MaxLength = 150;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(190, 25);
            txtCorreo.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(145, 246);
            txtTelefono.MaxLength = 15;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 25);
            txtTelefono.TabIndex = 18;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Location = new Point(145, 35);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(190, 25);
            cboEspecialidad.TabIndex = 17;
            // 
            // chkEstado
            // 
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.ForeColor = Color.Black;
            chkEstado.Location = new Point(145, 330);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(150, 25);
            chkEstado.TabIndex = 16;
            chkEstado.Text = "Médico activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(145, 204);
            txtApellidos.MaxLength = 100;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(190, 25);
            txtApellidos.TabIndex = 14;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(145, 162);
            txtNombres.MaxLength = 100;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(190, 25);
            txtNombres.TabIndex = 13;
            // 
            // txtColegiatura
            // 
            txtColegiatura.Location = new Point(145, 120);
            txtColegiatura.MaxLength = 30;
            txtColegiatura.Name = "txtColegiatura";
            txtColegiatura.Size = new Size(190, 25);
            txtColegiatura.TabIndex = 10;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(145, 78);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(190, 25);
            txtCedula.TabIndex = 9;
            // 
            // label7
            // 
            label7.ForeColor = Color.Black;
            label7.Location = new Point(20, 288);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 6;
            label7.Text = "Correo:";
            // 
            // label6
            // 
            label6.ForeColor = Color.Black;
            label6.Location = new Point(20, 120);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Colegiatura:";
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
            label4.Location = new Point(20, 75);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 3;
            label4.Text = "Cédula:";
            // 
            // label3
            // 
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 246);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 2;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 204);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 162);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(400, 23);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 4;
            label9.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(465, 20);
            txtBuscar.MaxLength = 100;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(240, 23);
            txtBuscar.TabIndex = 5;
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
            btnBuscar.Location = new Point(715, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 32);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(400, 60);
            label10.Name = "label10";
            label10.Size = new Size(250, 30);
            label10.TabIndex = 7;
            label10.Text = "LISTADO DE MÉDICOS";
            // 
            // dgvMedicos
            // 
            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AllowUserToDeleteRows = false;
            dgvMedicos.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.BackgroundColor = Color.White;
            dgvMedicos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMedicos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMedicos.EnableHeadersVisualStyles = false;
            dgvMedicos.Location = new Point(400, 95);
            dgvMedicos.MultiSelect = false;
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowHeadersVisible = false;
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicos.Size = new Size(440, 305);
            dgvMedicos.TabIndex = 8;
            dgvMedicos.CellClick += dgvMedicos_CellClick;
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
            btnNuevo.Location = new Point(41, 442);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnHorarios
            // 
            btnHorarios.BackColor = Color.MediumSlateBlue;
            btnHorarios.Cursor = Cursors.Hand;
            btnHorarios.FlatAppearance.BorderSize = 0;
            btnHorarios.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            btnHorarios.FlatStyle = FlatStyle.Flat;
            btnHorarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHorarios.ForeColor = Color.White;
            btnHorarios.Location = new Point(691, 442);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Size = new Size(120, 40);
            btnHorarios.TabIndex = 19;
            btnHorarios.Text = "HORARIOS";
            btnHorarios.UseVisualStyleBackColor = false;
            btnHorarios.Click += btnHorarios_Click;
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
            btnCancelar.Location = new Point(561, 442);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 18;
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
            btnEliminar.Location = new Point(431, 442);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 17;
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
            btnModificar.Location = new Point(301, 442);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 40);
            btnModificar.TabIndex = 16;
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
            btnGuardar.Location = new Point(171, 442);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(840, 540);
            Controls.Add(btnNuevo);
            Controls.Add(btnHorarios);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvMedicos);
            Controls.Add(label10);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label9);
            Controls.Add(grpDatosMedico);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMedicos";
            Text = "Gestión de Médicos";
            Load += frmMedicos_Load;
            grpDatosMedico.ResumeLayout(false);
            grpDatosMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatosMedico;
        private ComboBox cboEspecialidad;
        private CheckBox chkEstado;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtColegiatura;
        private TextBox txtCedula;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label8;
        private Label label9;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label10;
        private DataGridView dgvMedicos;
        private Button btnNuevo;
        private Button btnHorarios;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
    }
}