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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgAviones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Vuelos";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(681, 107);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.PlaceholderText = "Origen del vuelo";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.Size = new System.Drawing.Size(165, 23);
            this.txtOrigen.TabIndex = 1;
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(681, 170);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(165, 23);
            this.cmbDestinos.TabIndex = 3;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestino.Location = new System.Drawing.Point(681, 152);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(98, 15);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Text = "Destino del vuelo";
            // 
            // numHora
            // 
            this.numHora.Location = new System.Drawing.Point(680, 254);
            this.numHora.Name = "numHora";
            this.numHora.Size = new System.Drawing.Size(60, 23);
            this.numHora.TabIndex = 6;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(680, 236);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 15);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinutos.Location = new System.Drawing.Point(785, 236);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(51, 15);
            this.lblMinutos.TabIndex = 9;
            this.lblMinutos.Text = "Minutos";
            // 
            // numMinutos
            // 
            this.numMinutos.Location = new System.Drawing.Point(785, 254);
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(60, 23);
            this.numMinutos.TabIndex = 8;
            // 
            // lblHorarioVuelo
            // 
            this.lblHorarioVuelo.AutoSize = true;
            this.lblHorarioVuelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorarioVuelo.Location = new System.Drawing.Point(708, 210);
            this.lblHorarioVuelo.Name = "lblHorarioVuelo";
            this.lblHorarioVuelo.Size = new System.Drawing.Size(96, 15);
            this.lblHorarioVuelo.TabIndex = 10;
            this.lblHorarioVuelo.Text = "Horario de salida";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(681, 309);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PlaceholderText = "Matricula del avion";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(165, 23);
            this.txtMatricula.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(681, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Detalles del vuelo";
            // 
            // btnCargarVuelo
            // 
            this.btnCargarVuelo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarVuelo.Location = new System.Drawing.Point(477, 443);
            this.btnCargarVuelo.Name = "btnCargarVuelo";
            this.btnCargarVuelo.Size = new System.Drawing.Size(145, 38);
            this.btnCargarVuelo.TabIndex = 13;
            this.btnCargarVuelo.Text = "Cargar Vuelo";
            this.btnCargarVuelo.UseVisualStyleBackColor = true;
            this.btnCargarVuelo.Click += new System.EventHandler(this.btnCargarVuelo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(277, 443);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(145, 38);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblAviones
            // 
            this.lblAviones.AutoSize = true;
            this.lblAviones.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviones.Location = new System.Drawing.Point(12, 52);
            this.lblAviones.Name = "lblAviones";
            this.lblAviones.Size = new System.Drawing.Size(184, 30);
            this.lblAviones.TabIndex = 15;
            this.lblAviones.Text = "Aviones existentes";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(681, 466);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(0, 15);
            this.lblErrores.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Vista.Properties.Resources.Sin_título_1;
            this.btnSalir.Location = new System.Drawing.Point(12, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 69);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 30);
            this.label2.TabIndex = 32;
            this.label2.Text = "Salir";
            // 
            // dtgAviones
            // 
            this.dtgAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAviones.Location = new System.Drawing.Point(12, 101);
            this.dtgAviones.Name = "dtgAviones";
            this.dtgAviones.RowTemplate.Height = 25;
            this.dtgAviones.Size = new System.Drawing.Size(610, 295);
            this.dtgAviones.TabIndex = 33;
            this.dtgAviones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAviones_CellClick);
            // 
            // FrmRegistroVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 524);
            this.ControlBox = false;
            this.Controls.Add(this.dtgAviones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
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
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistroVuelo";
            this.Load += new System.EventHandler(this.FrmRegistroVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigen;
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
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgAviones;
    }
}