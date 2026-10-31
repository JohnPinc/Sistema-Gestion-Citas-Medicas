namespace CapaPresentacion
{
    partial class frmReportes
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
            grpFiltrosReporte = new GroupBox();
            cboPaciente = new ComboBox();
            label2 = new Label();
            dtpHasta = new DateTimePicker();
            btnLimpiar = new Button();
            btnGenerar = new Button();
            cboEstado = new ComboBox();
            dtpDesde = new DateTimePicker();
            label8 = new Label();
            cboMedico = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            dgvReportes = new DataGridView();
            label10 = new Label();
            btnImprimir = new Button();
            btnCerrar = new Button();
            grpFiltrosReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // grpFiltrosReporte
            // 
            grpFiltrosReporte.BackColor = Color.White;
            grpFiltrosReporte.Controls.Add(cboPaciente);
            grpFiltrosReporte.Controls.Add(label2);
            grpFiltrosReporte.Controls.Add(dtpHasta);
            grpFiltrosReporte.Controls.Add(btnLimpiar);
            grpFiltrosReporte.Controls.Add(btnGenerar);
            grpFiltrosReporte.Controls.Add(cboEstado);
            grpFiltrosReporte.Controls.Add(dtpDesde);
            grpFiltrosReporte.Controls.Add(label8);
            grpFiltrosReporte.Controls.Add(cboMedico);
            grpFiltrosReporte.Controls.Add(label6);
            grpFiltrosReporte.Controls.Add(label4);
            grpFiltrosReporte.Controls.Add(label1);
            grpFiltrosReporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            grpFiltrosReporte.ForeColor = Color.MidnightBlue;
            grpFiltrosReporte.Location = new Point(20, 20);
            grpFiltrosReporte.Name = "grpFiltrosReporte";
            grpFiltrosReporte.Size = new Size(800, 180);
            grpFiltrosReporte.TabIndex = 5;
            grpFiltrosReporte.TabStop = false;
            grpFiltrosReporte.Text = "Filtros del reporte";
            // 
            // cboPaciente
            // 
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Location = new Point(455, 80);
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(310, 25);
            cboPaciente.TabIndex = 33;
            // 
            // label2
            // 
            label2.ForeColor = Color.Black;
            label2.Location = new Point(380, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 32;
            label2.Text = "Paciente:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(305, 35);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(145, 25);
            dtpHasta.TabIndex = 31;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(435, 125);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 38);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.SteelBlue;
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(240, 125);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(180, 38);
            btnGenerar.TabIndex = 29;
            btnGenerar.Text = "GENERAR REPORTE";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerarReporte_Click;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Todos", "Programada", "Atendida", "Cancelada", "Reprogramada", "No Asistida" });
            cboEstado.Location = new Point(545, 35);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(220, 25);
            cboEstado.TabIndex = 26;
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(80, 35);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(145, 25);
            dtpDesde.TabIndex = 22;
            // 
            // label8
            // 
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 80);
            label8.Name = "label8";
            label8.Size = new Size(60, 28);
            label8.TabIndex = 20;
            label8.Text = "Médico:";
            // 
            // cboMedico
            // 
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(85, 80);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(270, 25);
            cboMedico.TabIndex = 17;
            // 
            // label6
            // 
            label6.ForeColor = Color.Black;
            label6.Location = new Point(245, 35);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 5;
            label6.Text = "Hasta:";
            // 
            // label4
            // 
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 35);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 3;
            label4.Text = "Desde:";
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(475, 35);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 0;
            label1.Text = "Estado:";
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.White;
            dgvReportes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReportes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReportes.EnableHeadersVisualStyles = false;
            dgvReportes.Location = new Point(20, 250);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(800, 215);
            dgvReportes.TabIndex = 10;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(20, 215);
            label10.Name = "label10";
            label10.Size = new Size(300, 30);
            label10.TabIndex = 9;
            label10.Text = "RESULTADOS DEL REPORTE";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.SeaGreen;
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnImprimir.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(280, 480);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(135, 42);
            btnImprimir.TabIndex = 34;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(430, 480);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(130, 42);
            btnCerrar.TabIndex = 34;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(840, 540);
            Controls.Add(btnCerrar);
            Controls.Add(btnImprimir);
            Controls.Add(dgvReportes);
            Controls.Add(label10);
            Controls.Add(grpFiltrosReporte);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReportes";
            Text = "Reportes de citas médicas";
            Load += frmReportes_Load;
            Click += frmReportes_Load;
            grpFiltrosReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFiltrosReporte;
        private Label label2;
        private DateTimePicker dtpHasta;
        private Button btnLimpiar;
        private Button btnGenerar;
        private ComboBox cboEstado;
        private DateTimePicker dtpDesde;
        private Label label8;
        private ComboBox cboMedico;
        private Label label6;
        private Label label4;
        private Label label1;
        private ComboBox cboPaciente;
        private DataGridView dgvReportes;
        private Label label10;
        private Button btnImprimir;
        private Button btnCerrar;
    }
}