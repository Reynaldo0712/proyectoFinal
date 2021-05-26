namespace ProyectoFinal
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.Btnvolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnvolver
            // 
            this.Btnvolver.Location = new System.Drawing.Point(1037, 433);
            this.Btnvolver.Name = "Btnvolver";
            this.Btnvolver.Size = new System.Drawing.Size(126, 48);
            this.Btnvolver.TabIndex = 0;
            this.Btnvolver.Text = "Volver";
            this.Btnvolver.UseVisualStyleBackColor = true;
            this.Btnvolver.Click += new System.EventHandler(this.Btnvolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.axShockwaveFlash1);
            this.panel1.Controls.Add(this.Btnvolver);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 737);
            this.panel1.TabIndex = 1;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(306, 207);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(556, 333);
            this.axShockwaveFlash1.TabIndex = 1;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1200, 737);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.Location = new System.Drawing.Point(306, 93);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(1, 1);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 737);
            this.Controls.Add(this.panel1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnvolver;
        private System.Windows.Forms.Panel panel1;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
    }
}