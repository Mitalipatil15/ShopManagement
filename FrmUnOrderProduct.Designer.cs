namespace ShopManagement
{
    partial class FrmUnOrderProduct
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
            this.grdUOP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUOP)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUOP
            // 
            this.grdUOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUOP.Location = new System.Drawing.Point(12, 99);
            this.grdUOP.Name = "grdUOP";
            this.grdUOP.RowHeadersWidth = 51;
            this.grdUOP.RowTemplate.Height = 24;
            this.grdUOP.Size = new System.Drawing.Size(1049, 465);
            this.grdUOP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "UnOrder Product List";
            // 
            // FrmUnOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdUOP);
            this.Name = "FrmUnOrderProduct";
            this.Text = "FrmUnOrderProduct";
            this.Load += new System.EventHandler(this.FrmUnOrderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUOP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUOP;
        private System.Windows.Forms.Label label1;
    }
}