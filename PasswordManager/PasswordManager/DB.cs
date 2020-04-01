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

namespace PasswordManager
{
    public partial class DB : Form
    {
        Login loginScreen;
        bool hasUnsavedChances;
        Encryptor encryptor;
        public string masterPassword;
        Entry[] entryList;

        public DB()
        {
            InitializeComponent();
            this.Hide();
            this.hasUnsavedChances = false;
            encryptor = new Encryptor();
            masterPassword = null;
            entryList = entryTest();
            loginScreen = new Login(this);

            Application.Run(loginScreen);
            
            //UpdateEntryList();
        }

        public void successfulLogin()
        {
            loginScreen.Hide();
            this.Show();
            //UpdateEntryList(entryTest());
        }

        public bool UpdateEntryList()
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

        public void closeApp()
        {
            if (hasUnsavedChances)
            {
                /* Popup window asking if you want to save unsaved chances*/
            }
            else
            {
                this.Close();
            }
        }

        public Entry[] entryTest()
        {
            Entry[] entrylist = new Entry[20];
            for (int i = 0; i < 20; i++)
            {
                entrylist[i] = new Entry($"title{0}", $"username{0}", encryptor.encryptPassword("masterpassword", $"password{0}"), i);
            }
           // entrylist[0] = new Entry("title1", "username1", encryptor.encryptPassword("masterpassword", "password1"));
            //entrylist[1] = new Entry("title2", "username2", encryptor.encryptPassword("masterpassword", "password2"));
            //entrylist[2] = new Entry("title3", "username3", encryptor.encryptPassword("masterpassword", "password3"));
            //entrylist[3] = new Entry("title4", "username4", encryptor.encryptPassword("masterpassword", "password4"));

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
            Entry entryEdited = entryList[int.Parse(contextMenuStrip1.Items[5].Text)];

            EditEntry editEntry = new EditEntry(entryEdited.Title, entryEdited.Username, encryptor.decryptPassword(masterPassword, entryEdited.EncryptedPassword));
            editEntry.ShowDialog();
        }

        private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
