using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;


namespace agency.userControls
{
    public partial class addTask : UserControl
    {
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=agency.mdb;";
        public OleDbConnection myConnection;
        public string filePath = string.Empty;
        public addTask()
        {
            InitializeComponent();
            typeTask.SelectedIndex = 0;
            myConnection = new OleDbConnection(connectstring);
        }
        public void clearAll()
        {
            aboutTask.Text = "";
            squareTextbox.Text = "";
            typeTask.SelectedIndex = 0;
            photoBox.Image = null;
            photoBox.BorderStyle = BorderStyle.FixedSingle;
        }
        private void addPhoto_Click(object sender, EventArgs e)
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
            photoBox.ImageLocation = filePath;
            photoBox.BorderStyle = BorderStyle.None;
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            
            if (aboutTask.Text == "" || squareTextbox.Text == "")
            {
                MessageBox.Show("Проверьте наличие всех внесенных данных", "Внимание");
            }
            else
            {
                string kost = "insert into Объявления (КраткоеОписание, ТипОбъявления, Площадь, Фото) values ('','','','')";
                OleDbCommand kostCommand = new OleDbCommand(kost, myConnection);
                kostCommand.ExecuteNonQuery();

                string quy = "select top 1 Код from Объявления order by Код desc";
                OleDbCommand command = new OleDbCommand(quy, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
                string maxCode = "";
                while (reader.Read())
                {
                    maxCode = reader[0].ToString();
                }
                reader.Close();

                string path = $@"images\{maxCode}";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                File.Copy(filePath, Path.Combine(path, "photo.jpg"), true);
                string requestFinal = $"update Объявления set " +
                    $"КраткоеОписание = '{aboutTask.Text}'," +
                    $"ТипОбъявления = '{typeTask.SelectedItem.ToString()}'," +
                    $"Площадь = '{squareTextbox.Text}'," +
                    $"Фото = '{Path.Combine(path, "photo.jpg")}' where Код = {maxCode}";
                OleDbCommand requestFinalCommand = new OleDbCommand(requestFinal, myConnection);
                requestFinalCommand.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено!", "Success");
                clearAll();
            }
            myConnection.Close();
        }

        private void squareTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
