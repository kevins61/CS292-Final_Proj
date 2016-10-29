namespace TelephoneNumberManager
{
    partial class AddTelephoneNumbers
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAreaCode = new System.Windows.Forms.TextBox();
            this.txtDidNumber = new System.Windows.Forms.TextBox();
            this.txtQtyOfDids = new System.Windows.Forms.TextBox();
            this.cboSite = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Site:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity:";
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Location = new System.Drawing.Point(120, 87);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(100, 22);
            this.txtAreaCode.TabIndex = 1;
            // 
            // txtDidNumber
            // 
            this.txtDidNumber.Location = new System.Drawing.Point(120, 121);
            this.txtDidNumber.Name = "txtDidNumber";
            this.txtDidNumber.Size = new System.Drawing.Size(119, 22);
            this.txtDidNumber.TabIndex = 2;
            // 
            // txtQtyOfDids
            // 
            this.txtQtyOfDids.Location = new System.Drawing.Point(120, 155);
            this.txtQtyOfDids.Name = "txtQtyOfDids";
            this.txtQtyOfDids.Size = new System.Drawing.Size(73, 22);
            this.txtQtyOfDids.TabIndex = 3;
            // 
            // cboSite
            // 
            this.cboSite.Location = new System.Drawing.Point(120, 21);
            this.cboSite.MaxDropDownItems = 11;
            this.cboSite.Name = "cboSite";
            this.cboSite.Size = new System.Drawing.Size(121, 24);
            this.cboSite.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Country Code:";
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountryCode.Location = new System.Drawing.Point(120, 56);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(77, 23);
            this.lblCountryCode.TabIndex = 1;
            this.lblCountryCode.Text = "-";
            // 
            // AddTelephoneNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 239);
            this.Controls.Add(this.lblCountryCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboSite);
            this.Controls.Add(this.txtQtyOfDids);
            this.Controls.Add(this.txtDidNumber);
            this.Controls.Add(this.txtAreaCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTelephoneNumbers";
            this.Text = "Add Telephone Numbers";
            this.Load += new System.EventHandler(this.AddTelephoneNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAreaCode;
        private System.Windows.Forms.TextBox txtDidNumber;
        private System.Windows.Forms.TextBox txtQtyOfDids;
        private System.Windows.Forms.ComboBox cboSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCountryCode;
    }
}