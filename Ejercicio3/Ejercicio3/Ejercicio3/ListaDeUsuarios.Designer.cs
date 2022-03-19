namespace Ejercicio3
{
    partial class ListaDeUsuarios
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
            this.ListadataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadataGrid
            // 
            this.ListadataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadataGrid.Location = new System.Drawing.Point(2, 1);
            this.ListadataGrid.Name = "ListadataGrid";
            this.ListadataGrid.Size = new System.Drawing.Size(532, 150);
            this.ListadataGrid.TabIndex = 0;
            // 
            // ListaDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 152);
            this.Controls.Add(this.ListadataGrid);
            this.Name = "ListaDeUsuarios";
            this.Text = "ListaDeUsuarios";
            this.Load += new System.EventHandler(this.ListaDeUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadataGrid;
    }
}