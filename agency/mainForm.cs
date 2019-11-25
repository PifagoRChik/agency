using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agency
{
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
           
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == false)
                bunifuTransition1.ShowSync(menuPanel);
            else if (menuPanel.Visible == true)
                bunifuTransition1.HideSync(menuPanel);
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            allManagers1.Visible = false;
            allTasks1.Visible = true;
            helpForm1.Visible = false;
            addTask1.Visible = false;
            sidePanel.Height = allButton.Height;
            sidePanel.Top = allButton.Top;
            bunifuTransition1.HideSync(menuPanel);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            allTasks1.Visible = false;
            allManagers1.Visible = false; 
            helpForm1.Visible = false;
            addTask1.Visible = true;
            sidePanel.Height = addButton.Height;
            sidePanel.Top = addButton.Top;
            bunifuTransition1.HideSync(menuPanel);
        }

        private void managersButton_Click(object sender, EventArgs e)
        {
            allTasks1.Visible = false;
            helpForm1.Visible = false;
            addTask1.Visible = false;
            allManagers1.Visible = true;
            sidePanel.Height = managersButton.Height;
            sidePanel.Top = managersButton.Top;
            bunifuTransition1.HideSync(menuPanel);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            allTasks1.Visible = false;
            addTask1.Visible = false;
            allManagers1.Visible = false;
            helpForm1.Visible = true;
            sidePanel.Height = helpButton.Height;
            sidePanel.Top = helpButton.Top;
            bunifuTransition1.HideSync(menuPanel);
        }
    }
}
