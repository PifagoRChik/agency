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
        public static string connectstring = "provider=microsoft.jet.oledb.4.0;data source=comission.mdb;";
        public OleDbConnection myConnection;
        public string filePath = string.Empty;
        public addTask()
        {
            InitializeComponent();
            typeTask.SelectedIndex = 0;
            myConnection = new OleDbConnection(connectstring);
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
            string quy = "select";
            if(aboutTask.Text == "" || squareTextbox.Text == "")
            {
                MessageBox.Show("Проверьте наличие всех внесенных данных", "Внимание");
            }
            else
            {
                string path = $@"images\{passportInput.Text}";

            }
        }
    }
}
