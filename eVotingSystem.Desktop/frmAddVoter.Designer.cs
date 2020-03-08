namespace eVotingSystem.Desktop
{
    partial class frmAddVoter
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
            this.cmbUserId = new System.Windows.Forms.ComboBox();
            this.cmbNationalityId = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbSchoolingDegreeLevel = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpVoter = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpVoter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Schooling degree";
            // 
            // cmbUserId
            // 
            this.cmbUserId.FormattingEnabled = true;
            this.cmbUserId.Location = new System.Drawing.Point(57, 31);
            this.cmbUserId.Name = "cmbUserId";
            this.cmbUserId.Size = new System.Drawing.Size(121, 21);
            this.cmbUserId.TabIndex = 4;
            // 
            // cmbNationalityId
            // 
            this.cmbNationalityId.FormattingEnabled = true;
            this.cmbNationalityId.Location = new System.Drawing.Point(57, 72);
            this.cmbNationalityId.Name = "cmbNationalityId";
            this.cmbNationalityId.Size = new System.Drawing.Size(121, 21);
            this.cmbNationalityId.TabIndex = 5;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(57, 111);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 6;
            // 
            // cmbSchoolingDegreeLevel
            // 
            this.cmbSchoolingDegreeLevel.FormattingEnabled = true;
            this.cmbSchoolingDegreeLevel.Location = new System.Drawing.Point(57, 152);
            this.cmbSchoolingDegreeLevel.Name = "cmbSchoolingDegreeLevel";
            this.cmbSchoolingDegreeLevel.Size = new System.Drawing.Size(121, 21);
            this.cmbSchoolingDegreeLevel.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(57, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveVoter);
            // 
            // grpVoter
            // 
            this.grpVoter.Controls.Add(this.lblError);
            this.grpVoter.Controls.Add(this.label1);
            this.grpVoter.Controls.Add(this.btnSave);
            this.grpVoter.Controls.Add(this.label2);
            this.grpVoter.Controls.Add(this.cmbSchoolingDegreeLevel);
            this.grpVoter.Controls.Add(this.label3);
            this.grpVoter.Controls.Add(this.cmbGender);
            this.grpVoter.Controls.Add(this.label4);
            this.grpVoter.Controls.Add(this.cmbNationalityId);
            this.grpVoter.Controls.Add(this.cmbUserId);
            this.grpVoter.Location = new System.Drawing.Point(1, 3);
            this.grpVoter.Name = "grpVoter";
            this.grpVoter.Size = new System.Drawing.Size(235, 231);
            this.grpVoter.TabIndex = 9;
            this.grpVoter.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(57, 214);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmAddVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 232);
            this.Controls.Add(this.grpVoter);
            this.Name = "frmAddVoter";
            this.Text = "frmAddVoter";
            this.Load += new System.EventHandler(this.frmAddVoter_Load);
            this.grpVoter.ResumeLayout(false);
            this.grpVoter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUserId;
        private System.Windows.Forms.ComboBox cmbNationalityId;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbSchoolingDegreeLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpVoter;
        private System.Windows.Forms.Label lblError;
    }
}