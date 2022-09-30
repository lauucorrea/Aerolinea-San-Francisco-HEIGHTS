namespace Vista
{
    partial class FrmRegistroVuelo
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
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lstAviones = new System.Windows.Forms.ListBox();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.numHora = new System.Windows.Forms.NumericUpDown();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.lblHorarioVuelo = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarVuelo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblAviones = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Vuelos";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(590, 106);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.PlaceholderText = "Origen del vuelo";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(165, 23);
            this.txtOrigen.TabIndex = 1;
            // 
            // lstAviones
            // 
            this.lstAviones.FormattingEnabled = true;
            this.lstAviones.ItemHeight = 15;
            this.lstAviones.Location = new System.Drawing.Point(12, 89);
            this.lstAviones.Name = "lstAviones";
            this.lstAviones.Size = new System.Drawing.Size(520, 259);
            this.lstAviones.TabIndex = 2;
            this.lstAviones.SelectedIndexChanged += new System.EventHandler(this.lstAviones_SelectedIndexChanged);
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(590, 169);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(165, 23);
            this.cmbDestinos.TabIndex = 3;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestino.Location = new System.Drawing.Point(590, 151);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(98, 15);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Text = "Destino del vuelo";
            // 
            // numHora
            // 
            this.numHora.Location = new System.Drawing.Point(589, 253);
            this.numHora.Name = "numHora";
            this.numHora.Size = new System.Drawing.Size(60, 23);
            this.numHora.TabIndex = 6;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(589, 235);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 15);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinutos.Location = new System.Drawing.Point(694, 235);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(51, 15);
            this.lblMinutos.TabIndex = 9;
            this.lblMinutos.Text = "Minutos";
            // 
            // numMinutos
            // 
            this.numMinutos.Location = new System.Drawing.Point(694, 253);
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(60, 23);
            this.numMinutos.TabIndex = 8;
            // 
            // lblHorarioVuelo
            // 
            this.lblHorarioVuelo.AutoSize = true;
            this.lblHorarioVuelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorarioVuelo.Location = new System.Drawing.Point(617, 209);
            this.lblHorarioVuelo.Name = "lblHorarioVuelo";
            this.lblHorarioVuelo.Size = new System.Drawing.Size(96, 15);
            this.lblHorarioVuelo.TabIndex = 10;
            this.lblHorarioVuelo.Text = "Horario de salida";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(590, 308);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PlaceholderText = "Matricula del avion";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(165, 23);
            this.txtMatricula.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(607, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Detalles del vuelo";
            // 
            // btnCargarVuelo
            // 
            this.btnCargarVuelo.Location = new System.Drawing.Point(629, 396);
            this.btnCargarVuelo.Name = "btnCargarVuelo";
            this.btnCargarVuelo.Size = new System.Drawing.Size(126, 32);
            this.btnCargarVuelo.TabIndex = 13;
            this.btnCargarVuelo.Text = "Cargar Vuelo";
            this.btnCargarVuelo.UseVisualStyleBackColor = true;
            this.btnCargarVuelo.Click += new System.EventHandler(this.btnCargarVuelo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 396);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(126, 32);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // lblAviones
            // 
            this.lblAviones.AutoSize = true;
            this.lblAviones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviones.Location = new System.Drawing.Point(12, 52);
            this.lblAviones.Name = "lblAviones";
            this.lblAviones.Size = new System.Drawing.Size(130, 20);
            this.lblAviones.TabIndex = 15;
            this.lblAviones.Text = "Aviones existentes";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(291, 413);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(38, 15);
            this.lblErrores.TabIndex = 16;
            this.lblErrores.Text = "label2";
            // 
            // FrmRegistroVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lblAviones);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargarVuelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblHorarioVuelo);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.numMinutos);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.numHora);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.cmbDestinos);
            this.Controls.Add(this.lstAviones);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroVuelo";
            this.Text = "FrmRegistroVuelo";
            this.Load += new System.EventHandler(this.FrmRegistroVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.ListBox lstAviones;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.NumericUpDown numHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.NumericUpDown numMinutos;
        private System.Windows.Forms.Label lblHorarioVuelo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargarVuelo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblAviones;
        private System.Windows.Forms.Label lblErrores;
    }
}