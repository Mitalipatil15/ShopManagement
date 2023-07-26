namespace ShopManagement
{
    partial class FrmUnOrderCustomer
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
            this.grdUOC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUOC)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUOC
            // 
            this.grdUOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUOC.Location = new System.Drawing.Point(24, 87);
            this.grdUOC.Name = "grdUOC";
            this.grdUOC.RowHeadersWidth = 51;
            this.grdUOC.RowTemplate.Height = 24;
            this.grdUOC.Size = new System.Drawing.Size(1013, 487);
            this.grdUOC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "UnOrder Customer List";
            // 
            // FrmUnOrderCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdUOC);
            this.Name = "FrmUnOrderCustomer";
            this.Text = "FrmUnOrderCustomer";
            this.Load += new System.EventHandler(this.FrmUnOrderCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUOC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUOC;
        private System.Windows.Forms.Label label1;
    }
}