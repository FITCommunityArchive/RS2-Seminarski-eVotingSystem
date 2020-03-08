namespace eVotingSystem.Desktop
{
    partial class frmAddCountry
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
            this.btnAddCities = new System.Windows.Forms.Button();
            this.grpCountry = new System.Windows.Forms.GroupBox();
            this.grpCountry.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnAddCities
            // 
            this.btnAddCities.Location = new System.Drawing.Point(116, 133);
            this.btnAddCities.Name = "btnAddCities";
            this.btnAddCities.Size = new System.Drawing.Size(160, 22);
            this.btnAddCities.TabIndex = 3;
            this.btnAddCities.Text = "Add cities";
            this.btnAddCities.UseVisualStyleBackColor = true;
            // 
            // grpCountry
            // 
            this.grpCountry.Controls.Add(this.label1);
            this.grpCountry.Controls.Add(this.btnAddCities);
            this.grpCountry.Controls.Add(this.txtName);
            this.grpCountry.Controls.Add(this.btnSave);
            this.grpCountry.Location = new System.Drawing.Point(-5, -2);
            this.grpCountry.Name = "grpCountry";
            this.grpCountry.Size = new System.Drawing.Size(386, 247);
            this.grpCountry.TabIndex = 4;
            this.grpCountry.TabStop = false;
            // 
            // frmAddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 241);
            this.Controls.Add(this.grpCountry);
            this.Name = "frmAddCountry";
            this.Text = "frmAddCountry";
            this.Load += new System.EventHandler(this.frmAddCountry_Load);
            this.grpCountry.ResumeLayout(false);
            this.grpCountry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddCities;
        private System.Windows.Forms.GroupBox grpCountry;
    }
}