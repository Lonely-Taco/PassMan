using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
            instructionLabel.Text = "Creating new entry";
        }

        public Entry(string title, string username, string password)
        {
            InitializeComponent();
            titleTextbox.Text = title;
            usernameTextbox.Text = username;
            passwordTextbox.Text = password;
            instructionLabel.Text = "Editing entry";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //should save the inputs in the database
            backToDashboard();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            backToDashboard();
        }

        private void backToDashboard()
        {
            //go to dashboard
        }

        private void Entry_FormClosing(object sender, FormClosingEventArgs e)
        {
            backToDashboard();
        }
    }
}
