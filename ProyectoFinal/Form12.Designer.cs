namespace ProyectoFinal
{
    partial class Form12
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
            this.comboNombre = new System.Windows.Forms.ComboBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboHabi = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridHabi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.comboNombre);
            this.panel1.Controls.Add(this.Guardar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dateFecha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboHabi);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridHabi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 513);
            this.panel1.TabIndex = 2;
            // 
            // comboNombre
            // 
            this.comboNombre.FormattingEnabled = true;
            this.comboNombre.Items.AddRange(new object[] {
            "Doble",
            "privada",
            "Suite"});
            this.comboNombre.Location = new System.Drawing.Point(344, 167);
            this.comboNombre.Name = "comboNombre";
            this.comboNombre.Size = new System.Drawing.Size(261, 24);
            this.comboNombre.TabIndex = 21;
            this.comboNombre.SelectedIndexChanged += new System.EventHandler(this.comboNombre_SelectedIndexChanged);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(489, 340);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(116, 46);
            this.Guardar.TabIndex = 6;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ingrese el Id:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(344, 274);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(261, 31);
            this.txtId.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(645, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 406);
            this.panel4.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.pngocean_com__4_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 387);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.BtnEliminar);
            this.panel3.Controls.Add(this.BtnActualizar);
            this.panel3.Location = new System.Drawing.Point(988, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 265);
            this.panel3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(52, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Opciones";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(57, 120);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(116, 46);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(57, 54);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(116, 46);
            this.BtnActualizar.TabIndex = 14;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = " MM/DD/YYYY";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(344, 114);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(261, 22);
            this.dateFecha.TabIndex = 13;
            this.dateFecha.Value = new System.DateTime(2020, 3, 31, 21, 42, 24, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ingrese el nombre:";
            // 
            // comboHabi
            // 
            this.comboHabi.FormattingEnabled = true;
            this.comboHabi.Items.AddRange(new object[] {
            "Doble",
            "privada",
            "Suite"});
            this.comboHabi.Location = new System.Drawing.Point(344, 226);
            this.comboHabi.Name = "comboHabi";
            this.comboHabi.Size = new System.Drawing.Size(261, 24);
            this.comboHabi.TabIndex = 10;
            this.comboHabi.SelectedIndexChanged += new System.EventHandler(this.comboHabi_SelectedIndexChanged);
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
            // dataGridHabi
            // 
            this.dataGridHabi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHabi.Location = new System.Drawing.Point(40, 359);
            this.dataGridHabi.Name = "dataGridHabi";
            this.dataGridHabi.RowHeadersWidth = 51;
            this.dataGridHabi.RowTemplate.Height = 24;
            this.dataGridHabi.Size = new System.Drawing.Size(350, 132);
            this.dataGridHabi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de habitacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la fecha:";
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
            this.label1.Size = new System.Drawing.Size(752, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a la opcion procesar ingresos\r\n\r\n";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 513);
            this.Controls.Add(this.panel1);
            this.Name = "Form12";
            this.Text = "Procesar Ingresos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboHabi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DataGridView dataGridHabi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox comboNombre;
    }
}