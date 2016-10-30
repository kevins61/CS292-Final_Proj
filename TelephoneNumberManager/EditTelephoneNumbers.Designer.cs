namespace TelephoneNumberManager
{
    partial class EditTelephoneNumbers
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
            this.cboSite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSetAsFax = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstTelephoneNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboSite
            // 
            this.cboSite.FormattingEnabled = true;
            this.cboSite.Location = new System.Drawing.Point(54, 18);
            this.cboSite.Name = "cboSite";
            this.cboSite.Size = new System.Drawing.Size(121, 24);
            this.cboSite.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site:";
            // 
            // chkSetAsFax
            // 
            this.chkSetAsFax.AutoSize = true;
            this.chkSetAsFax.Location = new System.Drawing.Point(15, 408);
            this.chkSetAsFax.Name = "chkSetAsFax";
            this.chkSetAsFax.Size = new System.Drawing.Size(226, 21);
            this.chkSetAsFax.TabIndex = 3;
            this.chkSetAsFax.Text = "Set Selected Number(s) as Fax";
            this.chkSetAsFax.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstTelephoneNumbers
            // 
            this.lstTelephoneNumbers.FormattingEnabled = true;
            this.lstTelephoneNumbers.ItemHeight = 16;
            this.lstTelephoneNumbers.Location = new System.Drawing.Point(15, 58);
            this.lstTelephoneNumbers.Name = "lstTelephoneNumbers";
            this.lstTelephoneNumbers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTelephoneNumbers.Size = new System.Drawing.Size(375, 340);
            this.lstTelephoneNumbers.TabIndex = 7;
            // 
            // EditTelephoneNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 530);
            this.Controls.Add(this.lstTelephoneNumbers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkSetAsFax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSite);
            this.Name = "EditTelephoneNumbers";
            this.Text = "Edit Telephone Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSetAsFax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstTelephoneNumbers;
    }
}