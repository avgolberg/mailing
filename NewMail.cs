using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Mailing__SMTP_
{
    public partial class NewMail : Form
    {
        MailMessage mail = new MailMessage();
        public NewMail()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                mail.Subject = textBox1.Text;
                mail.Body = richTextBox1.Text;
            }
        } 

        public MailMessage returnMail()
        {
            return mail;
        }
    }
}
