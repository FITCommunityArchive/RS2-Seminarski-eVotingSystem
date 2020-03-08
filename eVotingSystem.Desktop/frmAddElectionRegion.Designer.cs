namespace eVotingSystem.Desktop
{
    partial class frmAddElectionRegion
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSuperiorRegionId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpElectionRegion = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpElectionRegion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of region";
            // 
            // cmbSuperiorRegionId
            // 
            this.cmbSuperiorRegionId.FormattingEnabled = true;
            this.cmbSuperiorRegionId.Location = new System.Drawing.Point(97, 130);
            this.cmbSuperiorRegionId.Name = "cmbSuperiorRegionId";
            this.cmbSuperiorRegionId.Size = new System.Drawing.Size(121, 21);
            this.cmbSuperiorRegionId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add superior region";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveElectionRegion);
            // 
            // grpElectionRegion
            // 
            this.grpElectionRegion.Controls.Add(this.lblError);
            this.grpElectionRegion.Controls.Add(this.label1);
            this.grpElectionRegion.Controls.Add(this.btnSave);
            this.grpElectionRegion.Controls.Add(this.txtName);
            this.grpElectionRegion.Controls.Add(this.label2);
            this.grpElectionRegion.Controls.Add(this.cmbSuperiorRegionId);
            this.grpElectionRegion.Location = new System.Drawing.Point(-9, -3);
            this.grpElectionRegion.Name = "grpElectionRegion";
            this.grpElectionRegion.Size = new System.Drawing.Size(333, 315);
            this.grpElectionRegion.TabIndex = 5;
            this.grpElectionRegion.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(102, 203);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmAddElectionRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 309);
            this.Controls.Add(this.grpElectionRegion);
            this.Name = "frmAddElectionRegion";
            this.Text = "frmAddElectionRegion";
            this.Load += new System.EventHandler(this.frmAddElectionRegion_Load);
            this.grpElectionRegion.ResumeLayout(false);
            this.grpElectionRegion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSuperiorRegionId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpElectionRegion;
        private System.Windows.Forms.Label lblError;
    }
}