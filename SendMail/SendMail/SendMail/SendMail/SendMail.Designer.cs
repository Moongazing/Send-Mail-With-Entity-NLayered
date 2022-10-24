namespace SendMail
{
  partial class SendMail
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.txtSender = new System.Windows.Forms.TextBox();
      this.txtSendTo = new System.Windows.Forms.TextBox();
      this.txtCC = new System.Windows.Forms.TextBox();
      this.txtSubject = new System.Windows.Forms.TextBox();
      this.rtxtBody = new System.Windows.Forms.RichTextBox();
      this.btnAddAttachment = new System.Windows.Forms.Button();
      this.btnSend = new System.Windows.Forms.Button();
      this.lblAttachmentName = new System.Windows.Forms.Label();
      this.lblDeleteAttachment = new System.Windows.Forms.Label();
      this.dgwMails = new System.Windows.Forms.DataGridView();
      this.cmbxMailStatus = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.txtSearchMail = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgwMails)).BeginInit();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.Location = new System.Drawing.Point(34, 67);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Sender :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(32, 98);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(70, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "Send To :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.Location = new System.Drawing.Point(34, 130);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 17);
      this.label4.TabIndex = 3;
      this.label4.Text = "CC :";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label5.Location = new System.Drawing.Point(32, 164);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(63, 17);
      this.label5.TabIndex = 4;
      this.label5.Text = "Subject :";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label6.Location = new System.Drawing.Point(34, 197);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(48, 17);
      this.label6.TabIndex = 5;
      this.label6.Text = "Body :";
      // 
      // txtSender
      // 
      this.txtSender.Location = new System.Drawing.Point(128, 67);
      this.txtSender.Margin = new System.Windows.Forms.Padding(2);
      this.txtSender.Name = "txtSender";
      this.txtSender.Size = new System.Drawing.Size(294, 20);
      this.txtSender.TabIndex = 6;
      // 
      // txtSendTo
      // 
      this.txtSendTo.Location = new System.Drawing.Point(128, 98);
      this.txtSendTo.Margin = new System.Windows.Forms.Padding(2);
      this.txtSendTo.Name = "txtSendTo";
      this.txtSendTo.Size = new System.Drawing.Size(294, 20);
      this.txtSendTo.TabIndex = 7;
      // 
      // txtCC
      // 
      this.txtCC.Location = new System.Drawing.Point(128, 130);
      this.txtCC.Margin = new System.Windows.Forms.Padding(2);
      this.txtCC.Name = "txtCC";
      this.txtCC.Size = new System.Drawing.Size(294, 20);
      this.txtCC.TabIndex = 8;
      // 
      // txtSubject
      // 
      this.txtSubject.Location = new System.Drawing.Point(128, 164);
      this.txtSubject.Margin = new System.Windows.Forms.Padding(2);
      this.txtSubject.Name = "txtSubject";
      this.txtSubject.Size = new System.Drawing.Size(294, 20);
      this.txtSubject.TabIndex = 9;
      // 
      // rtxtBody
      // 
      this.rtxtBody.Location = new System.Drawing.Point(128, 197);
      this.rtxtBody.Margin = new System.Windows.Forms.Padding(2);
      this.rtxtBody.Name = "rtxtBody";
      this.rtxtBody.Size = new System.Drawing.Size(294, 273);
      this.rtxtBody.TabIndex = 10;
      this.rtxtBody.Text = "";
      // 
      // btnAddAttachment
      // 
      this.btnAddAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnAddAttachment.Location = new System.Drawing.Point(128, 517);
      this.btnAddAttachment.Margin = new System.Windows.Forms.Padding(2);
      this.btnAddAttachment.Name = "btnAddAttachment";
      this.btnAddAttachment.Size = new System.Drawing.Size(293, 31);
      this.btnAddAttachment.TabIndex = 11;
      this.btnAddAttachment.Text = "Add Attachment";
      this.btnAddAttachment.UseVisualStyleBackColor = true;
      this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);
      // 
      // btnSend
      // 
      this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnSend.Location = new System.Drawing.Point(128, 552);
      this.btnSend.Margin = new System.Windows.Forms.Padding(2);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new System.Drawing.Size(293, 32);
      this.btnSend.TabIndex = 12;
      this.btnSend.Text = "Send";
      this.btnSend.UseVisualStyleBackColor = true;
      this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
      // 
      // lblAttachmentName
      // 
      this.lblAttachmentName.AutoSize = true;
      this.lblAttachmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblAttachmentName.Location = new System.Drawing.Point(125, 498);
      this.lblAttachmentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblAttachmentName.Name = "lblAttachmentName";
      this.lblAttachmentName.Size = new System.Drawing.Size(20, 17);
      this.lblAttachmentName.TabIndex = 13;
      this.lblAttachmentName.Text = "...";
      // 
      // lblDeleteAttachment
      // 
      this.lblDeleteAttachment.AutoSize = true;
      this.lblDeleteAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblDeleteAttachment.Location = new System.Drawing.Point(405, 472);
      this.lblDeleteAttachment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblDeleteAttachment.Name = "lblDeleteAttachment";
      this.lblDeleteAttachment.Size = new System.Drawing.Size(17, 17);
      this.lblDeleteAttachment.TabIndex = 14;
      this.lblDeleteAttachment.Text = "X";
      this.lblDeleteAttachment.Click += new System.EventHandler(this.lblDeleteAttachment_Click);
      // 
      // dgwMails
      // 
      this.dgwMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgwMails.Location = new System.Drawing.Point(455, 197);
      this.dgwMails.Margin = new System.Windows.Forms.Padding(2);
      this.dgwMails.Name = "dgwMails";
      this.dgwMails.RowHeadersWidth = 51;
      this.dgwMails.RowTemplate.Height = 24;
      this.dgwMails.Size = new System.Drawing.Size(356, 184);
      this.dgwMails.TabIndex = 15;
      this.dgwMails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMails_CellClick);
      this.dgwMails.SelectionChanged += new System.EventHandler(this.dgwMails_SelectionChanged);
      // 
      // cmbxMailStatus
      // 
      this.cmbxMailStatus.FormattingEnabled = true;
      this.cmbxMailStatus.Items.AddRange(new object[] {
            "All",
            "Sent",
            "Deleted",
            "Task"});
      this.cmbxMailStatus.Location = new System.Drawing.Point(643, 98);
      this.cmbxMailStatus.Margin = new System.Windows.Forms.Padding(2);
      this.cmbxMailStatus.Name = "cmbxMailStatus";
      this.cmbxMailStatus.Size = new System.Drawing.Size(168, 21);
      this.cmbxMailStatus.TabIndex = 16;
      this.cmbxMailStatus.SelectedIndexChanged += new System.EventHandler(this.cmbxMailStatus_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(495, 98);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(102, 17);
      this.label1.TabIndex = 17;
      this.label1.Text = "List By Status :";
      // 
      // btnExit
      // 
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnExit.Location = new System.Drawing.Point(692, 552);
      this.btnExit.Margin = new System.Windows.Forms.Padding(2);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(103, 32);
      this.btnExit.TabIndex = 18;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnDelete.Location = new System.Drawing.Point(708, 385);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(103, 24);
      this.btnDelete.TabIndex = 19;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnUpdate.Location = new System.Drawing.Point(601, 385);
      this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(103, 24);
      this.btnUpdate.TabIndex = 20;
      this.btnUpdate.Text = "Update";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // txtSearchMail
      // 
      this.txtSearchMail.Location = new System.Drawing.Point(643, 139);
      this.txtSearchMail.Name = "txtSearchMail";
      this.txtSearchMail.Size = new System.Drawing.Size(168, 20);
      this.txtSearchMail.TabIndex = 21;
      this.txtSearchMail.TextChanged += new System.EventHandler(this.txtSearchMail_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label7.Location = new System.Drawing.Point(495, 142);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(139, 17);
      this.label7.TabIndex = 22;
      this.label7.Text = "List By Mail Address:";
      // 
      // SendMail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(818, 602);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtSearchMail);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbxMailStatus);
      this.Controls.Add(this.dgwMails);
      this.Controls.Add(this.lblDeleteAttachment);
      this.Controls.Add(this.lblAttachmentName);
      this.Controls.Add(this.btnSend);
      this.Controls.Add(this.btnAddAttachment);
      this.Controls.Add(this.rtxtBody);
      this.Controls.Add(this.txtSubject);
      this.Controls.Add(this.txtCC);
      this.Controls.Add(this.txtSendTo);
      this.Controls.Add(this.txtSender);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "SendMail";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Mail";
      this.Load += new System.EventHandler(this.SendMail_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgwMails)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtSendTo;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.RichTextBox rtxtBody;
        private System.Windows.Forms.Button btnAddAttachment;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblAttachmentName;
        private System.Windows.Forms.Label lblDeleteAttachment;
        private System.Windows.Forms.DataGridView dgwMails;
        private System.Windows.Forms.ComboBox cmbxMailStatus;
        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearchMail;
        private System.Windows.Forms.Label label7;
    }
}

