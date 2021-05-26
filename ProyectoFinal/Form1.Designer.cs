namespace ProyectoFinal
{
    partial class Hospital
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.PanelProceso = new System.Windows.Forms.Panel();
            this.BtnAltaPro = new System.Windows.Forms.Button();
            this.BtnInterpro = new System.Windows.Forms.Button();
            this.BtnCitaPro = new System.Windows.Forms.Button();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.BtnConAlt = new System.Windows.Forms.Button();
            this.btnConIngreso = new System.Windows.Forms.Button();
            this.btnConCita = new System.Windows.Forms.Button();
            this.btnConHabi = new System.Windows.Forms.Button();
            this.BtnConMedic = new System.Windows.Forms.Button();
            this.BtnConPacie = new System.Windows.Forms.Button();
            this.panelManteni = new System.Windows.Forms.Panel();
            this.BtnHabi = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.BtnProces = new FontAwesome.Sharp.IconButton();
            this.BtnConsul = new FontAwesome.Sharp.IconButton();
            this.BtnManteni = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelPict = new System.Windows.Forms.Panel();
            this.PanelSeparacion = new System.Windows.Forms.Panel();
            this.panelDescktop = new System.Windows.Forms.Panel();
            this.BtnReproducir = new FontAwesome.Sharp.IconButton();
            this.Salir = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBFECHA = new System.Windows.Forms.Label();
            this.LBHORA = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TLFCHILD = new System.Windows.Forms.Label();
            this.IcoCharCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.TimerHora = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.PanelProceso.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            this.panelManteni.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelPict.SuspendLayout();
            this.panelDescktop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcoCharCurrentChild)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.PanelProceso);
            this.panelMenu.Controls.Add(this.panelConsulta);
            this.panelMenu.Controls.Add(this.panelManteni);
            this.panelMenu.Controls.Add(this.BtnProces);
            this.panelMenu.Controls.Add(this.BtnConsul);
            this.panelMenu.Controls.Add(this.BtnManteni);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Location = new System.Drawing.Point(-9, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(215, 669);
            this.panelMenu.TabIndex = 4;
            // 
            // PanelProceso
            // 
            this.PanelProceso.Controls.Add(this.BtnAltaPro);
            this.PanelProceso.Controls.Add(this.BtnInterpro);
            this.PanelProceso.Controls.Add(this.BtnCitaPro);
            this.PanelProceso.Location = new System.Drawing.Point(16, 538);
            this.PanelProceso.Name = "PanelProceso";
            this.PanelProceso.Size = new System.Drawing.Size(192, 128);
            this.PanelProceso.TabIndex = 10;
            this.PanelProceso.Visible = false;
            // 
            // BtnAltaPro
            // 
            this.BtnAltaPro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAltaPro.FlatAppearance.BorderSize = 0;
            this.BtnAltaPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltaPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAltaPro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAltaPro.Location = new System.Drawing.Point(0, 58);
            this.BtnAltaPro.Name = "BtnAltaPro";
            this.BtnAltaPro.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnAltaPro.Size = new System.Drawing.Size(192, 27);
            this.BtnAltaPro.TabIndex = 13;
            this.BtnAltaPro.Text = "Alta medica";
            this.BtnAltaPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAltaPro.UseVisualStyleBackColor = true;
            this.BtnAltaPro.Click += new System.EventHandler(this.BtnAltaPro_Click);
            // 
            // BtnInterpro
            // 
            this.BtnInterpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInterpro.FlatAppearance.BorderSize = 0;
            this.BtnInterpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInterpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInterpro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnInterpro.Location = new System.Drawing.Point(0, 29);
            this.BtnInterpro.Name = "BtnInterpro";
            this.BtnInterpro.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnInterpro.Size = new System.Drawing.Size(192, 29);
            this.BtnInterpro.TabIndex = 8;
            this.BtnInterpro.Text = "Internados";
            this.BtnInterpro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInterpro.UseVisualStyleBackColor = true;
            this.BtnInterpro.Click += new System.EventHandler(this.BtnInterpro_Click);
            // 
            // BtnCitaPro
            // 
            this.BtnCitaPro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCitaPro.FlatAppearance.BorderSize = 0;
            this.BtnCitaPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCitaPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCitaPro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCitaPro.Location = new System.Drawing.Point(0, 0);
            this.BtnCitaPro.Name = "BtnCitaPro";
            this.BtnCitaPro.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnCitaPro.Size = new System.Drawing.Size(192, 29);
            this.BtnCitaPro.TabIndex = 7;
            this.BtnCitaPro.Text = "Citas Médicas ";
            this.BtnCitaPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCitaPro.UseVisualStyleBackColor = true;
            this.BtnCitaPro.Click += new System.EventHandler(this.BtnCitaPro_Click);
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.BtnConAlt);
            this.panelConsulta.Controls.Add(this.btnConIngreso);
            this.panelConsulta.Controls.Add(this.btnConCita);
            this.panelConsulta.Controls.Add(this.btnConHabi);
            this.panelConsulta.Controls.Add(this.BtnConMedic);
            this.panelConsulta.Controls.Add(this.BtnConPacie);
            this.panelConsulta.Location = new System.Drawing.Point(15, 305);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(182, 165);
            this.panelConsulta.TabIndex = 9;
            this.panelConsulta.Visible = false;
            // 
            // BtnConAlt
            // 
            this.BtnConAlt.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConAlt.FlatAppearance.BorderSize = 0;
            this.BtnConAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConAlt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConAlt.Location = new System.Drawing.Point(0, 145);
            this.BtnConAlt.Name = "BtnConAlt";
            this.BtnConAlt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnConAlt.Size = new System.Drawing.Size(182, 27);
            this.BtnConAlt.TabIndex = 12;
            this.BtnConAlt.Text = "Alta medica";
            this.BtnConAlt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConAlt.UseVisualStyleBackColor = true;
            this.BtnConAlt.Click += new System.EventHandler(this.BtnConAlt_Click);
            // 
            // btnConIngreso
            // 
            this.btnConIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConIngreso.FlatAppearance.BorderSize = 0;
            this.btnConIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConIngreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConIngreso.Location = new System.Drawing.Point(0, 116);
            this.btnConIngreso.Name = "btnConIngreso";
            this.btnConIngreso.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConIngreso.Size = new System.Drawing.Size(182, 29);
            this.btnConIngreso.TabIndex = 7;
            this.btnConIngreso.Text = "Ingresos";
            this.btnConIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConIngreso.UseVisualStyleBackColor = true;
            this.btnConIngreso.Click += new System.EventHandler(this.btnConIngreso_Click);
            // 
            // btnConCita
            // 
            this.btnConCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConCita.FlatAppearance.BorderSize = 0;
            this.btnConCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConCita.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConCita.Location = new System.Drawing.Point(0, 87);
            this.btnConCita.Name = "btnConCita";
            this.btnConCita.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConCita.Size = new System.Drawing.Size(182, 29);
            this.btnConCita.TabIndex = 6;
            this.btnConCita.Text = "Citas Médicas ";
            this.btnConCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConCita.UseVisualStyleBackColor = true;
            this.btnConCita.Click += new System.EventHandler(this.btnConCita_Click);
            // 
            // btnConHabi
            // 
            this.btnConHabi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConHabi.FlatAppearance.BorderSize = 0;
            this.btnConHabi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConHabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConHabi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConHabi.Location = new System.Drawing.Point(0, 58);
            this.btnConHabi.Name = "btnConHabi";
            this.btnConHabi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnConHabi.Size = new System.Drawing.Size(182, 29);
            this.btnConHabi.TabIndex = 4;
            this.btnConHabi.Text = "Habitaciones ";
            this.btnConHabi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConHabi.UseVisualStyleBackColor = true;
            this.btnConHabi.Click += new System.EventHandler(this.btnConHabi_Click);
            // 
            // BtnConMedic
            // 
            this.BtnConMedic.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConMedic.FlatAppearance.BorderSize = 0;
            this.BtnConMedic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConMedic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConMedic.Location = new System.Drawing.Point(0, 29);
            this.BtnConMedic.Name = "BtnConMedic";
            this.BtnConMedic.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnConMedic.Size = new System.Drawing.Size(182, 29);
            this.BtnConMedic.TabIndex = 3;
            this.BtnConMedic.Text = "Los Médicos ";
            this.BtnConMedic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConMedic.UseVisualStyleBackColor = true;
            this.BtnConMedic.Click += new System.EventHandler(this.BtnConMedic_Click);
            // 
            // BtnConPacie
            // 
            this.BtnConPacie.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConPacie.FlatAppearance.BorderSize = 0;
            this.BtnConPacie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConPacie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConPacie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConPacie.Location = new System.Drawing.Point(0, 0);
            this.BtnConPacie.Name = "BtnConPacie";
            this.BtnConPacie.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnConPacie.Size = new System.Drawing.Size(182, 29);
            this.BtnConPacie.TabIndex = 2;
            this.BtnConPacie.Text = "Los pacientes ";
            this.BtnConPacie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConPacie.UseVisualStyleBackColor = true;
            this.BtnConPacie.Click += new System.EventHandler(this.BtnConPacie_Click);
            // 
            // panelManteni
            // 
            this.panelManteni.Controls.Add(this.BtnHabi);
            this.panelManteni.Controls.Add(this.btnMedico);
            this.panelManteni.Controls.Add(this.btnPaciente);
            this.panelManteni.Location = new System.Drawing.Point(10, 171);
            this.panelManteni.Name = "panelManteni";
            this.panelManteni.Size = new System.Drawing.Size(193, 85);
            this.panelManteni.TabIndex = 8;
            this.panelManteni.Visible = false;
            // 
            // BtnHabi
            // 
            this.BtnHabi.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHabi.FlatAppearance.BorderSize = 0;
            this.BtnHabi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHabi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnHabi.Location = new System.Drawing.Point(0, 52);
            this.BtnHabi.Name = "BtnHabi";
            this.BtnHabi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnHabi.Size = new System.Drawing.Size(193, 24);
            this.BtnHabi.TabIndex = 2;
            this.BtnHabi.Text = "Habitaciones";
            this.BtnHabi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHabi.UseVisualStyleBackColor = true;
            this.BtnHabi.Click += new System.EventHandler(this.BtnHabi_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedico.FlatAppearance.BorderSize = 0;
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMedico.Location = new System.Drawing.Point(0, 23);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMedico.Size = new System.Drawing.Size(193, 29);
            this.btnMedico.TabIndex = 0;
            this.btnMedico.Text = "Medicos";
            this.btnMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPaciente.Location = new System.Drawing.Point(0, 0);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPaciente.Size = new System.Drawing.Size(193, 23);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Pacientes";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // BtnProces
            // 
            this.BtnProces.FlatAppearance.BorderSize = 0;
            this.BtnProces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProces.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProces.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnProces.IconChar = FontAwesome.Sharp.IconChar.Ambulance;
            this.BtnProces.IconColor = System.Drawing.Color.White;
            this.BtnProces.IconSize = 40;
            this.BtnProces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProces.Location = new System.Drawing.Point(13, 491);
            this.BtnProces.Name = "BtnProces";
            this.BtnProces.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnProces.Rotation = 0D;
            this.BtnProces.Size = new System.Drawing.Size(190, 41);
            this.BtnProces.TabIndex = 6;
            this.BtnProces.Text = "Proceso";
            this.BtnProces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProces.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProces.UseVisualStyleBackColor = true;
            this.BtnProces.Click += new System.EventHandler(this.BtnProces_Click);
            // 
            // BtnConsul
            // 
            this.BtnConsul.AutoSize = true;
            this.BtnConsul.FlatAppearance.BorderSize = 0;
            this.BtnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsul.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConsul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsul.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnConsul.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnConsul.IconColor = System.Drawing.Color.White;
            this.BtnConsul.IconSize = 40;
            this.BtnConsul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsul.Location = new System.Drawing.Point(16, 262);
            this.BtnConsul.Name = "BtnConsul";
            this.BtnConsul.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnConsul.Rotation = 0D;
            this.BtnConsul.Size = new System.Drawing.Size(181, 46);
            this.BtnConsul.TabIndex = 7;
            this.BtnConsul.Text = "Consultas";
            this.BtnConsul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsul.UseVisualStyleBackColor = true;
            this.BtnConsul.Click += new System.EventHandler(this.BtnConsul_Click);
            // 
            // BtnManteni
            // 
            this.BtnManteni.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManteni.FlatAppearance.BorderSize = 0;
            this.BtnManteni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManteni.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnManteni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManteni.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BtnManteni.IconChar = FontAwesome.Sharp.IconChar.HospitalAlt;
            this.BtnManteni.IconColor = System.Drawing.Color.White;
            this.BtnManteni.IconSize = 40;
            this.BtnManteni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManteni.Location = new System.Drawing.Point(0, 117);
            this.BtnManteni.Name = "BtnManteni";
            this.BtnManteni.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnManteni.Rotation = 0D;
            this.BtnManteni.Size = new System.Drawing.Size(215, 48);
            this.BtnManteni.TabIndex = 5;
            this.BtnManteni.Text = "Mantenimiento";
            this.BtnManteni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManteni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnManteni.UseVisualStyleBackColor = true;
            this.BtnManteni.Click += new System.EventHandler(this.BtnManteni_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(215, 117);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.homepage_vector_doctors_02;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelPict
            // 
            this.PanelPict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelPict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelPict.Controls.Add(this.PanelSeparacion);
            this.PanelPict.Controls.Add(this.panelDescktop);
            this.PanelPict.Controls.Add(this.TLFCHILD);
            this.PanelPict.Controls.Add(this.IcoCharCurrentChild);
            this.PanelPict.Location = new System.Drawing.Point(205, 0);
            this.PanelPict.Name = "PanelPict";
            this.PanelPict.Size = new System.Drawing.Size(1228, 669);
            this.PanelPict.TabIndex = 5;
            // 
            // PanelSeparacion
            // 
            this.PanelSeparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.PanelSeparacion.Location = new System.Drawing.Point(7, 60);
            this.PanelSeparacion.Name = "PanelSeparacion";
            this.PanelSeparacion.Size = new System.Drawing.Size(1221, 14);
            this.PanelSeparacion.TabIndex = 7;
            // 
            // panelDescktop
            // 
            this.panelDescktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDescktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDescktop.Controls.Add(this.label3);
            this.panelDescktop.Controls.Add(this.BtnReproducir);
            this.panelDescktop.Controls.Add(this.Salir);
            this.panelDescktop.Controls.Add(this.panel1);
            this.panelDescktop.Controls.Add(this.LBFECHA);
            this.panelDescktop.Controls.Add(this.LBHORA);
            this.panelDescktop.Controls.Add(this.pictureBox2);
            this.panelDescktop.Location = new System.Drawing.Point(7, 80);
            this.panelDescktop.Name = "panelDescktop";
            this.panelDescktop.Size = new System.Drawing.Size(1218, 560);
            this.panelDescktop.TabIndex = 7;
            // 
            // BtnReproducir
            // 
            this.BtnReproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReproducir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnReproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReproducir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReproducir.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.BtnReproducir.IconColor = System.Drawing.Color.Red;
            this.BtnReproducir.IconSize = 50;
            this.BtnReproducir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReproducir.Location = new System.Drawing.Point(1013, 58);
            this.BtnReproducir.Name = "BtnReproducir";
            this.BtnReproducir.Rotation = 0D;
            this.BtnReproducir.Size = new System.Drawing.Size(205, 62);
            this.BtnReproducir.TabIndex = 6;
            this.BtnReproducir.Text = "Ver video de uso\r\ncorrecto de la app\r\n";
            this.BtnReproducir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReproducir.UseVisualStyleBackColor = true;
            this.BtnReproducir.Click += new System.EventHandler(this.BtnReproducir_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Salir.IconChar = FontAwesome.Sharp.IconChar.Ambulance;
            this.Salir.IconColor = System.Drawing.Color.White;
            this.Salir.IconSize = 30;
            this.Salir.Location = new System.Drawing.Point(402, 410);
            this.Salir.Name = "Salir";
            this.Salir.Rotation = 0D;
            this.Salir.Size = new System.Drawing.Size(269, 40);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Precione para salir";
            this.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 49);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al hospital R&C";
            // 
            // LBFECHA
            // 
            this.LBFECHA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBFECHA.AutoSize = true;
            this.LBFECHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFECHA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(184)))));
            this.LBFECHA.Location = new System.Drawing.Point(397, 351);
            this.LBFECHA.Name = "LBFECHA";
            this.LBFECHA.Size = new System.Drawing.Size(80, 25);
            this.LBFECHA.TabIndex = 3;
            this.LBFECHA.Text = "FECHA";
            // 
            // LBHORA
            // 
            this.LBHORA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBHORA.AutoSize = true;
            this.LBHORA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBHORA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(184)))));
            this.LBHORA.Location = new System.Drawing.Point(345, 282);
            this.LBHORA.Name = "LBHORA";
            this.LBHORA.Size = new System.Drawing.Size(203, 69);
            this.LBHORA.TabIndex = 2;
            this.LBHORA.Text = "HORA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.homepage_vector_doctors_02;
            this.pictureBox2.Location = new System.Drawing.Point(374, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(334, 201);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // TLFCHILD
            // 
            this.TLFCHILD.AutoSize = true;
            this.TLFCHILD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLFCHILD.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TLFCHILD.Location = new System.Drawing.Point(91, 27);
            this.TLFCHILD.Name = "TLFCHILD";
            this.TLFCHILD.Size = new System.Drawing.Size(54, 20);
            this.TLFCHILD.TabIndex = 1;
            this.TLFCHILD.Text = "Home";
            // 
            // IcoCharCurrentChild
            // 
            this.IcoCharCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.IcoCharCurrentChild.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.IcoCharCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IcoCharCurrentChild.IconColor = System.Drawing.Color.MediumVioletRed;
            this.IcoCharCurrentChild.IconSize = 35;
            this.IcoCharCurrentChild.Location = new System.Drawing.Point(50, 12);
            this.IcoCharCurrentChild.Name = "IcoCharCurrentChild";
            this.IcoCharCurrentChild.Size = new System.Drawing.Size(35, 35);
            this.IcoCharCurrentChild.TabIndex = 0;
            this.IcoCharCurrentChild.TabStop = false;
            // 
            // TimerHora
            // 
            this.TimerHora.Enabled = true;
            this.TimerHora.Tick += new System.EventHandler(this.TimerHora_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(224, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "2020 Program- Created by Reynaldo Cruz | Matricula | 2018-6843 | Copyright © 2020" +
    " by Reynaldo Cruz Doble";
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 669);
            this.Controls.Add(this.PanelPict);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1451, 716);
            this.Name = "Hospital";
            this.Text = "Bienvenido al Hospitla R&C";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.PanelProceso.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelManteni.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelPict.ResumeLayout(false);
            this.PanelPict.PerformLayout();
            this.panelDescktop.ResumeLayout(false);
            this.panelDescktop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcoCharCurrentChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnConsul;
        private FontAwesome.Sharp.IconButton BtnProces;
        private FontAwesome.Sharp.IconButton BtnManteni;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelPict;
        private FontAwesome.Sharp.IconPictureBox IcoCharCurrentChild;
        private System.Windows.Forms.Label TLFCHILD;
        private System.Windows.Forms.Panel panelDescktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LBFECHA;
        private System.Windows.Forms.Label LBHORA;
        private System.Windows.Forms.Timer TimerHora;
        private System.Windows.Forms.Panel panelManteni;
        private System.Windows.Forms.Button BtnHabi;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Panel PanelSeparacion;
        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.Button BtnConPacie;
        private System.Windows.Forms.Button btnConIngreso;
        private System.Windows.Forms.Button btnConCita;
        private System.Windows.Forms.Button btnConHabi;
        private System.Windows.Forms.Button BtnConMedic;
        private System.Windows.Forms.Button BtnConAlt;
        private System.Windows.Forms.Panel PanelProceso;
        private System.Windows.Forms.Button BtnCitaPro;
        private System.Windows.Forms.Button BtnInterpro;
        private System.Windows.Forms.Button BtnAltaPro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton Salir;
        private FontAwesome.Sharp.IconButton BtnReproducir;
        private System.Windows.Forms.Label label3;
    }
}

