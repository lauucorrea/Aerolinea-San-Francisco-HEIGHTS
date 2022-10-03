namespace Vista
{
    partial class FrmPasajerosFrecuentes
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
            this.dtgPasajeros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPasajeros
            // 
            this.dtgPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPasajeros.Location = new System.Drawing.Point(12, 12);
            this.dtgPasajeros.Name = "dtgPasajeros";
            this.dtgPasajeros.RowTemplate.Height = 25;
            this.dtgPasajeros.Size = new System.Drawing.Size(578, 422);
            this.dtgPasajeros.TabIndex = 0;
            // 
            // FrmPasajerosFrecuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 447);
            this.Controls.Add(this.dtgPasajeros);
            this.Name = "FrmPasajerosFrecuentes";
            this.Text = "FrmPasajerosFrecuentes";
            this.Load += new System.EventHandler(this.FrmPasajerosFrecuentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPasajeros;
    }
}