namespace Vista
{
    partial class FrmHistorial
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
            this.btnVerRecaudacion = new System.Windows.Forms.Button();
            this.btnPasajerosPorVuelo = new System.Windows.Forms.Button();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.btnAviones = new System.Windows.Forms.Button();
            this.rchMuestreo = new System.Windows.Forms.RichTextBox();
            this.PasajerosFrecuentes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalir = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerRecaudacion
            // 
            this.btnVerRecaudacion.Location = new System.Drawing.Point(924, 64);
            this.btnVerRecaudacion.Name = "btnVerRecaudacion";
            this.btnVerRecaudacion.Size = new System.Drawing.Size(129, 41);
            this.btnVerRecaudacion.TabIndex = 1;
            this.btnVerRecaudacion.Text = "Recaudacion";
            this.btnVerRecaudacion.UseVisualStyleBackColor = true;
            this.btnVerRecaudacion.Click += new System.EventHandler(this.btnVerRecaudacion_Click);
            // 
            // btnPasajerosPorVuelo
            // 
            this.btnPasajerosPorVuelo.Location = new System.Drawing.Point(924, 148);
            this.btnPasajerosPorVuelo.Name = "btnPasajerosPorVuelo";
            this.btnPasajerosPorVuelo.Size = new System.Drawing.Size(129, 41);
            this.btnPasajerosPorVuelo.TabIndex = 2;
            this.btnPasajerosPorVuelo.Text = "Pasajeros por vuelo";
            this.btnPasajerosPorVuelo.UseVisualStyleBackColor = true;
            this.btnPasajerosPorVuelo.Click += new System.EventHandler(this.btnPasajerosPorVuelo_Click);
            // 
            // btnDestinos
            // 
            this.btnDestinos.Location = new System.Drawing.Point(924, 296);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(129, 41);
            this.btnDestinos.TabIndex = 3;
            this.btnDestinos.Text = "Destinos por facturacion";
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // btnAviones
            // 
            this.btnAviones.Location = new System.Drawing.Point(924, 377);
            this.btnAviones.Name = "btnAviones";
            this.btnAviones.Size = new System.Drawing.Size(129, 41);
            this.btnAviones.TabIndex = 5;
            this.btnAviones.Text = "Historial aviones";
            this.btnAviones.UseVisualStyleBackColor = true;
            this.btnAviones.Click += new System.EventHandler(this.btnAviones_Click);
            // 
            // rchMuestreo
            // 
            this.rchMuestreo.Location = new System.Drawing.Point(12, 25);
            this.rchMuestreo.Name = "rchMuestreo";
            this.rchMuestreo.Size = new System.Drawing.Size(890, 442);
            this.rchMuestreo.TabIndex = 7;
            this.rchMuestreo.Text = "";
            // 
            // PasajerosFrecuentes
            // 
            this.PasajerosFrecuentes.Location = new System.Drawing.Point(924, 219);
            this.PasajerosFrecuentes.Name = "PasajerosFrecuentes";
            this.PasajerosFrecuentes.Size = new System.Drawing.Size(129, 41);
            this.PasajerosFrecuentes.TabIndex = 8;
            this.PasajerosFrecuentes.Text = "Pasajeros mas frecuentes";
            this.PasajerosFrecuentes.UseVisualStyleBackColor = true;
            this.PasajerosFrecuentes.Click += new System.EventHandler(this.PasajerosFrecuentes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Vista.Properties.Resources.Sin_título_1;
            this.btnSalir.Location = new System.Drawing.Point(28, 495);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 68);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalir.Location = new System.Drawing.Point(41, 566);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(49, 25);
            this.lblSalir.TabIndex = 33;
            this.lblSalir.Text = "Salir";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(149, 522);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 41);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 607);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.PasajerosFrecuentes);
            this.Controls.Add(this.rchMuestreo);
            this.Controls.Add(this.btnAviones);
            this.Controls.Add(this.btnDestinos);
            this.Controls.Add(this.btnPasajerosPorVuelo);
            this.Controls.Add(this.btnVerRecaudacion);
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistorial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerRecaudacion;
        private System.Windows.Forms.Button btnPasajerosPorVuelo;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Button btnAviones;
        private System.Windows.Forms.RichTextBox rchMuestreo;
        private System.Windows.Forms.Button PasajerosFrecuentes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Button btnVolver;
    }
}