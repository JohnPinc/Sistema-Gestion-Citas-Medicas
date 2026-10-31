namespace CapaPresentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            btnSalir = new Button();
            btnReportes = new Button();
            btnCitas = new Button();
            btnHorarios = new Button();
            btnEspecialidades = new Button();
            btnMedicos = new Button();
            btnPacientes = new Button();
            btnInicio = new Button();
            label2 = new Label();
            pnlPrincipal = new Panel();
            pnlContenedor = new Panel();
            panel2 = new Panel();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            pnlPrincipal.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 40, 88);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnCitas);
            panel1.Controls.Add(btnHorarios);
            panel1.Controls.Add(btnEspecialidades);
            panel1.Controls.Add(btnMedicos);
            panel1.Controls.Add(btnPacientes);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 661);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(17, 650);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(210, 20);
            label3.TabIndex = 9;
            label3.Text = "Versión 1.0";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(180, 37);
            label1.TabIndex = 2;
            label1.Text = "Consultorio Médico";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(205, 85, 85);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(17, 535);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(20, 0, 0, 0);
            btnSalir.Size = new Size(210, 50);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(70, 137, 186);
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(17, 465);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(20, 0, 0, 0);
            btnReportes.Size = new Size(210, 50);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "REPORTES";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.FromArgb(70, 137, 186);
            btnCitas.Cursor = Cursors.Hand;
            btnCitas.FlatAppearance.BorderSize = 0;
            btnCitas.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnCitas.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCitas.ForeColor = Color.White;
            btnCitas.Location = new Point(17, 405);
            btnCitas.Name = "btnCitas";
            btnCitas.Padding = new Padding(20, 0, 0, 0);
            btnCitas.Size = new Size(210, 50);
            btnCitas.TabIndex = 6;
            btnCitas.Text = "CITAS MÉDICAS";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnHorarios
            // 
            btnHorarios.BackColor = Color.FromArgb(70, 137, 186);
            btnHorarios.Cursor = Cursors.Hand;
            btnHorarios.FlatAppearance.BorderSize = 0;
            btnHorarios.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnHorarios.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnHorarios.FlatStyle = FlatStyle.Flat;
            btnHorarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnHorarios.ForeColor = Color.White;
            btnHorarios.Location = new Point(17, 345);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Padding = new Padding(20, 0, 0, 0);
            btnHorarios.Size = new Size(210, 50);
            btnHorarios.TabIndex = 5;
            btnHorarios.Text = "HORARIOS DE ATENCIÓN";
            btnHorarios.UseVisualStyleBackColor = false;
            btnHorarios.Click += btnHorarios_Click;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.BackColor = Color.FromArgb(70, 137, 186);
            btnEspecialidades.Cursor = Cursors.Hand;
            btnEspecialidades.FlatAppearance.BorderSize = 0;
            btnEspecialidades.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnEspecialidades.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnEspecialidades.FlatStyle = FlatStyle.Flat;
            btnEspecialidades.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEspecialidades.ForeColor = Color.White;
            btnEspecialidades.Location = new Point(17, 285);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Padding = new Padding(20, 0, 0, 0);
            btnEspecialidades.Size = new Size(210, 50);
            btnEspecialidades.TabIndex = 4;
            btnEspecialidades.Text = "ESPECIALIDADES";
            btnEspecialidades.UseVisualStyleBackColor = false;
            btnEspecialidades.Click += btnEspecialidades_Click;
            // 
            // btnMedicos
            // 
            btnMedicos.BackColor = Color.FromArgb(70, 137, 186);
            btnMedicos.Cursor = Cursors.Hand;
            btnMedicos.FlatAppearance.BorderSize = 0;
            btnMedicos.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnMedicos.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnMedicos.FlatStyle = FlatStyle.Flat;
            btnMedicos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnMedicos.ForeColor = Color.White;
            btnMedicos.Location = new Point(17, 225);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Padding = new Padding(20, 0, 0, 0);
            btnMedicos.Size = new Size(210, 50);
            btnMedicos.TabIndex = 3;
            btnMedicos.Text = "MÉDICOS";
            btnMedicos.UseVisualStyleBackColor = false;
            btnMedicos.Click += btnMedicos_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = Color.FromArgb(70, 137, 186);
            btnPacientes.Cursor = Cursors.Hand;
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnPacientes.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPacientes.ForeColor = Color.White;
            btnPacientes.Location = new Point(17, 165);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Padding = new Padding(20, 0, 0, 0);
            btnPacientes.Size = new Size(210, 50);
            btnPacientes.TabIndex = 2;
            btnPacientes.Text = "PACIENTES";
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(70, 137, 186);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(17, 105);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(20, 0, 0, 0);
            btnInicio.Size = new Size(210, 50);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(180, 30);
            label2.TabIndex = 0;
            label2.Text = "SISTEMA DE CITAS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.WhiteSmoke;
            pnlPrincipal.Controls.Add(pnlContenedor);
            pnlPrincipal.Controls.Add(panel2);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(230, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(854, 661);
            pnlPrincipal.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 80);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(854, 581);
            pnlContenedor.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(picLogo);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 80);
            panel2.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.logo_citas;
            picLogo.Location = new Point(25, 15);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(65, 65);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(86, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(600, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "INICIO";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(pnlPrincipal);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1100, 700);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Citas Médicas";
            Load += frmPrincipal_Load;
            panel1.ResumeLayout(false);
            pnlPrincipal.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlPrincipal;
        private Panel panel2;
        private Panel pnlContenedor;
        private Label lblTitulo;
        private Button btnReportes;
        private Button btnCitas;
        private Button btnHorarios;
        private Button btnEspecialidades;
        private Button btnMedicos;
        private Button btnPacientes;
        private Button btnInicio;
        private Label label2;
        private Button btnSalir;
        private PictureBox picLogo;
        private Label label1;
        private Label label3;
    }
}
