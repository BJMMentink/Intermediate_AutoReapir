namespace BJM.AutoReapir.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddingCustomer = new System.Windows.Forms.Button();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddingCustomer
            // 
            this.btnAddingCustomer.Location = new System.Drawing.Point(132, 149);
            this.btnAddingCustomer.Name = "btnAddingCustomer";
            this.btnAddingCustomer.Size = new System.Drawing.Size(100, 23);
            this.btnAddingCustomer.TabIndex = 3;
            this.btnAddingCustomer.Text = "Add Customer";
            this.btnAddingCustomer.UseVisualStyleBackColor = true;
            this.btnAddingCustomer.Click += new System.EventHandler(this.btnAddingCustomer_Click);
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 15;
            this.lstCustomer.Location = new System.Drawing.Point(264, 46);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(242, 124);
            this.lstCustomer.TabIndex = 4;
            this.lstCustomer.SelectedIndexChanged += new System.EventHandler(this.lstCustomer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(132, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(132, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(132, 104);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Number:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 219);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.btnAddingCustomer);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddingCustomer;
        private ListBox lstCustomer;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtPhoneNumber;
        private Label label3;
    }
}