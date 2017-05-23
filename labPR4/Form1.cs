using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MailAddress = System.Net.Mail.MailAddress;
using System.Threading.Tasks;
using OpenPop.Pop3;
using System.Collections.Generic;
using System.IO;

namespace labPR4
{
    public partial class Form1 : Form
    {     //pachet care contine functionalu ptu lucru cu prot POP3
        List<OpenPop.Mime.Message> ListMessages;
        List<string> Atasamente;
        public Form1()
        {
            InitializeComponent();
            Atasamente = new List<string>();
            ListMessages = new List<OpenPop.Mime.Message>();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var smtpServer = new SmtpClient("smtp.gmail.com");
                var mail = new MailMessage();

                mail.From = new MailAddress(myEmail.Text);
                mail.To.Add(recieveEmail.Text);
                mail.Subject = mySubject.Text;
                mail.Body = txtbody.Text;
                smtpServer.Port = 587;
                smtpServer.UseDefaultCredentials = false;
                smtpServer.EnableSsl = true;
                if (!(Atasamente.Count == 0))
                {
                    Atasamente.ForEach(element =>
                    {
                        var _attachment = new Attachment(element);
                        mail.Attachments.Add(_attachment);
                    });
                }
                    if (checkBox1.Enabled)
                    {
                        mail.IsBodyHtml = true;
                        mail.Body ="<html><head></head><body>"+ mail.Body + "</body></html>";
                    }
                    else
                    {
                        mail.IsBodyHtml = false;
                    }
                smtpServer.Credentials = new NetworkCredential(myEmail.Text, myPassword.Text);
                smtpServer.SendAsync(mail, new object());
                smtpServer.SendCompleted += (obj, ew) => { MessageBox.Show("Sent"); };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var listMessages = await GmailsRetrievePOPAsync(inboxEmail.Text, inboxPassword.Text);

            listView1.View = View.Tile;

              

            listMessages.ForEach(element =>
            {  //adaugarea in listView daca are subiect ,daca nare adauga (no subject +data )
                listView1.Items.Add(!element.Headers.Subject.Equals(string.Empty) ? element.Headers.Subject : "(no subject)~" + element.Headers.Date);
            });

            ListMessages = listMessages;
            listView1.Click += ListView1_Click;
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            var mail = ListMessages.FirstOrDefault(x => x.Headers.Subject.Equals(listView1.SelectedItems[0].Text));
            if (mail == null)
            {
                mail = ListMessages.FirstOrDefault(x => x.Headers.Date.Equals(listView1.SelectedItems[0].Text.Split('~').ElementAt(1)));
            }
            OpenPop.Mime.MessagePart BodyString;
            if (mail.FindFirstHtmlVersion() != null)
                BodyString = mail.FindFirstHtmlVersion();
            else
                BodyString = mail.FindFirstPlainTextVersion();
            const string _fileSaveMail = "lastMail.html";
            BodyString.Save(new FileInfo(_fileSaveMail));

            string _savedInstance = string.Empty;

            using (var file = new FileStream(_fileSaveMail, FileMode.Open))
            {
                using (var stream = new StreamReader(file))
                {
                    _savedInstance = stream.ReadToEnd();
                }
            }

            webBrowser1.DocumentText = _savedInstance;
        }

        public static Task<List<OpenPop.Mime.Message>> GmailsRetrievePOPAsync(string Email, string Password)
        {
               //fac in task run ca sa putem implimenta metoda asyncron 
            return Task.Run(() =>
            {
                List<OpenPop.Mime.Message> emailList = new List<OpenPop.Mime.Message>();
                //stream
                using (Pop3Client pop3Client = new Pop3Client())
                {
                    pop3Client.Connect("pop.gmail.com", 995, true);
                    try
                    {
                        pop3Client.Authenticate("recent:" + Email, Password, AuthenticationMethod.UsernameAndPassword);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        return emailList;
                    }
                      //cite mesaje primite 
                    int MailsCount = pop3Client.GetMessageCount();
                    for (var i = MailsCount; i > 0; i--)
                    {
                        emailList.Add(pop3Client.GetMessage(i));
                    }
                }
                return emailList;

            });

        }

        private void buttonAttachments_Click(object sender, EventArgs e)
        {
            OpenFileDialog _filesDialog = new OpenFileDialog();
            if (_filesDialog.ShowDialog() == DialogResult.OK)
            {
                Atasamente.Add(_filesDialog.FileName);
            }
        }

    }
}
