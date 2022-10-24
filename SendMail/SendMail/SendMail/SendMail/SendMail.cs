using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SendMail.DataAccess.Concrete.Entity_Framework;
using SendMail.Business.Abstract;
using SendMail.Business.Concrete;
using SendMail.Entities.Concrete;


namespace SendMail
{
  public partial class SendMail : Form
  {
    public SendMail()
    {
      InitializeComponent();
      _mailService = new MailManager(new EfMailDal());
      //_trashMailService = new TrashMailManager(new EfTrashMailDal());
    }

    private IMailService _mailService;
    // private ITrashMailService _trashMailService;

    string filePath = ""; //For attachment 
    bool isMailSent = false; // For task mails 

    /*Check Fields*/
    private bool CheckFields()
    {
      if (!String.IsNullOrEmpty(txtSendTo.Text) && !String.IsNullOrEmpty(txtCC.Text) && !String.IsNullOrEmpty(txtSubject.Text) && !String.IsNullOrEmpty(rtxtBody.Text))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
   

    /*Load Mails*/
    private void LoadMails()
    {

      dgwMails.DataSource = _mailService.GetAll();

    }


    /*Clear Fileds After Sending*/
    private void ClearFields()
    {
      foreach (Control item in Controls)
      {
        if (item is TextBox || item is RichTextBox)
        {
          item.Text = String.Empty;
        }
        lblAttachmentName.Text = "...";
      }
    }


    /*Save Mail at Database*/
    public void SaveMail()
    {
      try
      {

        _mailService.Add(new Mail
        {
          Sender = ""//you should your mail adress,
          SendTo = txtSendTo.Text,
          CC = txtCC.Text,
          Subject = txtSubject.Text,
          Body = rtxtBody.Text,
          SentDate = DateTime.Today,
          Status = "Sent"
        });
        MessageBox.Show("Mail Saved!");
      }
      catch (Exception exception)
      {

        MessageBox.Show(exception.Message);

      }
    }

    /*Delete Mail*/
    private void DeleteMail()
    {

      _mailService.Delete(new Mail
      {
        Id = Convert.ToInt32(dgwMails.CurrentRow.Cells[0].Value)
      });
      MessageBox.Show("Mail deleted!");

      LoadMails();
    }
    private void UpdateMail()
    {
      _mailService.Update(new Mail
      {
        Id = Convert.ToInt32(dgwMails.CurrentRow.Cells[0].ToString()),
        Sender = "tunahan.ali.ozturk@outlook.com",
        SendTo = txtSendTo.Text,
        CC = txtCC.Text,
        Subject = txtSubject.Text,
        Body = rtxtBody.Text,
        SentDate = DateTime.Today,
        Status = "Sent"

      });
    }

    /*Sending Mail*/
    public static string MailSender(string mailTo, string title, string mail, string mailCC, string attachPath)
    {

      string mailClient = "smtp.office365.com", //smtp client
              mailSender = "", //sender mail
              senderMailPassword = ""; //sender mail password

      try
      {
        SmtpClient smtpClient = new SmtpClient();
        MailMessage mailMessage = new MailMessage();
        mailMessage.To.Add(mailTo);

        if (mailCC != null)
        {
          mailMessage.CC.Add(mailCC);
        }
        if (attachPath != null)
        {
          Attachment attachment = new Attachment(attachPath, MediaTypeNames.Application.Octet);
          mailMessage.Attachments.Add(attachment);
        }


        mailMessage.From = new MailAddress(mailSender);
        mailMessage.Subject = title;
        mailMessage.IsBodyHtml = true;
        mailMessage.Body = mail;

        NetworkCredential networkCredential = new NetworkCredential(mailSender, senderMailPassword);
        smtpClient.Credentials = networkCredential;
        smtpClient.Port = 587;
        smtpClient.Host = mailClient;
        smtpClient.EnableSsl = true;
        smtpClient.Send(mailMessage);

        smtpClient = null;
        mailMessage = null;
        networkCredential = null;


        return "Mail sent.";

      }
      catch (Exception exception)
      {

        return exception.Message;

      }
    }


    private void SendMail_Load(object sender, EventArgs e)
    {
      ClearFields();
      LoadMails();
      dgwMails.Rows[0].Cells[0].Selected = false;
    }


    /*Call the send methos after click*/
    private void btnSend_Click(object sender, EventArgs e)
    {
      if (CheckFields() == true)
      {
        if (filePath == "") //If user didn't attach file
        {
          string resultWithAttach = MailSender(txtSendTo.Text, txtSubject.Text, rtxtBody.Text, txtCC.Text, null);
          MessageBox.Show(resultWithAttach);
          isMailSent = true;
          SaveMail();
          ClearFields();
        }
        else //User add attach
        {
          string result = MailSender(txtSendTo.Text, txtSubject.Text, rtxtBody.Text, txtCC.Text, filePath);
          MessageBox.Show(result);
          isMailSent = true;
          SaveMail();
          ClearFields();
        }
      }
      else
      {
        MessageBox.Show("!");
      }
    }


    /*Adding attachment with ofd*/
    private void btnAddAttachment_Click(object sender, EventArgs e)
    {

      OpenFileDialog mailAttachment = new OpenFileDialog();
      mailAttachment.Title = "Add File";
      mailAttachment.ShowDialog();
      filePath = mailAttachment.FileName;
      byte[] fileBytes = File.ReadAllBytes(filePath);
      string fileName = Path.GetFileName(filePath);
      lblAttachmentName.Text = fileName;
    }

    private void lblDeleteAttachment_Click(object sender, EventArgs e)
    {
      filePath = "";
      lblAttachmentName.Text = "...";
    }

    /*Datagrid Evets*/

    private void dgwMails_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      var row = dgwMails.CurrentRow;
      txtSender.Text = row.Cells[1].Value.ToString();
      txtSendTo.Text = row.Cells[2].Value.ToString();
      txtCC.Text = row.Cells[3].Value.ToString();
      txtSubject.Text = row.Cells[4].Value.ToString();
      rtxtBody.Text = row.Cells[5].Value.ToString();

    }

