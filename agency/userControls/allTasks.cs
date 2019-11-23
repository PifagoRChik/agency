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
        public allTasks()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectstring);
            zapol();
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
                dataGridView1.Rows.Add(s);
            }
            myConnection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            zapol();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {


                panelTask.Visible = true;
            }
            else
            {
                MessageBox.Show("Выберите, пожалуйста, объявление", "Ошибка");
            }
        }

        private void addManager_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
