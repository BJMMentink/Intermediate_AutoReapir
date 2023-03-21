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
            this.components = new System.ComponentModel.Container();
            this.btnAddingCustomer = new System.Windows.Forms.Button();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstVehicles = new System.Windows.Forms.ListBox();
            this.btnUpdatingCustomer = new System.Windows.Forms.Button();
            this.btnDeletingCustomer = new System.Windows.Forms.Button();
            this.btnDeletingVehilcle = new System.Windows.Forms.Button();
            this.btnUpdatingVehicle = new System.Windows.Forms.Button();
            this.btnAddingVehicle = new System.Windows.Forms.Button();
            this.staMain = new System.Windows.Forms.StatusStrip();
            this.staTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.staMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddingCustomer
            // 
            this.btnAddingCustomer.Location = new System.Drawing.Point(120, 134);
            this.btnAddingCustomer.Name = "btnAddingCustomer";
            this.btnAddingCustomer.Size = new System.Drawing.Size(126, 23);
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
            this.lstCustomer.Size = new System.Drawing.Size(242, 169);
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
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(132, 286);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 23);
            this.txtYear.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Year:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(132, 257);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 23);
            this.txtModel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Model:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(132, 228);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 23);
            this.txtMake.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Make:";
            // 
            // lstVehicles
            // 
            this.lstVehicles.FormattingEnabled = true;
            this.lstVehicles.ItemHeight = 15;
            this.lstVehicles.Location = new System.Drawing.Point(264, 228);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(242, 169);
            this.lstVehicles.TabIndex = 11;
            // 
            // btnUpdatingCustomer
            // 
            this.btnUpdatingCustomer.Location = new System.Drawing.Point(120, 163);
            this.btnUpdatingCustomer.Name = "btnUpdatingCustomer";
            this.btnUpdatingCustomer.Size = new System.Drawing.Size(126, 23);
            this.btnUpdatingCustomer.TabIndex = 15;
            this.btnUpdatingCustomer.Text = "Update  Customer";
            this.btnUpdatingCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeletingCustomer
            // 
            this.btnDeletingCustomer.Location = new System.Drawing.Point(120, 192);
            this.btnDeletingCustomer.Name = "btnDeletingCustomer";
            this.btnDeletingCustomer.Size = new System.Drawing.Size(126, 23);
            this.btnDeletingCustomer.TabIndex = 16;
            this.btnDeletingCustomer.Text = "Delete Customer";
            this.btnDeletingCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeletingVehilcle
            // 
            this.btnDeletingVehilcle.Location = new System.Drawing.Point(120, 374);
            this.btnDeletingVehilcle.Name = "btnDeletingVehilcle";
            this.btnDeletingVehilcle.Size = new System.Drawing.Size(126, 23);
            this.btnDeletingVehilcle.TabIndex = 19;
            this.btnDeletingVehilcle.Text = "Delete Vehicle";
            this.btnDeletingVehilcle.UseVisualStyleBackColor = true;
            // 
            // btnUpdatingVehicle
            // 
            this.btnUpdatingVehicle.Location = new System.Drawing.Point(120, 345);
            this.btnUpdatingVehicle.Name = "btnUpdatingVehicle";
            this.btnUpdatingVehicle.Size = new System.Drawing.Size(126, 23);
            this.btnUpdatingVehicle.TabIndex = 18;
            this.btnUpdatingVehicle.Text = "Update Vehicle";
            this.btnUpdatingVehicle.UseVisualStyleBackColor = true;
            // 
            // btnAddingVehicle
            // 
            this.btnAddingVehicle.Location = new System.Drawing.Point(120, 316);
            this.btnAddingVehicle.Name = "btnAddingVehicle";
            this.btnAddingVehicle.Size = new System.Drawing.Size(126, 23);
            this.btnAddingVehicle.TabIndex = 17;
            this.btnAddingVehicle.Text = "Add Vehicle";
            this.btnAddingVehicle.UseVisualStyleBackColor = true;
            // 
            // staMain
            // 
            this.staMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staTime});
            this.staMain.Location = new System.Drawing.Point(0, 430);
            this.staMain.Name = "staMain";
            this.staMain.Size = new System.Drawing.Size(856, 22);
            this.staMain.TabIndex = 20;
            this.staMain.Text = "statusStrip1";
            // 
            // staTime
            // 
            this.staTime.Name = "staTime";
            this.staTime.Size = new System.Drawing.Size(118, 17);
            this.staTime.Text = "toolStripStatusLabel1";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(523, 46);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 25;
            this.dgvCustomer.Size = new System.Drawing.Size(292, 351);
            this.dgvCustomer.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 452);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.staMain);
            this.Controls.Add(this.btnDeletingVehilcle);
            this.Controls.Add(this.btnUpdatingVehicle);
            this.Controls.Add(this.btnAddingVehicle);
            this.Controls.Add(this.btnDeletingCustomer);
            this.Controls.Add(this.btnUpdatingCustomer);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstVehicles);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.staMain.ResumeLayout(false);
            this.staMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
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
        private TextBox txtYear;
        private Label label4;
        private TextBox txtModel;
        private Label label5;
        private TextBox txtMake;
        private Label label6;
        private ListBox lstVehicles;
        private Button btnUpdatingCustomer;
        private Button btnDeletingCustomer;
        private Button btnDeletingVehilcle;
        private Button btnUpdatingVehicle;
        private Button btnAddingVehicle;
        private StatusStrip staMain;
        private ToolStripStatusLabel staTime;
        private System.Windows.Forms.Timer tmrTime;
        private DataGridView dgvCustomer;
    }
}