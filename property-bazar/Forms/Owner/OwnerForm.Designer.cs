
namespace property_bazar.Froms.Owner
{
    partial class OwnerForm
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
            this.textBoxOwnerId = new System.Windows.Forms.TextBox();
            this.txtOwnerFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOwnerLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOwnerEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOwnerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOwnerAddress = new System.Windows.Forms.TextBox();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBoxOwnerId
            // 
            this.textBoxOwnerId.Location = new System.Drawing.Point(115, 93);
            this.textBoxOwnerId.Name = "textBoxOwnerId";
            this.textBoxOwnerId.Size = new System.Drawing.Size(100, 23);
            this.textBoxOwnerId.TabIndex = 1;
            // 
            // txtOwnerFirstName
            // 
            this.txtOwnerFirstName.Location = new System.Drawing.Point(115, 135);
            this.txtOwnerFirstName.Name = "txtOwnerFirstName";
            this.txtOwnerFirstName.Size = new System.Drawing.Size(247, 23);
            this.txtOwnerFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // txtOwnerLastName
            // 
            this.txtOwnerLastName.Location = new System.Drawing.Point(115, 180);
            this.txtOwnerLastName.Name = "txtOwnerLastName";
            this.txtOwnerLastName.Size = new System.Drawing.Size(247, 23);
            this.txtOwnerLastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // textBoxOwnerEmail
            // 
            this.textBoxOwnerEmail.Location = new System.Drawing.Point(115, 226);
            this.textBoxOwnerEmail.Name = "textBoxOwnerEmail";
            this.textBoxOwnerEmail.Size = new System.Drawing.Size(247, 23);
            this.textBoxOwnerEmail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // textBoxOwnerPhoneNumber
            // 
            this.textBoxOwnerPhoneNumber.Location = new System.Drawing.Point(115, 271);
            this.textBoxOwnerPhoneNumber.Name = "textBoxOwnerPhoneNumber";
            this.textBoxOwnerPhoneNumber.Size = new System.Drawing.Size(247, 23);
            this.textBoxOwnerPhoneNumber.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            // 
            // textBoxOwnerAddress
            // 
            this.textBoxOwnerAddress.Location = new System.Drawing.Point(115, 309);
            this.textBoxOwnerAddress.Multiline = true;
            this.textBoxOwnerAddress.Name = "textBoxOwnerAddress";
            this.textBoxOwnerAddress.Size = new System.Drawing.Size(247, 63);
            this.textBoxOwnerAddress.TabIndex = 10;
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(115, 434);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(66, 33);
            this.btnAddOwner.TabIndex = 12;
            this.btnAddOwner.Text = "ADD";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // OwnerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 546);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOwnerAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOwnerPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOwnerEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOwnerLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOwnerFirstName);
            this.Controls.Add(this.textBoxOwnerId);
            this.Controls.Add(this.label1);
            this.Name = "OwnerFrom";
            this.Text = "Owner ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOwnerId;
        private System.Windows.Forms.TextBox txtOwnerFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOwnerLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOwnerEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOwnerPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOwnerAddress;
        private System.Windows.Forms.Button btnAddOwner;
    }
}