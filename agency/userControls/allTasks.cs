using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace agency.userControls
{
    public partial class allTasks : UserControl
    {
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=agency.mdb;";
        public OleDbConnection myConnection;
        public string taskCode = "";
        public string managerCode = "";
        public allTasks()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectstring);
            zapol();
            zapolManager();
        }
        public void zapol()
        {
            dataGridView1.Rows.Clear();
            myConnection.Open();
            string quy = "SELECT Код, КраткоеОписание, ТипОбъявления FROM Объявления ORDER BY Код";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
            myConnection.Close();
        }
        public void zapolManager()
        {
            dataGridView2.Rows.Clear();
            myConnection.Open();
            string quy = "SELECT Код, Фамилия, Телефон FROM Сотрудники ORDER BY Код";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
            {
                dataGridView2.Rows.Add(s);
            }
            myConnection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            zapol();
            zapolManager();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            myConnection.Open();
            taskCode = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string quy = $"select * from Объявления where Код = {taskCode}";
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                buildPhoto.ImageLocation = reader[4].ToString();
                captchaText.Text = reader[1].ToString();
                typeTask.Text = reader[2].ToString();
                squareLabel.Text = reader[3].ToString();
            }
            reader.Close();
            myConnection.Close();
            panelTask.Visible = true;
        }

        private void addManager_Click(object sender, EventArgs e)
        {
            panelManagerAll.Visible = true;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            managerCode = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            string quy = $"insert into Заявки (Объявление, Сотрудник) values ({taskCode}, {managerCode})";
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(quy, myConnection);
            command.ExecuteNonQuery();
            panelManagerAll.Visible = false;
            panelTask.Visible = false;
            myConnection.Close();
        }

        private void closePanelTask_Click(object sender, EventArgs e)
        {
            panelTask.Visible = false;
            panelManagerAll.Visible = false;
            zapol();
            zapolManager();
        }

        private void panelManagerClose_Click(object sender, EventArgs e)
        {
            panelManagerAll.Visible = false;
        }
    }
}
