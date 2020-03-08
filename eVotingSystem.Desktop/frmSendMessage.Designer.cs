namespace eVotingSystem.Desktop
{
    partial class frmSendMessage
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
            this.cmbRecieverId = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbSenderId = new System.Windows.Forms.ComboBox();
            this.cmbPictureId = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstMessages = new System.Windows.Forms.DataGridView();
            this.grpMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send to user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content";
            // 
            // cmbRecieverId
            // 
            this.cmbRecieverId.FormattingEnabled = true;
            this.cmbRecieverId.Location = new System.Drawing.Point(31, 73);
            this.cmbRecieverId.Name = "cmbRecieverId";
            this.cmbRecieverId.Size = new System.Drawing.Size(121, 21);
            this.cmbRecieverId.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(31, 113);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(121, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(32, 155);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(276, 82);
            this.txtContent.TabIndex = 6;
            this.txtContent.Text = "";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(31, 244);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(277, 36);
            this.btnSendMessage.TabIndex = 8;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // grpMessage
            // 
            this.grpMessage.Controls.Add(this.lblError);
            this.grpMessage.Controls.Add(this.cmbSenderId);
            this.grpMessage.Controls.Add(this.cmbPictureId);
            this.grpMessage.Controls.Add(this.label1);
            this.grpMessage.Controls.Add(this.btnSendMessage);
            this.grpMessage.Controls.Add(this.label2);
            this.grpMessage.Controls.Add(this.label3);
            this.grpMessage.Controls.Add(this.txtContent);
            this.grpMessage.Controls.Add(this.txtTitle);
            this.grpMessage.Controls.Add(this.cmbRecieverId);
            this.grpMessage.Location = new System.Drawing.Point(1, 1);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(333, 329);
            this.grpMessage.TabIndex = 9;
            this.grpMessage.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(31, 283);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(64, 13);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Invalid input";
            this.lblError.Visible = false;
            // 
            // cmbSenderId
            // 
            this.cmbSenderId.FormattingEnabled = true;
            this.cmbSenderId.Location = new System.Drawing.Point(31, 34);
            this.cmbSenderId.Name = "cmbSenderId";
            this.cmbSenderId.Size = new System.Drawing.Size(121, 21);
            this.cmbSenderId.TabIndex = 11;
            this.cmbSenderId.Visible = false;
            // 
            // cmbPictureId
            // 
            this.cmbPictureId.FormattingEnabled = true;
            this.cmbPictureId.Location = new System.Drawing.Point(31, 287);
            this.cmbPictureId.Name = "cmbPictureId";
            this.cmbPictureId.Size = new System.Drawing.Size(121, 21);
            this.cmbPictureId.TabIndex = 10;
            this.cmbPictureId.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstMessages
            // 
            this.lstMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstMessages.Location = new System.Drawing.Point(366, 35);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(397, 262);
            this.lstMessages.TabIndex = 10;
            // 
            // frmSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 336);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.grpMessage);
            this.Name = "frmSendMessage";
            this.Text = "frmSendMessage";
            this.Load += new System.EventHandler(this.frmSendMessage_Load);
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRecieverId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.GroupBox grpMessage;
        private System.Windows.Forms.ComboBox cmbPictureId;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbSenderId;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView lstMessages;
    }
}