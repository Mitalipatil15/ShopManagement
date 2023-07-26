namespace ShopManagement
{
    partial class frmSize
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.cmbprd = new System.Windows.Forms.ComboBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txtmrp = new System.Windows.Forms.TextBox();
            this.txtreal = new System.Windows.Forms.TextBox();
            this.btnbooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "M.R.P";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Real Price";
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Men\'s",
            "Women\'s",
            "Kid\'s"});
            this.cmbtype.Location = new System.Drawing.Point(308, 39);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(121, 24);
            this.cmbtype.TabIndex = 5;
            this.cmbtype.SelectedIndexChanged += new System.EventHandler(this.cmbtype_SelectedIndexChanged);
            // 
            // cmbprd
            // 
            this.cmbprd.FormattingEnabled = true;
            this.cmbprd.Location = new System.Drawing.Point(308, 98);
            this.cmbprd.Name = "cmbprd";
            this.cmbprd.Size = new System.Drawing.Size(121, 24);
            this.cmbprd.TabIndex = 6;
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(308, 148);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(121, 22);
            this.txtsize.TabIndex = 7;
            // 
            // txtmrp
            // 
            this.txtmrp.Location = new System.Drawing.Point(308, 197);
            this.txtmrp.Name = "txtmrp";
            this.txtmrp.Size = new System.Drawing.Size(121, 22);
            this.txtmrp.TabIndex = 8;
            // 
            // txtreal
            // 
            this.txtreal.Location = new System.Drawing.Point(308, 251);
            this.txtreal.Name = "txtreal";
            this.txtreal.Size = new System.Drawing.Size(121, 22);
            this.txtreal.TabIndex = 9;
            // 
            // btnbooking
            // 
            this.btnbooking.Location = new System.Drawing.Point(197, 321);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(145, 23);
            this.btnbooking.TabIndex = 10;
            this.btnbooking.Text = "Booking";
            this.btnbooking.UseVisualStyleBackColor = true;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click);
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbooking);
            this.Controls.Add(this.txtreal);
            this.Controls.Add(this.txtmrp);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.cmbprd);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSize";
            this.Text = "frmSize";
            this.Load += new System.EventHandler(this.frmSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.ComboBox cmbprd;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txtmrp;
        private System.Windows.Forms.TextBox txtreal;
        private System.Windows.Forms.Button btnbooking;
    }
}