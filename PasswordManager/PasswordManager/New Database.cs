using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace PasswordManager
{
    public partial class new_DB : Form
    {
        DB dashboard;
        public new_DB(DB dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void cancle_crte_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void crte_new_DB_Btn_Click(object sender, EventArgs e)
        {
            //check for empty fields
            if (new_DB_text.Text == "" && new_db_pass_text.Text == "")
            {
                MessageBox.Show("Database name and password can not be empty");
            }

            else if (new_DB_text.Text == "")
            {
                MessageBox.Show("Database name cannot be empty");
            }

            else if (new_db_pass_text.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }

            else
            { 
                String DBName = new_DB_text.Text;
                String Pass = new_db_pass_text.Text;


                using (XmlWriter writer = XmlWriter.Create("C://Users/Solomon/Desktop/"+DBName+".xml"))

                var folderBrowserDialog = new FolderBrowserDialog();
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)

                {
                    string folderName = folderBrowserDialog.SelectedPath;
                    string filePath = folderName + "/" + DBName + ".xml";
                    using (XmlWriter writer = XmlWriter.Create(filePath))
                    {
                        writer.WriteStartElement("Database");
                        writer.WriteElementString("DatabaseName", DBName);
                        writer.WriteElementString("DatabasePASS", Pass);
                        writer.WriteEndElement();
                        writer.Flush();
                        MessageBox.Show("Database created successfully");
                        clearText();
                        dashboard.successfulCreation(Pass, filePath);
                        this.Hide();
                    }
                }
            }
        }

        public void clearText()
        {
            new_DB_text.Text = "";
            new_db_pass_text.Text = "";

        }
    }
}
