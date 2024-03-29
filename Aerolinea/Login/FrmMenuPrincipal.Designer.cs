﻿namespace Login
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
            this.btnGestionPasaje = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.lblErrores = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalir = new System.Windows.Forms.Label();
            this.btnAltaAviones = new System.Windows.Forms.Button();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.lblCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
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
            // btnGestionPasaje
            // 
            this.btnGestionPasaje.Location = new System.Drawing.Point(713, 102);
            this.btnGestionPasaje.Name = "btnGestionPasaje";
            this.btnGestionPasaje.Size = new System.Drawing.Size(231, 51);
            this.btnGestionPasaje.TabIndex = 5;
            this.btnGestionPasaje.Text = "Gestionar Pasaje";
            this.btnGestionPasaje.UseVisualStyleBackColor = true;
            this.btnGestionPasaje.Click += new System.EventHandler(this.btnGestionPasaje_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(713, 272);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(231, 51);
            this.btnAgregarCliente.TabIndex = 7;
            this.btnAgregarCliente.Text = "Agregar nuevo cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Location = new System.Drawing.Point(713, 184);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(231, 51);
            this.btnVerHistorial.TabIndex = 8;
            this.btnVerHistorial.Text = "Historial de vuelos";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.Location = new System.Drawing.Point(713, 357);
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
            // lblFechaActual
            // 
            this.lblFechaActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaActual.Location = new System.Drawing.Point(713, 9);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(99, 32);
            this.lblFechaActual.TabIndex = 12;
            this.lblFechaActual.Text = "Hoy es: ";
            this.lblFechaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Vista.Properties.Resources.Sin_título_1;
            this.btnSalir.Location = new System.Drawing.Point(12, 505);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 68);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalir.Location = new System.Drawing.Point(25, 588);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(49, 25);
            this.lblSalir.TabIndex = 34;
            this.lblSalir.Text = "Salir";
            // 
            // btnAltaAviones
            // 
            this.btnAltaAviones.Location = new System.Drawing.Point(713, 438);
            this.btnAltaAviones.Name = "btnAltaAviones";
            this.btnAltaAviones.Size = new System.Drawing.Size(231, 51);
            this.btnAltaAviones.TabIndex = 35;
            this.btnAltaAviones.Text = "Agregar Aviones";
            this.btnAltaAviones.UseVisualStyleBackColor = true;
            this.btnAltaAviones.Click += new System.EventHandler(this.btnAltaAviones_Click);
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgClientes.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgClientes.Location = new System.Drawing.Point(12, 102);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.RowTemplate.Height = 25;
            this.dtgClientes.Size = new System.Drawing.Size(605, 387);
            this.dtgClientes.TabIndex = 36;
            this.dtgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellClick);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.Location = new System.Drawing.Point(12, 52);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 32);
            this.lblCategoria.TabIndex = 37;
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(972, 638);
            this.ControlBox = false;
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.btnAltaAviones);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.btnAgregarVuelo);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnGestionPasaje);
            this.Controls.Add(this.lblTituloMenu);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Button btnGestionPasaje;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Button btnAltaAviones;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Label lblCategoria;
    }
}