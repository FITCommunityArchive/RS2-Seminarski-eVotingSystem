﻿namespace eVotingSystem.Desktop
{
    partial class frmAddNationality
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
            this.grpNationality = new System.Windows.Forms.GroupBox();
            this.grpNationality.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nationality";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpNationality
            // 
            this.grpNationality.Controls.Add(this.label1);
            this.grpNationality.Controls.Add(this.btnSave);
            this.grpNationality.Controls.Add(this.txtName);
            this.grpNationality.Location = new System.Drawing.Point(-7, -1);
            this.grpNationality.Name = "grpNationality";
            this.grpNationality.Size = new System.Drawing.Size(444, 296);
            this.grpNationality.TabIndex = 3;
            this.grpNationality.TabStop = false;
            // 
            // frmAddNationality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 286);
            this.Controls.Add(this.grpNationality);
            this.Name = "frmAddNationality";
            this.Text = "frmAddNationality";
            this.Load += new System.EventHandler(this.frmAddNationality_Load);
            this.grpNationality.ResumeLayout(false);
            this.grpNationality.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpNationality;
    }
}