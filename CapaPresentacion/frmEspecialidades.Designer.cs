namespace CapaPresentacion
{
    partial class frmEspecialidades
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
            dgvEspecialidades = new DataGridView();
            label10 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label9 = new Label();
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            grpDatosEspecialidad = new GroupBox();
            txtDescripcion = new TextBox();
            label8 = new Label();
            chkEstado = new CheckBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            grpDatosEspecialidad.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvEspecialidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.BackgroundColor = Color.White;
            dgvEspecialidades.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEspecialidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEspecialidades.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEspecialidades.EnableHeadersVisualStyles = false;
            dgvEspecialidades.Location = new Point(400, 95);
            dgvEspecialidades.MultiSelect = false;
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersVisible = false;
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new Size(430, 355);
            dgvEspecialidades.TabIndex = 11;
            dgvEspecialidades.CellClick += dgvEspecialidades_CellClick;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(400, 60);
            label10.Name = "label10";
            label10.Size = new Size(300, 30);
            label10.TabIndex = 10;
            label10.Text = "LISTADO DE ESPECIALIDADES";
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
            btnBuscar.Location = new Point(710, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 32);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(465, 20);
            txtBuscar.MaxLength = 100;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(235, 23);
            txtBuscar.TabIndex = 8;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(400, 23);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 7;
            label9.Text = "Buscar:";
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
            btnNuevo.Location = new Point(85, 470);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 20;
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
            btnCancelar.Location = new Point(605, 470);
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
            btnEliminar.Location = new Point(475, 470);
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
            btnModificar.Location = new Point(345, 470);
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
            btnGuardar.Location = new Point(215, 470);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grpDatosEspecialidad
            // 
            grpDatosEspecialidad.BackColor = Color.White;
            grpDatosEspecialidad.Controls.Add(txtDescripcion);
            grpDatosEspecialidad.Controls.Add(label8);
            grpDatosEspecialidad.Controls.Add(chkEstado);
            grpDatosEspecialidad.Controls.Add(txtNombre);
            grpDatosEspecialidad.Controls.Add(label5);
            grpDatosEspecialidad.Controls.Add(label1);
            grpDatosEspecialidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpDatosEspecialidad.ForeColor = Color.MidnightBlue;
            grpDatosEspecialidad.Location = new Point(20, 20);
            grpDatosEspecialidad.Name = "grpDatosEspecialidad";
            grpDatosEspecialidad.Size = new Size(360, 350);
            grpDatosEspecialidad.TabIndex = 21;
            grpDatosEspecialidad.TabStop = false;
            grpDatosEspecialidad.Text = "Datos de la especialidad";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(30, 155);
            txtDescripcion.MaxLength = 250;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(300, 100);
            txtDescripcion.TabIndex = 21;
            // 
            // label8
            // 
            label8.ForeColor = Color.Black;
            label8.Location = new Point(118, 117);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 20;
            label8.Text = "Descripción:";
            // 
            // chkEstado
            // 
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.ForeColor = Color.Black;
            chkEstado.Location = new Point(97, 281);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(190, 25);
            chkEstado.TabIndex = 16;
            chkEstado.Text = "Especialidad activa";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 75);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 25);
            txtNombre.TabIndex = 9;
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
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(118, 25);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // frmEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(840, 540);
            Controls.Add(grpDatosEspecialidad);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvEspecialidades);
            Controls.Add(label10);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEspecialidades";
            Text = "Gestión de Especialidades";
            Load += frmEspecialidades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            grpDatosEspecialidad.ResumeLayout(false);
            grpDatosEspecialidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEspecialidades;
        private Label label10;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label9;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private GroupBox grpDatosEspecialidad;
        private Label label8;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private ComboBox cboEspecialidad;
        private CheckBox chkEstado;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtColegiatura;
        private TextBox txtNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcion;
    }
}