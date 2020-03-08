namespace eVotingSystem.Desktop
{
    partial class frmAddElectionUnit
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbElectionRegionId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpElectionUnit = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpElectionUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(41, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmbElectionRegionId
            // 
            this.cmbElectionRegionId.FormattingEnabled = true;
            this.cmbElectionRegionId.Location = new System.Drawing.Point(41, 100);
            this.cmbElectionRegionId.Name = "cmbElectionRegionId";
            this.cmbElectionRegionId.Size = new System.Drawing.Size(258, 21);
            this.cmbElectionRegionId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select region";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(41, 142);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(258, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(41, 268);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(258, 94);
            this.txtDetails.TabIndex = 6;
            this.txtDetails.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(41, 231);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(258, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start time of voting";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "End time of voting";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(41, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(258, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveElectionUnit);
            // 
            // grpElectionUnit
            // 
            this.grpElectionUnit.Controls.Add(this.lblError);
            this.grpElectionUnit.Controls.Add(this.label1);
            this.grpElectionUnit.Controls.Add(this.btnSave);
            this.grpElectionUnit.Controls.Add(this.txtName);
            this.grpElectionUnit.Controls.Add(this.label6);
            this.grpElectionUnit.Controls.Add(this.cmbElectionRegionId);
            this.grpElectionUnit.Controls.Add(this.label5);
            this.grpElectionUnit.Controls.Add(this.label2);
            this.grpElectionUnit.Controls.Add(this.dateTimePicker2);
            this.grpElectionUnit.Controls.Add(this.txtAddress);
            this.grpElectionUnit.Controls.Add(this.dateTimePicker1);
            this.grpElectionUnit.Controls.Add(this.label3);
            this.grpElectionUnit.Controls.Add(this.label4);
            this.grpElectionUnit.Controls.Add(this.txtDetails);
            this.grpElectionUnit.Location = new System.Drawing.Point(-1, -3);
            this.grpElectionUnit.Name = "grpElectionUnit";
            this.grpElectionUnit.Size = new System.Drawing.Size(369, 472);
            this.grpElectionUnit.TabIndex = 13;
            this.grpElectionUnit.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(41, 410);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmAddElectionUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 465);
            this.Controls.Add(this.grpElectionUnit);
            this.Name = "frmAddElectionUnit";
            this.Text = "frmAddElectionUnit";
            this.Load += new System.EventHandler(this.frmAddElectionUnit_Load);
            this.grpElectionUnit.ResumeLayout(false);
            this.grpElectionUnit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbElectionRegionId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpElectionUnit;
        private System.Windows.Forms.Label lblError;
    }
}