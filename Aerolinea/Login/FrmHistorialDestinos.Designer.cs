namespace Vista
{
    partial class FrmHistorialDestinos
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
            this.dtgDestinos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDestinos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDestinos
            // 
            this.dtgDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDestinos.Location = new System.Drawing.Point(12, 12);
            this.dtgDestinos.Name = "dtgDestinos";
            this.dtgDestinos.RowTemplate.Height = 25;
            this.dtgDestinos.Size = new System.Drawing.Size(535, 331);
            this.dtgDestinos.TabIndex = 0;
            this.dtgDestinos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDestinos_CellContentClick);
            // 
            // FrmHistorialDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 407);
            this.Controls.Add(this.dtgDestinos);
            this.Name = "FrmHistorialDestinos";
            this.Text = "FrmHistorialDestinos";
            this.Load += new System.EventHandler(this.FrmHistorialDestinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDestinos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDestinos;
    }
}