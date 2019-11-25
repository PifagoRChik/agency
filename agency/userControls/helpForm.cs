using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;
using System.Windows.Forms;
using System.Net.Mime;

namespace agency.userControls
{
    public partial class helpForm : UserControl
    {
        public string filePath = string.Empty;
        public helpForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (messageInput.Text == "" || mailInput.Text == "")
            {
                MessageBox.Show("Отсутствует информация для отправки или почта для обратной связи", "Пустые значения");
            }
            else
            {
                try
                {
                    MailMessage message1 = new MailMessage("newhouse.bonch@bk.ru", "voznesenskiy.shura@gmail.com", "Ошибки программы", "Описание ошибки от пользователя.\n" + messageInput.Text + "\nПочта для обратной связи - " + mailInput.Text);
                    SmtpClient client = new SmtpClient("smtp.mail.ru");
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential("newhouse.bonch@bk.ru", "lZb43rQv27");
                    client.EnableSsl = true;
                    if (filePath != string.Empty)
                    {
                        Attachment data = new Attachment(filePath, MediaTypeNames.Application.Octet);
                        ContentDisposition disposition = data.ContentDisposition;
                        disposition.CreationDate = File.GetCreationTime(filePath);
                        disposition.ModificationDate = File.GetLastWriteTime(filePath);
                        disposition.ReadDate = File.GetLastAccessTime(filePath);
                        message1.Attachments.Add(data);
                    }
                    client.Send(message1);

                    MailMessage message2 = new MailMessage("newhouse.bonch@bk.ru", mailInput.Text, "Ошибки программы", "Ваше сообщение принято на рассмотрение, благодарим за сотрудничество!\nВ скором времени с вами свяжутся, ожидайте.");
                    SmtpClient client1 = new SmtpClient("smtp.mail.ru");
                    client1.Port = 587;
                    client1.Credentials = new System.Net.NetworkCredential("newhouse.bonch@bk.ru", "lZb43rQv27");
                    client1.EnableSsl = true;
                    client1.Send(message2);

                    mailInput.Text = "";
                    messageInput.Text = "";
                    filePath = string.Empty;
                    MessageBox.Show("Ваше сообщение отправлено", "Успешно");
                }
                catch
                {
                    MessageBox.Show("Возникла ошибка, попробуйте еще раз либо обратитесь в техподдержку","Ошибка");
                }
                
            }
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
        }
    }
}
