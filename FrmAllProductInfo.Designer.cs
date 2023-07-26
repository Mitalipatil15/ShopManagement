namespace ShopManagement
{
    partial class FrmAllProductInfo
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
            this.grdAP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdAP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Products Information";
            // 
            // grdAP
            // 
            this.grdAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAP.Location = new System.Drawing.Point(72, 89);
            this.grdAP.Name = "grdAP";
            this.grdAP.RowHeadersWidth = 51;
            this.grdAP.RowTemplate.Height = 24;
            this.grdAP.Size = new System.Drawing.Size(678, 397);
            this.grdAP.TabIndex = 1;
            this.grdAP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAP_CellContentClick);
            // 
            // FrmAllProductInfo
            // 
            this.ClientSize = new System.Drawing.Size(807, 517);
            this.Controls.Add(this.grdAP);
            this.Controls.Add(this.label1);
            this.Name = "FrmAllProductInfo";
            this.Load += new System.EventHandler(this.FrmAllProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdAP;
    }
}