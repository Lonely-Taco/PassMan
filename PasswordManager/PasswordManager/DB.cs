using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace PasswordManager
{
    public partial class DB : Form
    {
        Login loginScreen;
        Encryptor encryptor;
        private string masterPassword;
        public Entry[] entryList { get; set; }
        public string filepath { get; set; }

        public DB()
        {
            InitializeComponent();
            this.Hide();
            encryptor = new Encryptor();
            masterPassword = null;
            
            loginScreen = new Login(this);

            Application.Run(loginScreen);
        }

        public string encryptPassword(string password)
        {
            return Encoding.ASCII.GetString(encryptor.encryptPassword(masterPassword, password));
        }

        public void successfulLogin(string masterPassword, string filepath)
        {
            loginScreen.Hide();
            this.Show();
            this.masterPassword = masterPassword;
            this.filepath = filepath;
        }

        public void successfulCreation(string masterPassword, string filepath)
        {
            this.masterPassword = masterPassword;
            loginScreen.Hide();
            this.Show();
            this.filepath = filepath;
            entryList = entryTest(filepath);
            UpdateEntryList(masterPassword);
        }

        public bool UpdateEntryList(string masterPassword)
        {
            for (int i = 0; i < entryList.Length; i++)
            {
                string password = encryptor.decryptPassword(masterPassword, entryList[i].EncryptedPassword);
                if(password == null)
                {
                    return false;
                }
                CreateRow(i, entryList[i].Title, entryList[i].Username, password);
            }
            return true;
        }

        public void CreateRow(int i, string title, string username, string password)
        {
            string[] row = { i.ToString(), title, username, password};
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }

        public Entry[] entryTest(string filepath)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            string str = null;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Entries");
            Entry[] entrylist = new Entry[xmlnode.Count];
            for (int i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                entrylist[i] = new Entry(xmlnode[i].ChildNodes.Item(0).InnerText.Trim(), xmlnode[i].ChildNodes.Item(1).InnerText.Trim(), Encoding.ASCII.GetBytes(xmlnode[i].ChildNodes.Item(2).InnerText.Trim()), i);
                //MessageBox.Show(entryList[i].Title + ", " + entryList[i].Username + ", " + entryList[i].EncryptedPassword);
                //MessageBox.Show(entrylist.Length.ToString());
            }
            fs.Close();
            return entrylist;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            EditEntry edit = new EditEntry(this);

            edit.ShowDialog();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Items[0].Text = entryList[int.Parse(listView1.FocusedItem.Text)].Title;
                    contextMenuStrip1.Items[5].Text = listView1.FocusedItem.Text;
                    contextMenuStrip1.Show(Cursor.Position);

                }
            }
        }

        private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(encryptor.decryptPassword(masterPassword, entryList[int.Parse(contextMenuStrip1.Items[5].Text)].EncryptedPassword));
        }

        private void editEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "editing";
            Entry entryEdited = entryList[int.Parse(contextMenuStrip1.Items[5].Text)];

            EditEntry editEntry = new EditEntry(entryEdited.Title, entryEdited.Username, encryptor.decryptPassword(masterPassword, entryEdited.EncryptedPassword), this);
            editEntry.ShowDialog();
        }

        private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteWarning deleteWarning = new DeleteWarning(this, int.Parse(contextMenuStrip1.Items[5].Text));
            deleteWarning.Show();

            
        }

        public void deleteEntry(int entryNumber)
        {
            MessageBox.Show("Deleting entry number " + entryNumber);
            //delete entryList[entryNumber]
        }

    
    }
}
