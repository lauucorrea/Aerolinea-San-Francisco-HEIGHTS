﻿namespace Vista
{
    partial class FrmAltaAviones
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
            this.rchListaAviones = new System.Windows.Forms.RichTextBox();
            this.grpBolso = new System.Windows.Forms.GroupBox();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtSi = new System.Windows.Forms.RadioButton();
            this.numToilets = new System.Windows.Forms.NumericUpDown();
            this.numBodega = new System.Windows.Forms.NumericUpDown();
            this.numAsientos = new System.Windows.Forms.NumericUpDown();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.lblToilets = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCargarAvion = new System.Windows.Forms.Button();
            this.lblErrores = new System.Windows.Forms.Label();
            this.grpBolso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToilets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // rchListaAviones
            // 
            this.rchListaAviones.Location = new System.Drawing.Point(12, 65);
            this.rchListaAviones.Name = "rchListaAviones";
            this.rchListaAviones.Size = new System.Drawing.Size(539, 283);
            this.rchListaAviones.TabIndex = 0;
            this.rchListaAviones.Text = "";
            // 
            // grpBolso
            // 
            this.grpBolso.Controls.Add(this.rbtNo);
            this.grpBolso.Controls.Add(this.rbtSi);
            this.grpBolso.Location = new System.Drawing.Point(594, 98);
            this.grpBolso.Name = "grpBolso";
            this.grpBolso.Size = new System.Drawing.Size(149, 39);
            this.grpBolso.TabIndex = 12;
            this.grpBolso.TabStop = false;
            this.grpBolso.Text = "Ofrece Comida?";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(75, 15);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(41, 19);
            this.rbtNo.TabIndex = 10;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            this.rbtSi.AutoSize = true;
            this.rbtSi.Location = new System.Drawing.Point(6, 15);
            this.rbtSi.Name = "rbtSi";
            this.rbtSi.Size = new System.Drawing.Size(34, 19);
            this.rbtSi.TabIndex = 9;
            this.rbtSi.TabStop = true;
            this.rbtSi.Text = "Si";
            this.rbtSi.UseVisualStyleBackColor = true;
            // 
            // numToilets
            // 
            this.numToilets.Location = new System.Drawing.Point(701, 157);
            this.numToilets.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numToilets.Name = "numToilets";
            this.numToilets.Size = new System.Drawing.Size(82, 23);
            this.numToilets.TabIndex = 11;
            // 
            // numBodega
            // 
            this.numBodega.Location = new System.Drawing.Point(701, 206);
            this.numBodega.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numBodega.Name = "numBodega";
            this.numBodega.Size = new System.Drawing.Size(82, 23);
            this.numBodega.TabIndex = 13;
            // 
            // numAsientos
            // 
            this.numAsientos.Location = new System.Drawing.Point(701, 244);
            this.numAsientos.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numAsientos.Name = "numAsientos";
            this.numAsientos.Size = new System.Drawing.Size(82, 23);
            this.numAsientos.TabIndex = 14;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(594, 290);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PlaceholderText = "Matricula avion";
            this.txtMatricula.Size = new System.Drawing.Size(160, 23);
            this.txtMatricula.TabIndex = 15;
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(561, 252);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(90, 15);
            this.lblAsientos.TabIndex = 16;
            this.lblAsientos.Text = "Asientos totales";
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Location = new System.Drawing.Point(561, 208);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(134, 15);
            this.lblBodega.TabIndex = 17;
            this.lblBodega.Text = "Capacidad  bodega (Kg)";
            // 
            // lblToilets
            // 
            this.lblToilets.AutoSize = true;
            this.lblToilets.Location = new System.Drawing.Point(561, 159);
            this.lblToilets.Name = "lblToilets";
            this.lblToilets.Size = new System.Drawing.Size(103, 15);
            this.lblToilets.TabIndex = 18;
            this.lblToilets.Text = "Toilets disponibles";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(309, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 32);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Alta Aviones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Vista.Properties.Resources.Sin_título_1;
            this.btnSalir.Location = new System.Drawing.Point(12, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 69);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(231, 385);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(145, 38);
            this.btnVolver.TabIndex = 36;
            this.btnVolver.Text = "Cancelar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCargarAvion
            // 
            this.btnCargarAvion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarAvion.Location = new System.Drawing.Point(431, 385);
            this.btnCargarAvion.Name = "btnCargarAvion";
            this.btnCargarAvion.Size = new System.Drawing.Size(145, 38);
            this.btnCargarAvion.TabIndex = 35;
            this.btnCargarAvion.Text = "Cargar Vuelo";
            this.btnCargarAvion.UseVisualStyleBackColor = true;
            this.btnCargarAvion.Click += new System.EventHandler(this.btnCargarAvion_Click);
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Location = new System.Drawing.Point(431, 438);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(0, 15);
            this.lblErrores.TabIndex = 37;
            // 
            // FrmAltaAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargarAvion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblToilets);
            this.Controls.Add(this.lblBodega);
            this.Controls.Add(this.lblAsientos);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.numAsientos);
            this.Controls.Add(this.numBodega);
            this.Controls.Add(this.numToilets);
            this.Controls.Add(this.grpBolso);
            this.Controls.Add(this.rchListaAviones);
            this.Name = "FrmAltaAviones";
            this.Text = "FrmAltaAviones";
            this.Load += new System.EventHandler(this.FrmAltaAviones_Load);
            this.grpBolso.ResumeLayout(false);
            this.grpBolso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToilets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchListaAviones;
        private System.Windows.Forms.GroupBox grpBolso;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtSi;
        private System.Windows.Forms.NumericUpDown numToilets;
        private System.Windows.Forms.NumericUpDown numBodega;
        private System.Windows.Forms.NumericUpDown numAsientos;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Label lblToilets;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCargarAvion;
        private System.Windows.Forms.Label lblErrores;
    }
}