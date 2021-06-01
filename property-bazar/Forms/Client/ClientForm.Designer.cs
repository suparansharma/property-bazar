
namespace property_bazar.Froms.Client
{
    partial class ClientForm
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
            this.btnAddClient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnViewClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(7, 437);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(66, 33);
            this.btnAddClient.TabIndex = 25;
            this.btnAddClient.Text = "ADD";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Address";
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(104, 260);
            this.txtClientAddress.Multiline = true;
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(247, 63);
            this.txtClientAddress.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone Number";
            // 
            // txtClientPhoneNumber
            // 
            this.txtClientPhoneNumber.Location = new System.Drawing.Point(104, 222);
            this.txtClientPhoneNumber.Name = "txtClientPhoneNumber";
            this.txtClientPhoneNumber.Size = new System.Drawing.Size(247, 23);
            this.txtClientPhoneNumber.TabIndex = 21;
            this.txtClientPhoneNumber.TextChanged += new System.EventHandler(this.textBoxClientPhoneNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(104, 177);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(247, 23);
            this.txtClientEmail.TabIndex = 19;
            this.txtClientEmail.TextChanged += new System.EventHandler(this.textBoxClientEmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name";
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(104, 131);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(247, 23);
            this.txtClientLastName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "First Name";
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(104, 86);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(247, 23);
            this.txtClientFirstName.TabIndex = 15;
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(104, 44);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(100, 23);
            this.textBoxClientId.TabIndex = 14;
            this.textBoxClientId.TextChanged += new System.EventHandler(this.textBoxOwnerId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 280);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnViewClient
            // 
            this.btnViewClient.Location = new System.Drawing.Point(104, 433);
            this.btnViewClient.Name = "btnViewClient";
            this.btnViewClient.Size = new System.Drawing.Size(66, 37);
            this.btnViewClient.TabIndex = 27;
            this.btnViewClient.Text = "View";
            this.btnViewClient.UseVisualStyleBackColor = true;
            this.btnViewClient.Click += new System.EventHandler(this.btnViewClient_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 482);
            this.Controls.Add(this.btnViewClient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClientAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClientPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewClient;
    }
}