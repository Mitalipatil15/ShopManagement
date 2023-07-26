namespace ShopManagement
{
    partial class frmProductName
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.txtprd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Men",
            "Women",
            "Kid"});
            this.cmbtype.Location = new System.Drawing.Point(399, 92);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(121, 24);
            this.cmbtype.TabIndex = 2;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(249, 256);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(107, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(412, 256);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(116, 23);
            this.btnclr.TabIndex = 5;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            // 
            // txtprd
            // 
            this.txtprd.Location = new System.Drawing.Point(399, 150);
            this.txtprd.Name = "txtprd";
            this.txtprd.Size = new System.Drawing.Size(121, 22);
            this.txtprd.TabIndex = 6;
            // 
            // frmProductName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtprd);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProductName";
            this.Text = "frmProductDetails";
            this.Load += new System.EventHandler(this.frmProductName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.TextBox txtprd;
    }
}