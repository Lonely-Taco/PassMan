using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PasswordManager
{
    public partial class EditEntry : Form
    {

        DB dashboard;
        public EditEntry(DB dashboard)
        {
            InitializeComponent();
            instructionLabel.Text = "Creating new entry";
            this.dashboard = dashboard;

        }

        public EditEntry(string title, string username, string password)
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
            String title = titleTextbox.Text;
            String userName = usernameTextbox.Text;
            String password = passwordTextbox.Text;
            Login login = new Login(dashboard);
            String path = login.GetFilePath();
            if (File.Exists(path))
            {

               
               XDocument xDocument = XDocument.Load(path);
                //XDocument xDocument = XDocument.Load("C://Users/Ramon Gonzalez/Desktop/database.xml");
                XElement root = xDocument.Element("Database");
                IEnumerable<XElement> rows = root.Descendants("DatabaseName");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement(title,
                   new XElement("Username", userName),
                   new XElement("Password", password)));

                xDocument.Save("C://Users/Solomon/Desktop/database.xml");
            }
           backToDashboard();
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            backToDashboard();
        }

        private void backToDashboard()
        {
            //dashboard.Show();
            this.Hide();
        }

        private void Entry_FormClosing(object sender, FormClosingEventArgs e)
        {
            backToDashboard();
        }
    }
}
