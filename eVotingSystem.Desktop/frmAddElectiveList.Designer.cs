namespace eVotingSystem.Desktop
{
    partial class frmAddElectiveList
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
            this.txtElectionPositionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbElectionRegionId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpElectiveList = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpElectiveList.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtElectionPositionName
            // 
            this.txtElectionPositionName.Location = new System.Drawing.Point(35, 48);
            this.txtElectionPositionName.Name = "txtElectionPositionName";
            this.txtElectionPositionName.Size = new System.Drawing.Size(121, 20);
            this.txtElectionPositionName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position";
            // 
            // cmbElectionRegionId
            // 
            this.cmbElectionRegionId.FormattingEnabled = true;
            this.cmbElectionRegionId.Location = new System.Drawing.Point(35, 96);
            this.cmbElectionRegionId.Name = "cmbElectionRegionId";
            this.cmbElectionRegionId.Size = new System.Drawing.Size(121, 21);
            this.cmbElectionRegionId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assign to region";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveElectiveList);
            // 
            // grpElectiveList
            // 
            this.grpElectiveList.Controls.Add(this.lblError);
            this.grpElectiveList.Controls.Add(this.txtElectionPositionName);
            this.grpElectiveList.Controls.Add(this.btnSave);
            this.grpElectiveList.Controls.Add(this.label1);
            this.grpElectiveList.Controls.Add(this.label2);
            this.grpElectiveList.Controls.Add(this.cmbElectionRegionId);
            this.grpElectiveList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpElectiveList.Location = new System.Drawing.Point(2, -3);
            this.grpElectiveList.Name = "grpElectiveList";
            this.grpElectiveList.Size = new System.Drawing.Size(194, 190);
            this.grpElectiveList.TabIndex = 5;
            this.grpElectiveList.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(35, 166);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmAddElectiveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 185);
            this.Controls.Add(this.grpElectiveList);
            this.Name = "frmAddElectiveList";
            this.Text = "frmAddElectiveList";
            this.Load += new System.EventHandler(this.frmAddElectiveList_Load);
            this.grpElectiveList.ResumeLayout(false);
            this.grpElectiveList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtElectionPositionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbElectionRegionId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpElectiveList;
        private System.Windows.Forms.Label lblError;
    }
}