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
    public partial class allManagers : UserControl
    {
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=agency.mdb;";
        public OleDbConnection myConnection;
        public string filePath = string.Empty;
        public string managerCode = string.Empty;
        public string imageLocation = string.Empty;
        public allManagers()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectstring);
            zapol();
        }
        public void zapol()
        {
            dataGridView1.Rows.Clear();
            myConnection.Open();
            string quy = $"select Код, Фамилия, Имя, Отчество from Сотрудники order by Код";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
            myConnection.Close();
        }
        public void clear()
        {
            filePath = string.Empty;
            managerCode = string.Empty;
            imageLocation = string.Empty;
            managerPhoto.ImageLocation = null;
            surnameInput.Text = "";
            nameInput.Text = "";
            secondNameInput.Text = "";
            numberInput.Text = "";
            loginInput.Text = "";
        }

        private void addManager_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            clear();
            managerPanel.Visible = true;
            string kost = "insert into Сотрудники (Фамилия, Имя, Отчество, Телефон, Логин, Фото) values ('','','','','','')";
            OleDbCommand kostCommand = new OleDbCommand(kost, myConnection);
            kostCommand.ExecuteNonQuery();


            string quy = "select top 1 Код from Сотрудники order by Код desc";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                managerCode = reader[0].ToString();
            }
            reader.Close();
            myConnection.Close();
        }

        private void saveManager_Click(object sender, EventArgs e)
        {
            try
            {
                
                myConnection.Open();
                string path = $@"images\managers\{managerCode}";
                if (imageLocation == string.Empty)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(path);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }
                    File.Copy(filePath, Path.Combine(path, "photo.jpg"), true);
                }
                string quy = $"update Сотрудники set " +
                    $"Фамилия = '{surnameInput.Text}'," +
                    $"Имя = '{nameInput.Text}'," +
                    $"Отчество = '{secondNameInput.Text}'," +
                    $"Телефон = '{numberInput.Text}'," +
                    $"Логин = '{loginInput.Text}'," +
                    $"Фото = '{Path.Combine(path, "photo.jpg")}' where Код = {Convert.ToInt32(managerCode)}";
                OleDbCommand command = new OleDbCommand(quy, myConnection);
                command.ExecuteNonQuery();

                managerPanel.Visible = false;
                clear();
                myConnection.Close();
                zapol();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность и наличие всех данных, либо обратитесь в поддержку", "Ошибка");
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            myConnection.Open();
            managerCode = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string quy = $"select * from Сотрудники where Код = {managerCode}";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                imageLocation = reader[6].ToString();
                managerPhoto.ImageLocation = reader[6].ToString();
                surnameInput.Text = reader[1].ToString();
                nameInput.Text = reader[2].ToString();
                secondNameInput.Text = reader[3].ToString();
                numberInput.Text = reader[4].ToString();
                loginInput.Text = reader[5].ToString();
            }
            reader.Close();
            myConnection.Close();
            managerPanel.Visible = true;
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
            managerPhoto.ImageLocation = filePath;
            managerPhoto.BorderStyle = BorderStyle.None;
        }

        private void numberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
