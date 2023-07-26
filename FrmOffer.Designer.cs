namespace ShopManagement
{
    partial class FrmOffer
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
            this.gbxoffer = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.btncp = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNM = new System.Windows.Forms.Label();
            this.gbxoffer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offer Form";
            // 
            // gbxoffer
            // 
            this.gbxoffer.Controls.Add(this.lblName);
            this.gbxoffer.Controls.Add(this.lblprice);
            this.gbxoffer.Controls.Add(this.btncp);
            this.gbxoffer.Controls.Add(this.btnup);
            this.gbxoffer.Controls.Add(this.label9);
            this.gbxoffer.Controls.Add(this.txtNP);
            this.gbxoffer.Controls.Add(this.label8);
            this.gbxoffer.Controls.Add(this.label7);
            this.gbxoffer.Controls.Add(this.txtDP);
            this.gbxoffer.Controls.Add(this.label6);
            this.gbxoffer.Controls.Add(this.label5);
            this.gbxoffer.Controls.Add(this.label4);
            this.gbxoffer.Controls.Add(this.label3);
            this.gbxoffer.Controls.Add(this.label2);
            this.gbxoffer.Location = new System.Drawing.Point(83, 133);
            this.gbxoffer.Name = "gbxoffer";
            this.gbxoffer.Size = new System.Drawing.Size(896, 421);
            this.gbxoffer.TabIndex = 1;
            this.gbxoffer.TabStop = false;
            this.gbxoffer.Text = "Offer Information";
            this.gbxoffer.Enter += new System.EventHandler(this.gbxoffer_Enter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(222, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 16);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "label10";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(509, 64);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(51, 16);
            this.lblprice.TabIndex = 13;
            this.lblprice.Text = "label11";
            // 
            // btncp
            // 
            this.btncp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncp.Location = new System.Drawing.Point(455, 307);
            this.btncp.Name = "btncp";
            this.btncp.Size = new System.Drawing.Size(275, 32);
            this.btncp.TabIndex = 11;
            this.btncp.Text = "Calculated New Price";
            this.btncp.UseVisualStyleBackColor = true;
            this.btncp.Click += new System.EventHandler(this.btncp_Click);
            // 
            // btnup
            // 
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Location = new System.Drawing.Point(137, 307);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(236, 32);
            this.btnup.TabIndex = 10;
            this.btnup.Text = "Updated Price";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Rs";
            // 
            // txtNP
            // 
            this.txtNP.Location = new System.Drawing.Point(487, 188);
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(100, 22);
            this.txtNP.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "New Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "%";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(487, 121);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(100, 22);
            this.txtDP.TabIndex = 5;
            this.txtDP.TextChanged += new System.EventHandler(this.txtDP_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Discount in Percentage";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Original Price Of";
            // 
            // lblNM
            // 
            this.lblNM.AutoSize = true;
            this.lblNM.Location = new System.Drawing.Point(719, 114);
            this.lblNM.Name = "lblNM";
            this.lblNM.Size = new System.Drawing.Size(44, 16);
            this.lblNM.TabIndex = 2;
            this.lblNM.Text = "Name";
            // 
            // FrmOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 610);
            this.Controls.Add(this.lblNM);
            this.Controls.Add(this.gbxoffer);
            this.Controls.Add(this.label1);
            this.Name = "FrmOffer";
            this.Text = "FrmOffer";
            this.Load += new System.EventHandler(this.FrmOffer_Load);
            this.gbxoffer.ResumeLayout(false);
            this.gbxoffer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxoffer;
        private System.Windows.Forms.Button btncp;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNM;
    }
}