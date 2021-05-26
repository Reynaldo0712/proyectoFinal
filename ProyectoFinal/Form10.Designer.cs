namespace ProyectoFinal
{
    partial class Form10
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brnNombre = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lab3 = new System.Windows.Forms.Label();
            this.Labelfecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.brnNombre);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Lab3);
            this.panel1.Controls.Add(this.Labelfecha);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 513);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(770, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 339);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.pngocean2;
            this.pictureBox1.Location = new System.Drawing.Point(58, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 301);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // brnNombre
            // 
            this.brnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnNombre.Location = new System.Drawing.Point(3, 119);
            this.brnNombre.Name = "brnNombre";
            this.brnNombre.Size = new System.Drawing.Size(163, 64);
            this.brnNombre.TabIndex = 11;
            this.brnNombre.Text = "Filtrar por\r\nnombre\r\n";
            this.brnNombre.UseVisualStyleBackColor = true;
            this.brnNombre.Click += new System.EventHandler(this.brnNombre_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(501, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 27);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(437, 445);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(261, 31);
            this.txtNom.TabIndex = 9;
            this.txtNom.Visible = false;
            this.txtNom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1060, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(3, 223);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(163, 64);
            this.fecha.TabIndex = 6;
            this.fecha.Text = "Filtrar por\r\nfecha";
            this.fecha.UseVisualStyleBackColor = true;
            this.fecha.Click += new System.EventHandler(this.fecha_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(222, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(529, 153);
            this.dataGridView1.TabIndex = 5;
            // 
            // Lab3
            // 
            this.Lab3.AutoSize = true;
            this.Lab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lab3.Location = new System.Drawing.Point(141, 442);
            this.Lab3.Name = "Lab3";
            this.Lab3.Size = new System.Drawing.Size(254, 32);
            this.Lab3.TabIndex = 2;
            this.Lab3.Text = " paciente a buscar:";
            this.Lab3.Visible = false;
            // 
            // Labelfecha
            // 
            this.Labelfecha.AutoSize = true;
            this.Labelfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelfecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Labelfecha.Location = new System.Drawing.Point(216, 124);
            this.Labelfecha.Name = "Labelfecha";
            this.Labelfecha.Size = new System.Drawing.Size(263, 32);
            this.Labelfecha.TabIndex = 1;
            this.Labelfecha.Text = "Seleccione la fecha";
            this.Labelfecha.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 86);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 138);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a la opcion consultar alta medica\r\n\r\n\r\n";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 513);
            this.Controls.Add(this.panel1);
            this.Name = "Form10";
            this.Text = "Consultar alta medica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button fecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lab3;
        private System.Windows.Forms.Label Labelfecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button brnNombre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}