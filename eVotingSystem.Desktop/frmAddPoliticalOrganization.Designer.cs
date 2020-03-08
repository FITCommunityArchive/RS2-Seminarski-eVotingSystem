namespace eVotingSystem.Desktop
{
    partial class frmAddPoliticalOrganization
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
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.nmrcOrdinal = new System.Windows.Forms.NumericUpDown();
            this.cmbCityId = new System.Windows.Forms.ComboBox();
            this.upldPicture = new System.Windows.Forms.PictureBox();
            this.cmbPoliticalOrientation = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpPoliticalOrganization = new System.Windows.Forms.GroupBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDocumentName = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.cmbPictureId = new System.Windows.Forms.ComboBox();
            this.cmbFileId = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcOrdinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upldPicture)).BeginInit();
            this.grpPoliticalOrganization.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(27, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(27, 98);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(120, 20);
            this.txtShortName.TabIndex = 1;
            // 
            // nmrcOrdinal
            // 
            this.nmrcOrdinal.Location = new System.Drawing.Point(27, 146);
            this.nmrcOrdinal.Name = "nmrcOrdinal";
            this.nmrcOrdinal.Size = new System.Drawing.Size(120, 20);
            this.nmrcOrdinal.TabIndex = 2;
            // 
            // cmbCityId
            // 
            this.cmbCityId.FormattingEnabled = true;
            this.cmbCityId.Location = new System.Drawing.Point(26, 189);
            this.cmbCityId.Name = "cmbCityId";
            this.cmbCityId.Size = new System.Drawing.Size(121, 21);
            this.cmbCityId.TabIndex = 3;
            // 
            // upldPicture
            // 
            this.upldPicture.Location = new System.Drawing.Point(171, 173);
            this.upldPicture.Name = "upldPicture";
            this.upldPicture.Size = new System.Drawing.Size(100, 50);
            this.upldPicture.TabIndex = 4;
            this.upldPicture.TabStop = false;
            // 
            // cmbPoliticalOrientation
            // 
            this.cmbPoliticalOrientation.FormattingEnabled = true;
            this.cmbPoliticalOrientation.Location = new System.Drawing.Point(26, 237);
            this.cmbPoliticalOrientation.Name = "cmbPoliticalOrientation";
            this.cmbPoliticalOrientation.Size = new System.Drawing.Size(121, 21);
            this.cmbPoliticalOrientation.TabIndex = 6;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(171, 50);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(100, 96);
            this.txtDetails.TabIndex = 7;
            this.txtDetails.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Short Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ordinal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Political Orientation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Picture";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Document";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSavePoliticalOrganization);
            // 
            // grpPoliticalOrganization
            // 
            this.grpPoliticalOrganization.Controls.Add(this.lblError);
            this.grpPoliticalOrganization.Controls.Add(this.cmbFileId);
            this.grpPoliticalOrganization.Controls.Add(this.cmbPictureId);
            this.grpPoliticalOrganization.Controls.Add(this.txtDocumentName);
            this.grpPoliticalOrganization.Controls.Add(this.btnAddDocument);
            this.grpPoliticalOrganization.Controls.Add(this.btnAddPicture);
            this.grpPoliticalOrganization.Controls.Add(this.label6);
            this.grpPoliticalOrganization.Controls.Add(this.btnSave);
            this.grpPoliticalOrganization.Controls.Add(this.txtName);
            this.grpPoliticalOrganization.Controls.Add(this.label8);
            this.grpPoliticalOrganization.Controls.Add(this.txtShortName);
            this.grpPoliticalOrganization.Controls.Add(this.label7);
            this.grpPoliticalOrganization.Controls.Add(this.nmrcOrdinal);
            this.grpPoliticalOrganization.Controls.Add(this.cmbCityId);
            this.grpPoliticalOrganization.Controls.Add(this.label5);
            this.grpPoliticalOrganization.Controls.Add(this.upldPicture);
            this.grpPoliticalOrganization.Controls.Add(this.label4);
            this.grpPoliticalOrganization.Controls.Add(this.label3);
            this.grpPoliticalOrganization.Controls.Add(this.cmbPoliticalOrientation);
            this.grpPoliticalOrganization.Controls.Add(this.label2);
            this.grpPoliticalOrganization.Controls.Add(this.txtDetails);
            this.grpPoliticalOrganization.Controls.Add(this.label1);
            this.grpPoliticalOrganization.Location = new System.Drawing.Point(1, -5);
            this.grpPoliticalOrganization.Name = "grpPoliticalOrganization";
            this.grpPoliticalOrganization.Size = new System.Drawing.Size(285, 344);
            this.grpPoliticalOrganization.TabIndex = 17;
            this.grpPoliticalOrganization.TabStop = false;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPicture.Location = new System.Drawing.Point(237, 152);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(33, 16);
            this.btnAddPicture.TabIndex = 17;
            this.btnAddPicture.Text = "Add";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDocument.Location = new System.Drawing.Point(237, 240);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(33, 15);
            this.btnAddDocument.TabIndex = 18;
            this.btnAddDocument.Text = "Add";
            this.btnAddDocument.UseVisualStyleBackColor = true;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.Enabled = false;
            this.txtDocumentName.Location = new System.Drawing.Point(170, 256);
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentName.TabIndex = 21;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // cmbPictureId
            // 
            this.cmbPictureId.FormattingEnabled = true;
            this.cmbPictureId.Location = new System.Drawing.Point(153, 288);
            this.cmbPictureId.Name = "cmbPictureId";
            this.cmbPictureId.Size = new System.Drawing.Size(121, 21);
            this.cmbPictureId.TabIndex = 22;
            this.cmbPictureId.Visible = false;
            // 
            // cmbFileId
            // 
            this.cmbFileId.FormattingEnabled = true;
            this.cmbFileId.Location = new System.Drawing.Point(153, 309);
            this.cmbFileId.Name = "cmbFileId";
            this.cmbFileId.Size = new System.Drawing.Size(121, 21);
            this.cmbFileId.TabIndex = 23;
            this.cmbFileId.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(24, 309);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 24;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // frmAddPoliticalOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 337);
            this.Controls.Add(this.grpPoliticalOrganization);
            this.Name = "frmAddPoliticalOrganization";
            this.Text = "frmAddPoliticalOrganization";
            this.Load += new System.EventHandler(this.frmAddPoliticalOrganization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcOrdinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upldPicture)).EndInit();
            this.grpPoliticalOrganization.ResumeLayout(false);
            this.grpPoliticalOrganization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.NumericUpDown nmrcOrdinal;
        private System.Windows.Forms.ComboBox cmbCityId;
        private System.Windows.Forms.PictureBox upldPicture;
        private System.Windows.Forms.ComboBox cmbPoliticalOrientation;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpPoliticalOrganization;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDocumentName;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ComboBox cmbFileId;
        private System.Windows.Forms.ComboBox cmbPictureId;
        private System.Windows.Forms.Label lblError;
    }
}