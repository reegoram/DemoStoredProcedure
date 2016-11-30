namespace DemoStoredProcedure
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(181, 6);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(262, 30);
            this.cmbLibros.TabIndex = 2;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(181, 42);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(262, 30);
            this.cmbUsuarios.TabIndex = 3;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Location = new System.Drawing.Point(332, 78);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(111, 37);
            this.btnPrestamo.TabIndex = 4;
            this.btnPrestamo.Text = "Préstamo";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 133);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.cmbLibros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamo de Libros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Button btnPrestamo;
    }
}

