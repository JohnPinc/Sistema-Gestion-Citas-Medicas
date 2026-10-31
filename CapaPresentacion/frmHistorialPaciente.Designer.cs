namespace CapaPresentacion
{
    partial class frmHistorialPaciente
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
            grpConsultaHistorial = new GroupBox();
            dtpHasta = new DateTimePicker();
            btnLimpiar = new Button();
            btnConsultar = new Button();
            cboEstado = new ComboBox();
            dtpDesde = new DateTimePicker();
            label8 = new Label();
            cboPaciente = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnCerrar = new Button();
            dgvHistorial = new DataGridView();
            label2 = new Label();
            grpConsultaHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // grpConsultaHistorial
            // 
            grpConsultaHistorial.BackColor = Color.White;
            grpConsultaHistorial.Controls.Add(dtpHasta);
            grpConsultaHistorial.Controls.Add(btnLimpiar);
            grpConsultaHistorial.Controls.Add(btnConsultar);
            grpConsultaHistorial.Controls.Add(cboEstado);
            grpConsultaHistorial.Controls.Add(dtpDesde);
            grpConsultaHistorial.Controls.Add(label8);
            grpConsultaHistorial.Controls.Add(cboPaciente);
            grpConsultaHistorial.Controls.Add(label6);
            grpConsultaHistorial.Controls.Add(label4);
            grpConsultaHistorial.Controls.Add(label1);
            grpConsultaHistorial.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpConsultaHistorial.ForeColor = Color.MidnightBlue;
            grpConsultaHistorial.Location = new Point(20, 20);
            grpConsultaHistorial.Name = "grpConsultaHistorial";
            grpConsultaHistorial.Size = new Size(800, 135);
            grpConsultaHistorial.TabIndex = 4;
            grpConsultaHistorial.TabStop = false;
            grpConsultaHistorial.Text = "Consulta del historial";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(310, 85);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(145, 25);
            dtpHasta.TabIndex = 31;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(615, 33);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 34);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.SteelBlue;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(470, 33);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(130, 34);
            btnConsultar.TabIndex = 29;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Todos", "Programada", "Atendida", "Cancelada", "Reprogramada", "No Asistida" });
            cboEstado.Location = new Point(545, 85);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(200, 25);
            cboEstado.TabIndex = 26;
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(85, 85);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(145, 25);
            dtpDesde.TabIndex = 22;
            // 
            // label8
            // 
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 35);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 20;
            label8.Text = "Paciente:";
            // 
            // cboPaciente
            // 
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(100, 35);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(350, 25);
            cboPaciente.TabIndex = 17;
            // 
            // label6
            // 
            label6.ForeColor = Color.Black;
            label6.Location = new Point(250, 85);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 5;
            label6.Text = "Hasta:";
            // 
            // label4
            // 
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 85);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 3;
            label4.Text = "Desde:";
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(480, 85);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 0;
            label1.Text = "Estado:";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(350, 470);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 42);
            btnCerrar.TabIndex = 36;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.Location = new Point(20, 205);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(800, 245);
            dgvHistorial.TabIndex = 35;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(20, 170);
            label2.Name = "label2";
            label2.Size = new Size(360, 30);
            label2.TabIndex = 34;
            label2.Text = "HISTORIAL DE CITAS DEL PACIENTE";
            // 
            // frmHistorialPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(840, 540);
            Controls.Add(btnCerrar);
            Controls.Add(dgvHistorial);
            Controls.Add(label2);
            Controls.Add(grpConsultaHistorial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistorialPaciente";
            Text = "Historial de citas del paciente";
            Load += frmHistorialPaciente_Load;
            grpConsultaHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpConsultaHistorial;
        private ComboBox cboEstado;
        private DateTimePicker dtpDesde;
        private Label label8;
        private ComboBox cboPaciente;
        private Label label6;
        private Label label4;
        private Label label1;
        private Button btnLimpiar;
        private Button btnConsultar;
        private DateTimePicker dtpHasta;
        private Button btnCerrar;
        private DataGridView dgvHistorial;
        private Label label2;
    }
}