    private void dgwMails_SelectionChanged(object sender, EventArgs e)
    {
      dgwMails.DefaultCellStyle.SelectionBackColor = Color.Green;
    }


    private void cmbxMailStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbxMailStatus.SelectedIndex == 0)
      {
        LoadMails();
      }
      else
      {
        dgwMails.DataSource = _mailService.GetMailsByStatus(cmbxMailStatus.SelectedItem.ToString());
      }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      DialogResult exit;

      if (CheckFields() == true && isMailSent == false)
      {
        DialogResult saveTask = MsgTypes.QuestionMessage("Do you want to save task?");
        if (saveTask == DialogResult.Yes)
        {
          _mailService.Add(new Mail
          {
            Sender = "tunahan.ali.ozturk@outlook.com",
            SendTo = txtSendTo.Text,
            CC = txtCC.Text,
            Subject = txtSubject.Text,
            Body = rtxtBody.Text,
            SentDate = DateTime.Today,
            Status = "Task"
          });
        }
        else
        {
          exit = MsgTypes.QuestionMessage("Do you want to quit?");
          if (exit == DialogResult.Yes)
          {
            Application.Exit();
          }
        }
      }
      else
      {
        exit = MsgTypes.QuestionMessage("Do you want to quit?");
        if (exit == DialogResult.Yes)
        {
          Application.Exit();
        }
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (dgwMails.CurrentRow != null)
      {
        DeleteMail();
      }
      else
      {
        MessageBox.Show("Please select at least one mail.");
      }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      UpdateMail();
    }

    private void txtSearchMail_TextChanged(object sender, EventArgs e)
    {
      if (!String.IsNullOrEmpty(txtSearchMail.Text))
      {
        dgwMails.DataSource = _mailService.GetMailByAdress(txtSearchMail.Text);
      }
      else
      {
        LoadMails();
      }
    }
  }
}
