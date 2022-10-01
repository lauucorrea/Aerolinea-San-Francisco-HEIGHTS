namespace Login
{
    partial class FrmMenuPrincipal
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
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.lstPasajeros = new System.Windows.Forms.ListBox();
            this.btnGestionPasaje = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.lblErrores = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloMenu.AutoSize = true;
            this.lblTituloMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloMenu.Location = new System.Drawing.Point(12, 9);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(167, 32);
            this.lblTituloMenu.TabIndex = 0;
            this.lblTituloMenu.Text = "Bienvenido/a ,";
            this.lblTituloMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstPasajeros
            // 
            this.lstPasajeros.FormattingEnabled = true;
            this.lstPasajeros.ItemHeight = 15;
            this.lstPasajeros.Location = new System.Drawing.Point(12, 65);
            this.lstPasajeros.Name = "lstPasajeros";
            this.lstPasajeros.Size = new System.Drawing.Size(598, 424);
            this.lstPasajeros.TabIndex = 3;
            // 
            // btnGestionPasaje
            // 
            this.btnGestionPasaje.Location = new System.Drawing.Point(655, 65);
            this.btnGestionPasaje.Name = "btnGestionPasaje";
            this.btnGestionPasaje.Size = new System.Drawing.Size(231, 51);
            this.btnGestionPasaje.TabIndex = 5;
            this.btnGestionPasaje.Text = "Gestionar Pasaje";
            this.btnGestionPasaje.UseVisualStyleBackColor = true;
            this.btnGestionPasaje.Click += new System.EventHandler(this.btnGestionPasaje_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(655, 248);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(231, 51);
            this.btnAgregarCliente.TabIndex = 7;
            this.btnAgregarCliente.Text = "Agregar nuevo cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Location = new System.Drawing.Point(655, 152);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(231, 51);
            this.btnVerHistorial.TabIndex = 8;
            this.btnVerHistorial.Text = "Historial de vuelos";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.Location = new System.Drawing.Point(655, 347);
            this.btnAgregarVuelo.Name = "btnAgregarVuelo";
            this.btnAgregarVuelo.Size = new System.Drawing.Size(231, 51);
            this.btnAgregarVuelo.TabIndex = 9;
            this.btnAgregarVuelo.Text = "Agregar vuelos";
            this.btnAgregarVuelo.UseVisualStyleBackColor = true;
            this.btnAgregarVuelo.Click += new System.EventHandler(this.btnAgregarVuelo_Click);
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(390, 549);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(0, 15);
            this.lblErrores.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(443, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 32);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 610);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.btnAgregarVuelo);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnGestionPasaje);
            this.Controls.Add(this.lstPasajeros);
            this.Controls.Add(this.lblTituloMenu);
            this.Name = "FrmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.ListBox lstPasajeros;
        private System.Windows.Forms.Button btnGestionPasaje;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label lblFecha;
    }
}