namespace eVotingSystem.Desktop
{
    partial class frmAddCandidate
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbPoliticalOrganizationId = new System.Windows.Forms.ComboBox();
            this.nmrcOrdinal = new System.Windows.Forms.NumericUpDown();
            this.dtmBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbCityId = new System.Windows.Forms.ComboBox();
            this.cmbNationalityId = new System.Windows.Forms.ComboBox();
            this.upldPicture = new System.Windows.Forms.PictureBox();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpCandidate = new System.Windows.Forms.GroupBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.cmbPictureId = new System.Windows.Forms.ComboBox();
            this.cmbResumeId = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcOrdinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upldPicture)).BeginInit();
            this.grpCandidate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(176, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Political organization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ordinal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Document";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Picture";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nationality";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(119, 114);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(177, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // cmbPoliticalOrganizationId
            // 
            this.cmbPoliticalOrganizationId.FormattingEnabled = true;
            this.cmbPoliticalOrganizationId.Location = new System.Drawing.Point(119, 150);
            this.cmbPoliticalOrganizationId.Name = "cmbPoliticalOrganizationId";
            this.cmbPoliticalOrganizationId.Size = new System.Drawing.Size(177, 21);
            this.cmbPoliticalOrganizationId.TabIndex = 14;
            // 
            // nmrcOrdinal
            // 
            this.nmrcOrdinal.Location = new System.Drawing.Point(120, 191);
            this.nmrcOrdinal.Name = "nmrcOrdinal";
            this.nmrcOrdinal.Size = new System.Drawing.Size(176, 20);
            this.nmrcOrdinal.TabIndex = 15;
            // 
            // dtmBirthday
            // 
            this.dtmBirthday.Location = new System.Drawing.Point(119, 234);
            this.dtmBirthday.Name = "dtmBirthday";
            this.dtmBirthday.Size = new System.Drawing.Size(177, 20);
            this.dtmBirthday.TabIndex = 16;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(119, 273);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(177, 21);
            this.cmbGender.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(119, 314);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(177, 20);
            this.txtTitle.TabIndex = 18;
            // 
            // cmbCityId
            // 
            this.cmbCityId.FormattingEnabled = true;
            this.cmbCityId.Location = new System.Drawing.Point(305, 72);
            this.cmbCityId.Name = "cmbCityId";
            this.cmbCityId.Size = new System.Drawing.Size(171, 21);
            this.cmbCityId.TabIndex = 19;
            // 
            // cmbNationalityId
            // 
            this.cmbNationalityId.FormattingEnabled = true;
            this.cmbNationalityId.Location = new System.Drawing.Point(303, 114);
            this.cmbNationalityId.Name = "cmbNationalityId";
            this.cmbNationalityId.Size = new System.Drawing.Size(173, 21);
            this.cmbNationalityId.TabIndex = 20;
            // 
            // upldPicture
            // 
            this.upldPicture.Location = new System.Drawing.Point(302, 223);
            this.upldPicture.Name = "upldPicture";
            this.upldPicture.Size = new System.Drawing.Size(174, 71);
            this.upldPicture.TabIndex = 22;
            this.upldPicture.TabStop = false;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(304, 317);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(172, 85);
            this.txtDetails.TabIndex = 23;
            this.txtDetails.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(119, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 61);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveCandidate);
            // 
            // grpCandidate
            // 
            this.grpCandidate.Controls.Add(this.lblError);
            this.grpCandidate.Controls.Add(this.cmbResumeId);
            this.grpCandidate.Controls.Add(this.cmbPictureId);
            this.grpCandidate.Controls.Add(this.btnAddPicture);
            this.grpCandidate.Controls.Add(this.button1);
            this.grpCandidate.Controls.Add(this.txtFile);
            this.grpCandidate.Controls.Add(this.cmbGender);
            this.grpCandidate.Controls.Add(this.btnSave);
            this.grpCandidate.Controls.Add(this.label1);
            this.grpCandidate.Controls.Add(this.txtDetails);
            this.grpCandidate.Controls.Add(this.txtFirstName);
            this.grpCandidate.Controls.Add(this.upldPicture);
            this.grpCandidate.Controls.Add(this.label2);
            this.grpCandidate.Controls.Add(this.label3);
            this.grpCandidate.Controls.Add(this.cmbNationalityId);
            this.grpCandidate.Controls.Add(this.label4);
            this.grpCandidate.Controls.Add(this.cmbCityId);
            this.grpCandidate.Controls.Add(this.label5);
            this.grpCandidate.Controls.Add(this.txtTitle);
            this.grpCandidate.Controls.Add(this.label6);
            this.grpCandidate.Controls.Add(this.label7);
            this.grpCandidate.Controls.Add(this.dtmBirthday);
            this.grpCandidate.Controls.Add(this.label8);
            this.grpCandidate.Controls.Add(this.nmrcOrdinal);
            this.grpCandidate.Controls.Add(this.label9);
            this.grpCandidate.Controls.Add(this.cmbPoliticalOrganizationId);
            this.grpCandidate.Controls.Add(this.label10);
            this.grpCandidate.Controls.Add(this.txtLastName);
            this.grpCandidate.Controls.Add(this.label11);
            this.grpCandidate.Controls.Add(this.label12);
            this.grpCandidate.Location = new System.Drawing.Point(-4, -6);
            this.grpCandidate.Name = "grpCandidate";
            this.grpCandidate.Size = new System.Drawing.Size(590, 487);
            this.grpCandidate.TabIndex = 25;
            this.grpCandidate.TabStop = false;
            // 
            // txtFile
            // 
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(302, 171);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(173, 20);
            this.txtFile.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(432, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 21);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(432, 203);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(43, 19);
            this.btnAddPicture.TabIndex = 27;
            this.btnAddPicture.Text = "Add";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // cmbPictureId
            // 
            this.cmbPictureId.FormattingEnabled = true;
            this.cmbPictureId.Location = new System.Drawing.Point(119, 430);
            this.cmbPictureId.Name = "cmbPictureId";
            this.cmbPictureId.Size = new System.Drawing.Size(121, 21);
            this.cmbPictureId.TabIndex = 28;
            this.cmbPictureId.Visible = false;
            // 
            // cmbResumeId
            // 
            this.cmbResumeId.FormattingEnabled = true;
            this.cmbResumeId.Location = new System.Drawing.Point(246, 430);
            this.cmbResumeId.Name = "cmbResumeId";
            this.cmbResumeId.Size = new System.Drawing.Size(121, 21);
            this.cmbResumeId.TabIndex = 29;
            this.cmbResumeId.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(118, 405);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 30;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmAddCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 477);
            this.Controls.Add(this.grpCandidate);
            this.Name = "frmAddCandidate";
            this.Text = "frmAddCandidate";
            this.Load += new System.EventHandler(this.frmAddCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcOrdinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upldPicture)).EndInit();
            this.grpCandidate.ResumeLayout(false);
            this.grpCandidate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbPoliticalOrganizationId;
        private System.Windows.Forms.NumericUpDown nmrcOrdinal;
        private System.Windows.Forms.DateTimePicker dtmBirthday;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbCityId;
        private System.Windows.Forms.ComboBox cmbNationalityId;
        private System.Windows.Forms.PictureBox upldPicture;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpCandidate;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ComboBox cmbResumeId;
        private System.Windows.Forms.ComboBox cmbPictureId;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label lblError;
    }
}