using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Net.Mail;

namespace agency
{
    public partial class Form1 : Form
    {
        // Подключение БД
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=agency.mdb;";
        public OleDbConnection myConnection;
        Random random = new Random();
        string code = "";
        public Form1()
        {
            InitializeComponent();
        }
        public string GetHash(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectstring);
            myConnection.Open();
            //string login = loginInput.Text;
            //string password = GetHash(passwordInput.Text);
            string login = "voznesenskiy.shura@gmail.com";
            string password = GetHash("lZb43rQv27");
            string quy = $"SELECT Логин, Пароль FROM Пароли WHERE Логин = '{login}'";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            string loginFromDatabase = "";
            string passwordFromDatabase = "";
            while (reader.Read())
            {
                loginFromDatabase = reader[0].ToString();
                passwordFromDatabase = reader[1].ToString();
            }
            reader.Close();

            if (login == "" || password == "")
            {
                MessageBox.Show("Вы не ввели логин или пароль");
                myConnection.Close();
            }
            else if (login == loginFromDatabase && password == passwordFromDatabase)
            {
                mainForm newf = new mainForm();
                newf.Show();
                this.Hide();
                myConnection.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                myConnection.Close();
            }
            myConnection.Close();
        }

        private void registrationLabel_Click(object sender, EventArgs e)
        {
            registrationPanel.Visible = true;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectstring);
            myConnection.Open();

            string quy = $"SELECT Логин FROM Пароли WHERE Логин = '{newLoginInput.Text}'";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            string loginFromDatabase = "";
            while (reader.Read())
            {
                loginFromDatabase = reader[0].ToString();
            }
            reader.Close();
            myConnection.Close();
            if(loginFromDatabase != "")
            {
                MessageBox.Show("Учетная запись с таким логином уже существует", "Ошибка");
            }
            else
            {
                if (newPasswordInput.Text == newPasswordSecondInput.Text)
                {
                    verificationCodeInput.Visible = true;
                    verificationLabel.Visible = true;
                    code = Convert.ToString(random.Next(10000, 99999));
                    MailMessage message = new MailMessage("newhouse.bonch@bk.ru", newLoginInput.Text, "Подтверждение регистрации", "Ваш код подтверждения - " + code);
                    SmtpClient client = new SmtpClient("smtp.mail.ru");
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential("newhouse.bonch@bk.ru", "lZb43rQv27");
                    client.EnableSsl = true;
                    client.Send(message);
                }
                else
                {
                    MessageBox.Show("Введите пароль еще раз", "Пароли не совпадают");
                }
            }
        }

        private void closeRegistration_Click(object sender, EventArgs e)
        {
            newLoginInput.Text = "";
            newPasswordInput.Text = "";
            newPasswordSecondInput.Text = "";
            verificationCodeInput.Text = "";
            registrationPanel.Visible = false;
            verificationCodeInput.Visible = false;
            verificationLabel.Visible = false;
        }

        private void verificationCodeInput_OnValueChanged(object sender, EventArgs e)
        {
            if (code == verificationCodeInput.Text)
            {
                myConnection = new OleDbConnection(connectstring);
                myConnection.Open();
                string quy = $"INSERT INTO Пароли (Логин, Пароль) VALUES ('{newLoginInput.Text}', '{GetHash(newPasswordInput.Text)}')";
                OleDbCommand command = new OleDbCommand(quy, myConnection);
                command.ExecuteNonQuery();
                closeRegistration_Click(sender, e);
            }
        }
    }
}
