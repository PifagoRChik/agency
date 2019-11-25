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
        public allManagers()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectstring);
            zapol();
        }
        public void zapol()
        {
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
    }
}
