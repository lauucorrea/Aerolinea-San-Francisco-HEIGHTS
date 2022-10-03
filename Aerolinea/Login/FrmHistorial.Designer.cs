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
            this.btnGanancias = new System.Windows.Forms.Button();
            this.btnAviones = new System.Windows.Forms.Button();
            this.rchMuestreo = new System.Windows.Forms.RichTextBox();
            this.PasajerosFrecuentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerRecaudacion
            // 
            this.btnVerRecaudacion.Location = new System.Drawing.Point(925, 48);
            this.btnVerRecaudacion.Name = "btnVerRecaudacion";
            this.btnVerRecaudacion.Size = new System.Drawing.Size(129, 41);
            this.btnVerRecaudacion.TabIndex = 1;
            this.btnVerRecaudacion.Text = "Recaudacion";
            this.btnVerRecaudacion.UseVisualStyleBackColor = true;
            this.btnVerRecaudacion.Click += new System.EventHandler(this.btnVerRecaudacion_Click);
            // 
            // btnPasajerosPorVuelo
            // 
            this.btnPasajerosPorVuelo.Location = new System.Drawing.Point(925, 132);
            this.btnPasajerosPorVuelo.Name = "btnPasajerosPorVuelo";
            this.btnPasajerosPorVuelo.Size = new System.Drawing.Size(129, 41);
            this.btnPasajerosPorVuelo.TabIndex = 2;
            this.btnPasajerosPorVuelo.Text = "Pasajeros por vuelo";
            this.btnPasajerosPorVuelo.UseVisualStyleBackColor = true;
            this.btnPasajerosPorVuelo.Click += new System.EventHandler(this.btnPasajerosPorVuelo_Click);
            // 
            // btnDestinos
            // 
            this.btnDestinos.Location = new System.Drawing.Point(925, 280);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(129, 41);
            this.btnDestinos.TabIndex = 3;
            this.btnDestinos.Text = "Destinos por facturacion";
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.Location = new System.Drawing.Point(925, 362);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(129, 41);
            this.btnGanancias.TabIndex = 4;
            this.btnGanancias.Text = "Ganancias y especificaciones";
            this.btnGanancias.UseVisualStyleBackColor = true;
            // 
            // btnAviones
            // 
            this.btnAviones.Location = new System.Drawing.Point(925, 455);
            this.btnAviones.Name = "btnAviones";
            this.btnAviones.Size = new System.Drawing.Size(129, 41);
            this.btnAviones.TabIndex = 5;
            this.btnAviones.Text = "Historial aviones";
            this.btnAviones.UseVisualStyleBackColor = true;
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
            this.PasajerosFrecuentes.Location = new System.Drawing.Point(925, 203);
            this.PasajerosFrecuentes.Name = "PasajerosFrecuentes";
            this.PasajerosFrecuentes.Size = new System.Drawing.Size(129, 41);
            this.PasajerosFrecuentes.TabIndex = 8;
            this.PasajerosFrecuentes.Text = "Pasajeros mas frecuentes";
            this.PasajerosFrecuentes.UseVisualStyleBackColor = true;
            this.PasajerosFrecuentes.Click += new System.EventHandler(this.PasajerosFrecuentes_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 564);
            this.Controls.Add(this.PasajerosFrecuentes);
            this.Controls.Add(this.rchMuestreo);
            this.Controls.Add(this.btnAviones);
            this.Controls.Add(this.btnGanancias);
            this.Controls.Add(this.btnDestinos);
            this.Controls.Add(this.btnPasajerosPorVuelo);
            this.Controls.Add(this.btnVerRecaudacion);
            this.Name = "FrmHistorial";
            this.Text = "FrmHistorial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVerRecaudacion;
        private System.Windows.Forms.Button btnPasajerosPorVuelo;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Button btnGanancias;
        private System.Windows.Forms.Button btnAviones;
        private System.Windows.Forms.RichTextBox rchMuestreo;
        private System.Windows.Forms.Button PasajerosFrecuentes;
    }
}