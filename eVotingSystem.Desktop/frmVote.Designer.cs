namespace eVotingSystem.Desktop
{
    partial class frmVote
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
            this.cmbElectiveListId = new System.Windows.Forms.ComboBox();
            this.cmbElectionOptionId = new System.Windows.Forms.ComboBox();
            this.chkCandidates = new System.Windows.Forms.CheckedListBox();
            this.btnVote = new System.Windows.Forms.Button();
            this.grpVote = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpVote.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select elective list for voting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose political organization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose a candidates";
            // 
            // cmbElectiveListId
            // 
            this.cmbElectiveListId.FormattingEnabled = true;
            this.cmbElectiveListId.Location = new System.Drawing.Point(143, 78);
            this.cmbElectiveListId.Name = "cmbElectiveListId";
            this.cmbElectiveListId.Size = new System.Drawing.Size(136, 21);
            this.cmbElectiveListId.TabIndex = 3;
            this.cmbElectiveListId.SelectedValueChanged += new System.EventHandler(this.cmbElectiveListId_SelectedValueChanged);
            // 
            // cmbElectionOptionId
            // 
            this.cmbElectionOptionId.Enabled = false;
            this.cmbElectionOptionId.FormattingEnabled = true;
            this.cmbElectionOptionId.Location = new System.Drawing.Point(143, 144);
            this.cmbElectionOptionId.Name = "cmbElectionOptionId";
            this.cmbElectionOptionId.Size = new System.Drawing.Size(138, 21);
            this.cmbElectionOptionId.TabIndex = 4;
            // 
            // chkCandidates
            // 
            this.chkCandidates.Enabled = false;
            this.chkCandidates.FormattingEnabled = true;
            this.chkCandidates.Location = new System.Drawing.Point(143, 211);
            this.chkCandidates.Name = "chkCandidates";
            this.chkCandidates.Size = new System.Drawing.Size(138, 154);
            this.chkCandidates.TabIndex = 5;
            this.chkCandidates.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkCandidates_ItemCheck);
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(143, 389);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(138, 29);
            this.btnVote.TabIndex = 6;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // grpVote
            // 
            this.grpVote.Controls.Add(this.lblError);
            this.grpVote.Controls.Add(this.label1);
            this.grpVote.Controls.Add(this.btnVote);
            this.grpVote.Controls.Add(this.label2);
            this.grpVote.Controls.Add(this.chkCandidates);
            this.grpVote.Controls.Add(this.label3);
            this.grpVote.Controls.Add(this.cmbElectionOptionId);
            this.grpVote.Controls.Add(this.cmbElectiveListId);
            this.grpVote.Location = new System.Drawing.Point(1, 3);
            this.grpVote.Name = "grpVote";
            this.grpVote.Size = new System.Drawing.Size(403, 511);
            this.grpVote.TabIndex = 7;
            this.grpVote.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(140, 421);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 470);
            this.Controls.Add(this.grpVote);
            this.Name = "frmVote";
            this.Text = "frmVote";
            this.Load += new System.EventHandler(this.frmVote_Load);
            this.grpVote.ResumeLayout(false);
            this.grpVote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbElectiveListId;
        private System.Windows.Forms.ComboBox cmbElectionOptionId;
        private System.Windows.Forms.CheckedListBox chkCandidates;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.GroupBox grpVote;
        private System.Windows.Forms.Label lblError;
    }
}