namespace ProyectoFinal
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAse = new System.Windows.Forms.Label();
            this.txtAseg = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.TxtCed = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.LbNom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.lbAse);
            this.panel1.Controls.Add(this.txtAseg);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.dataGridPacientes);
            this.panel1.Controls.Add(this.TxtCed);
            this.panel1.Controls.Add(this.TxtNom);
            this.panel1.Controls.Add(this.LbNom);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 513);
            this.panel1.TabIndex = 0;
            // 
            // lbAse
            // 
            this.lbAse.AutoSize = true;
            this.lbAse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAse.Location = new System.Drawing.Point(374, 434);
            this.lbAse.Name = "lbAse";
            this.lbAse.Size = new System.Drawing.Size(174, 40);
            this.lbAse.TabIndex = 21;
            this.lbAse.Text = "Nota para asegurados\r\nsolo ponga Si o NO\r\n";
            this.lbAse.Visible = false;
            // 
            // txtAseg
            // 
            this.txtAseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAseg.Location = new System.Drawing.Point(368, 386);
            this.txtAseg.Multiline = true;
            this.txtAseg.Name = "txtAseg";
            this.txtAseg.Size = new System.Drawing.Size(186, 32);
            this.txtAseg.TabIndex = 20;
            this.txtAseg.Visible = false;
            this.txtAseg.WordWrap = false;
            this.txtAseg.TextChanged += new System.EventHandler(this.txtAseg_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(34, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 44);
            this.button3.TabIndex = 19;
            this.button3.Text = "Filtar por Asegurados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Seleccione una opcion";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(715, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 363);
            this.panel3.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(34, 128);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(140, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Filtrar Nombre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(34, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Filtar por cedula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVolver.BackColor = System.Drawing.Color.White;
            this.BtnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BtnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.Location = new System.Drawing.Point(1048, 461);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(127, 40);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(251, 209);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.RowHeadersWidth = 51;
            this.dataGridPacientes.RowTemplate.Height = 24;
            this.dataGridPacientes.Size = new System.Drawing.Size(436, 135);
            this.dataGridPacientes.TabIndex = 7;
            // 
            // TxtCed
            // 
            this.TxtCed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCed.Location = new System.Drawing.Point(368, 386);
            this.TxtCed.Multiline = true;
            this.TxtCed.Name = "TxtCed";
            this.TxtCed.Size = new System.Drawing.Size(186, 32);
            this.TxtCed.TabIndex = 6;
            this.TxtCed.Visible = false;
            this.TxtCed.WordWrap = false;
            this.TxtCed.TextChanged += new System.EventHandler(this.TxtCed_TextChanged);
            // 
            // TxtNom
            // 
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(368, 386);
            this.TxtNom.Multiline = true;
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(186, 32);
            this.TxtNom.TabIndex = 4;
            this.TxtNom.Visible = false;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // LbNom
            // 
            this.LbNom.AutoSize = true;
            this.LbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LbNom.Location = new System.Drawing.Point(104, 389);
            this.LbNom.Name = "LbNom";
            this.LbNom.Size = new System.Drawing.Size(215, 50);
            this.LbNom.TabIndex = 1;
            this.LbNom.Text = "Ingrese el dato  buscar:\r\n\r\n";
            this.LbNom.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 63);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a consulta de pacientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.toppng_com_lupa_muñeco_png_research_icon_3d_338x367;
            this.pictureBox1.Location = new System.Drawing.Point(14, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 324);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 513);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Consulta de pacientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtCed;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label LbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVolver;
        public System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtAseg;
        private System.Windows.Forms.Label lbAse;
    }
}