namespace eVotingSystem.Desktop
{
    partial class frmAddCity
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCity = new System.Windows.Forms.GroupBox();
            this.cmbCountryId = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select country";
            // 
            // grpCity
            // 
            this.grpCity.Controls.Add(this.lblError);
            this.grpCity.Controls.Add(this.cmbCountryId);
            this.grpCity.Controls.Add(this.label1);
            this.grpCity.Controls.Add(this.btnSave);
            this.grpCity.Controls.Add(this.label2);
            this.grpCity.Controls.Add(this.txtName);
            this.grpCity.Location = new System.Drawing.Point(1, 1);
            this.grpCity.Name = "grpCity";
            this.grpCity.Size = new System.Drawing.Size(438, 335);
            this.grpCity.TabIndex = 5;
            this.grpCity.TabStop = false;
            // 
            // cmbCountryId
            // 
            this.cmbCountryId.FormattingEnabled = true;
            this.cmbCountryId.Location = new System.Drawing.Point(128, 148);
            this.cmbCountryId.Name = "cmbCountryId";
            this.cmbCountryId.Size = new System.Drawing.Size(158, 21);
            this.cmbCountryId.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(128, 176);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 333);
            this.Controls.Add(this.grpCity);
            this.Name = "frmAddCity";
            this.Text = "frmAddCity";
            this.Load += new System.EventHandler(this.frmAddCity_Load);
            this.grpCity.ResumeLayout(false);
            this.grpCity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCity;
        private System.Windows.Forms.ComboBox cmbCountryId;
        private System.Windows.Forms.Label lblError;
    }
}