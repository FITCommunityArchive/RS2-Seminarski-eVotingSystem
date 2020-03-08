namespace eVotingSystem.Desktop
{
    partial class frmAddElectionOption
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
            this.cmbElectionOptionType = new System.Windows.Forms.ComboBox();
            this.cmbCandidateId = new System.Windows.Forms.ComboBox();
            this.cmbPoliticalOrganizationId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbElectiveListId = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpElectionOption = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpElectionOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Political organization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of election option";
            // 
            // cmbElectionOptionType
            // 
            this.cmbElectionOptionType.FormattingEnabled = true;
            this.cmbElectionOptionType.Location = new System.Drawing.Point(72, 76);
            this.cmbElectionOptionType.Name = "cmbElectionOptionType";
            this.cmbElectionOptionType.Size = new System.Drawing.Size(121, 21);
            this.cmbElectionOptionType.TabIndex = 4;
            this.cmbElectionOptionType.SelectedIndexChanged += new System.EventHandler(this.cmbElectionOptionType_SelectedIndexChanged);
            // 
            // cmbCandidateId
            // 
            this.cmbCandidateId.Enabled = false;
            this.cmbCandidateId.FormattingEnabled = true;
            this.cmbCandidateId.Location = new System.Drawing.Point(72, 158);
            this.cmbCandidateId.Name = "cmbCandidateId";
            this.cmbCandidateId.Size = new System.Drawing.Size(121, 21);
            this.cmbCandidateId.TabIndex = 5;
            // 
            // cmbPoliticalOrganizationId
            // 
            this.cmbPoliticalOrganizationId.Enabled = false;
            this.cmbPoliticalOrganizationId.FormattingEnabled = true;
            this.cmbPoliticalOrganizationId.Location = new System.Drawing.Point(72, 117);
            this.cmbPoliticalOrganizationId.Name = "cmbPoliticalOrganizationId";
            this.cmbPoliticalOrganizationId.Size = new System.Drawing.Size(121, 21);
            this.cmbPoliticalOrganizationId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Elective list";
            // 
            // cmbElectiveListId
            // 
            this.cmbElectiveListId.FormattingEnabled = true;
            this.cmbElectiveListId.Location = new System.Drawing.Point(72, 198);
            this.cmbElectiveListId.Name = "cmbElectiveListId";
            this.cmbElectiveListId.Size = new System.Drawing.Size(121, 21);
            this.cmbElectiveListId.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveElectionOption);
            // 
            // grpElectionOption
            // 
            this.grpElectionOption.Controls.Add(this.lblError);
            this.grpElectionOption.Controls.Add(this.label4);
            this.grpElectionOption.Controls.Add(this.btnSave);
            this.grpElectionOption.Controls.Add(this.label1);
            this.grpElectionOption.Controls.Add(this.cmbElectiveListId);
            this.grpElectionOption.Controls.Add(this.label2);
            this.grpElectionOption.Controls.Add(this.label5);
            this.grpElectionOption.Controls.Add(this.label3);
            this.grpElectionOption.Controls.Add(this.cmbPoliticalOrganizationId);
            this.grpElectionOption.Controls.Add(this.cmbElectionOptionType);
            this.grpElectionOption.Controls.Add(this.cmbCandidateId);
            this.grpElectionOption.Location = new System.Drawing.Point(-6, -3);
            this.grpElectionOption.Name = "grpElectionOption";
            this.grpElectionOption.Size = new System.Drawing.Size(262, 323);
            this.grpElectionOption.TabIndex = 10;
            this.grpElectionOption.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(72, 272);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmAddElectionOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 317);
            this.Controls.Add(this.grpElectionOption);
            this.Name = "frmAddElectionOption";
            this.Text = "frmAddElectionOption";
            this.Load += new System.EventHandler(this.frmAddElectionOption_Load);
            this.grpElectionOption.ResumeLayout(false);
            this.grpElectionOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbElectionOptionType;
        private System.Windows.Forms.ComboBox cmbCandidateId;
        private System.Windows.Forms.ComboBox cmbPoliticalOrganizationId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbElectiveListId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpElectionOption;
        private System.Windows.Forms.Label lblError;
    }
}