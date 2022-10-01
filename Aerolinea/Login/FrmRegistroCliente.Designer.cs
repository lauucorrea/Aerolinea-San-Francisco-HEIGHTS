namespace Login
{
    partial class FrmRegistroPasajero
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
            this.txtNombrePasajero = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numDni = new System.Windows.Forms.NumericUpDown();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.lblErrores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de pasajeros";
            // 
            // txtNombrePasajero
            // 
            this.txtNombrePasajero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombrePasajero.Location = new System.Drawing.Point(123, 92);
            this.txtNombrePasajero.Name = "txtNombrePasajero";
            this.txtNombrePasajero.PlaceholderText = "Nombre";
            this.txtNombrePasajero.Size = new System.Drawing.Size(285, 27);
            this.txtNombrePasajero.TabIndex = 1;
            this.txtNombrePasajero.TextChanged += new System.EventHandler(this.txtNombrePasajero_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(123, 149);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.Size = new System.Drawing.Size(285, 27);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(21, 214);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(86, 15);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Ingrese la edad";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(21, 271);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(68, 15);
            this.lblDni.TabIndex = 7;
            this.lblDni.Text = "Ingrese DNI";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(268, 351);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 46);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(73, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 46);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // numDni
            // 
            this.numDni.Location = new System.Drawing.Point(123, 263);
            this.numDni.Maximum = new decimal(new int[] {
            59999999,
            0,
            0,
            0});
            this.numDni.Name = "numDni";
            this.numDni.Size = new System.Drawing.Size(120, 23);
            this.numDni.TabIndex = 12;
            this.numDni.ValueChanged += new System.EventHandler(this.numDni_ValueChanged);
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(123, 206);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(120, 23);
            this.numEdad.TabIndex = 13;
            this.numEdad.ValueChanged += new System.EventHandler(this.numEdad_ValueChanged);
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(158, 424);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(0, 17);
            this.lblErrores.TabIndex = 11;
            // 
            // FrmRegistroPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.numDni);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombrePasajero);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroPasajero";
            this.Text = "FrmRegistroPasajero";
            this.Load += new System.EventHandler(this.RegistroPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePasajero;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numDni;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label lblErrores;
    }
}