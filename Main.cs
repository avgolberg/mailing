using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Mailing__SMTP_
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addMailButton_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(emailTextBox.Text)) 
            { 
                emailsListBox.Items.Add(new MailAddress(emailTextBox.Text));
                emailsListBox.DisplayMember = "Address";
                emailTextBox.Text = "";
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                emailTextBox.BackColor = Color.Snow;
                return true;
            }
            catch
            {
                emailTextBox.BackColor = Color.LightCoral;
                return false;
            }
        }

        private void addThemeButton_Click(object sender, EventArgs e)
        {
            NewMail newMail = new NewMail();
            newMail.ShowDialog();
            if(newMail.DialogResult == DialogResult.OK)
            {
                themesComboBox.Items.Add(newMail.returnMail());
                themesComboBox.DisplayMember = "Subject";
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (themesComboBox.SelectedItem != null) 
            {
                string yourMail = "";
                string yourPassword = "";

                MailMessage mailMessage = (MailMessage)themesComboBox.SelectedItem;
                MailAddress from = new MailAddress(yourMail, "Test");

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
               
                smtp.Credentials = new NetworkCredential(yourMail, yourPassword);
                smtp.EnableSsl = true;

                foreach (MailAddress to in emailsListBox.Items)
                {
                    MailMessage mailToSend = new MailMessage(from.ToString(), to.ToString(), mailMessage.Subject, mailMessage.Body);
                    mailToSend.IsBodyHtml = true;
                    smtp.Send(mailToSend);
                }
            }
        }
    }
}
