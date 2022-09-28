namespace Vista
{
    partial class FrmVentaPasajes
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
            this.lstVuelos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.grpCategoria = new System.Windows.Forms.GroupBox();
            this.rbtCategoriaPremium = new System.Windows.Forms.RadioButton();
            this.rbtCategoriaTurista = new System.Windows.Forms.RadioButton();
            this.lblRecargoPremium = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTextoValorPasaje = new System.Windows.Forms.Label();
            this.grpBolso = new System.Windows.Forms.GroupBox();
            this.rbtBolsoNo = new System.Windows.Forms.RadioButton();
            this.rbtBolsoSi = new System.Windows.Forms.RadioButton();
            this.lblValija1 = new System.Windows.Forms.Label();
            this.cmbValija1 = new System.Windows.Forms.ComboBox();
            this.cmbValija2 = new System.Windows.Forms.ComboBox();
            this.lblValija2 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLimiteValija = new System.Windows.Forms.Label();
            this.lblTituloVentas = new System.Windows.Forms.Label();
            this.grpCategoria.SuspendLayout();
            this.grpBolso.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVuelos
            // 
            this.lstVuelos.FormattingEnabled = true;
            this.lstVuelos.ItemHeight = 15;
            this.lstVuelos.Location = new System.Drawing.Point(12, 108);
            this.lstVuelos.Name = "lstVuelos";
            this.lstVuelos.Size = new System.Drawing.Size(693, 424);
            this.lstVuelos.TabIndex = 0;
            this.lstVuelos.SelectedIndexChanged += new System.EventHandler(this.lstVuelos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de vuelos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(800, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informacion del Pasaje";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(747, 189);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "NOMBRE PASAJERO";
            this.txtNombre.Size = new System.Drawing.Size(149, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(933, 189);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "DNI PASAJERO";
            this.txtDni.Size = new System.Drawing.Size(149, 23);
            this.txtDni.TabIndex = 4;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(747, 260);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(149, 23);
            this.cmbDestino.TabIndex = 5;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestino.Location = new System.Drawing.Point(747, 244);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(107, 13);
            this.lblDestino.TabIndex = 6;
            this.lblDestino.Text = "Seleccionar destino";
            // 
            // grpCategoria
            // 
            this.grpCategoria.Controls.Add(this.rbtCategoriaPremium);
            this.grpCategoria.Controls.Add(this.rbtCategoriaTurista);
            this.grpCategoria.Location = new System.Drawing.Point(933, 244);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Size = new System.Drawing.Size(196, 39);
            this.grpCategoria.TabIndex = 8;
            this.grpCategoria.TabStop = false;
            this.grpCategoria.Text = "Seleccionar categoria";
            // 
            // rbtCategoriaPremium
            // 
            this.rbtCategoriaPremium.AutoSize = true;
            this.rbtCategoriaPremium.Location = new System.Drawing.Point(75, 15);
            this.rbtCategoriaPremium.Name = "rbtCategoriaPremium";
            this.rbtCategoriaPremium.Size = new System.Drawing.Size(74, 19);
            this.rbtCategoriaPremium.TabIndex = 10;
            this.rbtCategoriaPremium.TabStop = true;
            this.rbtCategoriaPremium.Text = "Premium";
            this.rbtCategoriaPremium.UseVisualStyleBackColor = true;
            this.rbtCategoriaPremium.Click += new System.EventHandler(this.rbtCategoriaPremium_Click);
            // 
            // rbtCategoriaTurista
            // 
            this.rbtCategoriaTurista.AutoSize = true;
            this.rbtCategoriaTurista.Location = new System.Drawing.Point(6, 15);
            this.rbtCategoriaTurista.Name = "rbtCategoriaTurista";
            this.rbtCategoriaTurista.Size = new System.Drawing.Size(60, 19);
            this.rbtCategoriaTurista.TabIndex = 9;
            this.rbtCategoriaTurista.TabStop = true;
            this.rbtCategoriaTurista.Text = "Turista";
            this.rbtCategoriaTurista.UseVisualStyleBackColor = true;
            this.rbtCategoriaTurista.CheckedChanged += new System.EventHandler(this.rbtCategoriaTurista_CheckedChanged);
            this.rbtCategoriaTurista.Click += new System.EventHandler(this.rbtCategoriaTurista_Click);
            // 
            // lblRecargoPremium
            // 
            this.lblRecargoPremium.AutoSize = true;
            this.lblRecargoPremium.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecargoPremium.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecargoPremium.Location = new System.Drawing.Point(933, 286);
            this.lblRecargoPremium.Name = "lblRecargoPremium";
            this.lblRecargoPremium.Size = new System.Drawing.Size(196, 13);
            this.lblRecargoPremium.TabIndex = 19;
            this.lblRecargoPremium.Text = "Recargo del +%15 por clase Premium";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(963, 487);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(129, 45);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "180.000";
            // 
            // lblTextoValorPasaje
            // 
            this.lblTextoValorPasaje.AutoSize = true;
            this.lblTextoValorPasaje.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextoValorPasaje.Location = new System.Drawing.Point(730, 493);
            this.lblTextoValorPasaje.Name = "lblTextoValorPasaje";
            this.lblTextoValorPasaje.Size = new System.Drawing.Size(227, 37);
            this.lblTextoValorPasaje.TabIndex = 10;
            this.lblTextoValorPasaje.Text = "Valor del pasaje $";
            // 
            // grpBolso
            // 
            this.grpBolso.Controls.Add(this.rbtBolsoNo);
            this.grpBolso.Controls.Add(this.rbtBolsoSi);
            this.grpBolso.Location = new System.Drawing.Point(747, 381);
            this.grpBolso.Name = "grpBolso";
            this.grpBolso.Size = new System.Drawing.Size(149, 40);
            this.grpBolso.TabIndex = 11;
            this.grpBolso.TabStop = false;
            this.grpBolso.Text = "Lleva bolso?";
            // 
            // rbtBolsoNo
            // 
            this.rbtBolsoNo.AutoSize = true;
            this.rbtBolsoNo.Location = new System.Drawing.Point(75, 15);
            this.rbtBolsoNo.Name = "rbtBolsoNo";
            this.rbtBolsoNo.Size = new System.Drawing.Size(41, 19);
            this.rbtBolsoNo.TabIndex = 10;
            this.rbtBolsoNo.TabStop = true;
            this.rbtBolsoNo.Text = "No";
            this.rbtBolsoNo.UseVisualStyleBackColor = true;
            // 
            // rbtBolsoSi
            // 
            this.rbtBolsoSi.AutoSize = true;
            this.rbtBolsoSi.Location = new System.Drawing.Point(6, 15);
            this.rbtBolsoSi.Name = "rbtBolsoSi";
            this.rbtBolsoSi.Size = new System.Drawing.Size(34, 19);
            this.rbtBolsoSi.TabIndex = 9;
            this.rbtBolsoSi.TabStop = true;
            this.rbtBolsoSi.Text = "Si";
            this.rbtBolsoSi.UseVisualStyleBackColor = true;
            // 
            // lblValija1
            // 
            this.lblValija1.AutoSize = true;
            this.lblValija1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValija1.Location = new System.Drawing.Point(747, 317);
            this.lblValija1.Name = "lblValija1";
            this.lblValija1.Size = new System.Drawing.Size(70, 13);
            this.lblValija1.TabIndex = 12;
            this.lblValija1.Text = "Peso Valija 1";
            // 
            // cmbValija1
            // 
            this.cmbValija1.FormattingEnabled = true;
            this.cmbValija1.Location = new System.Drawing.Point(747, 334);
            this.cmbValija1.Name = "cmbValija1";
            this.cmbValija1.Size = new System.Drawing.Size(149, 23);
            this.cmbValija1.TabIndex = 13;
            // 
            // cmbValija2
            // 
            this.cmbValija2.FormattingEnabled = true;
            this.cmbValija2.Location = new System.Drawing.Point(933, 334);
            this.cmbValija2.Name = "cmbValija2";
            this.cmbValija2.Size = new System.Drawing.Size(149, 23);
            this.cmbValija2.TabIndex = 14;
            // 
            // lblValija2
            // 
            this.lblValija2.AutoSize = true;
            this.lblValija2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValija2.Location = new System.Drawing.Point(933, 317);
            this.lblValija2.Name = "lblValija2";
            this.lblValija2.Size = new System.Drawing.Size(70, 13);
            this.lblValija2.TabIndex = 15;
            this.lblValija2.Text = "Peso Valija 2";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(933, 397);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PlaceholderText = "MATRICULA";
            this.txtMatricula.Size = new System.Drawing.Size(149, 23);
            this.txtMatricula.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(933, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Matricula avion";
            // 
            // lblLimiteValija
            // 
            this.lblLimiteValija.AutoSize = true;
            this.lblLimiteValija.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLimiteValija.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLimiteValija.Location = new System.Drawing.Point(913, 360);
            this.lblLimiteValija.Name = "lblLimiteValija";
            this.lblLimiteValija.Size = new System.Drawing.Size(232, 13);
            this.lblLimiteValija.TabIndex = 18;
            this.lblLimiteValija.Text = "En clase turista solo se puede cargar 1 valija";
            // 
            // lblTituloVentas
            // 
            this.lblTituloVentas.AutoSize = true;
            this.lblTituloVentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloVentas.Location = new System.Drawing.Point(333, 9);
            this.lblTituloVentas.Name = "lblTituloVentas";
            this.lblTituloVentas.Size = new System.Drawing.Size(193, 25);
            this.lblTituloVentas.TabIndex = 20;
            this.lblTituloVentas.Text = "GESTION DE PASAJES";
            // 
            // FrmVentaPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 649);
            this.Controls.Add(this.lblTituloVentas);
            this.Controls.Add(this.lblRecargoPremium);
            this.Controls.Add(this.lblLimiteValija);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblValija2);
            this.Controls.Add(this.cmbValija2);
            this.Controls.Add(this.cmbValija1);
            this.Controls.Add(this.lblValija1);
            this.Controls.Add(this.grpBolso);
            this.Controls.Add(this.lblTextoValorPasaje);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.grpCategoria);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstVuelos);
            this.Name = "FrmVentaPasajes";
            this.Text = "FrmVentaPasajes";
            this.Load += new System.EventHandler(this.FrmVentaPasajes_Load);
            this.grpCategoria.ResumeLayout(false);
            this.grpCategoria.PerformLayout();
            this.grpBolso.ResumeLayout(false);
            this.grpBolso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVuelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.GroupBox grpCategoria;
        private System.Windows.Forms.RadioButton rbtCategoriaPremium;
        private System.Windows.Forms.RadioButton rbtCategoriaTurista;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTextoValorPasaje;
        private System.Windows.Forms.GroupBox grpBolso;
        private System.Windows.Forms.RadioButton rbtBolsoNo;
        private System.Windows.Forms.RadioButton rbtBolsoSi;
        private System.Windows.Forms.Label lblValija1;
        private System.Windows.Forms.ComboBox cmbValija1;
        private System.Windows.Forms.ComboBox cmbValija2;
        private System.Windows.Forms.Label lblValija2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLimiteValija;
        private System.Windows.Forms.Label lblRecargoPremium;
        private System.Windows.Forms.Label lblTituloVentas;
    }
}