namespace eVotingSystem.Desktop
{
    partial class frmCreateElectionCycle
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpElectionCycle = new System.Windows.Forms.GroupBox();
            this.chklstElectiveLists = new System.Windows.Forms.CheckedListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpElectionCycle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Election Cycle Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add lists";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveElectionCycle);
            // 
            // grpElectionCycle
            // 
            this.grpElectionCycle.Controls.Add(this.lblError);
            this.grpElectionCycle.Controls.Add(this.chklstElectiveLists);
            this.grpElectionCycle.Controls.Add(this.btnSave);
            this.grpElectionCycle.Controls.Add(this.label1);
            this.grpElectionCycle.Controls.Add(this.txtName);
            this.grpElectionCycle.Controls.Add(this.label2);
            this.grpElectionCycle.Location = new System.Drawing.Point(1, 2);
            this.grpElectionCycle.Name = "grpElectionCycle";
            this.grpElectionCycle.Size = new System.Drawing.Size(412, 242);
            this.grpElectionCycle.TabIndex = 5;
            this.grpElectionCycle.TabStop = false;
            // 
            // chklstElectiveLists
            // 
            this.chklstElectiveLists.FormattingEnabled = true;
            this.chklstElectiveLists.Location = new System.Drawing.Point(64, 80);
            this.chklstElectiveLists.Name = "chklstElectiveLists";
            this.chklstElectiveLists.Size = new System.Drawing.Size(120, 94);
            this.chklstElectiveLists.TabIndex = 5;
            this.chklstElectiveLists.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstElectiveLists_ItemCheck);
            this.chklstElectiveLists.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(61, 216);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmCreateElectionCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 240);
            this.Controls.Add(this.grpElectionCycle);
            this.Name = "frmCreateElectionCycle";
            this.Text = "frmCreateElectionCycle";
            this.Load += new System.EventHandler(this.frmCreateElectionCycle_Load);
            this.grpElectionCycle.ResumeLayout(false);
            this.grpElectionCycle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpElectionCycle;
        private System.Windows.Forms.CheckedListBox chklstElectiveLists;
        private System.Windows.Forms.Label lblError;
    }
}