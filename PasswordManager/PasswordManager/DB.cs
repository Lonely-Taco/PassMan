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

namespace PasswordManager
{
    public partial class DB : Form
    {
        Login loginScreen;
        bool hasUnsavedChances;

        public DB()
        {
            InitializeComponent();
            this.Hide();
            this.hasUnsavedChances = false;
            loginScreen = new Login(this);
            Application.Run(loginScreen);
            
        }

        public void successfulLogin()
        {
            loginScreen.Hide();
            this.Show();        
        }

        public void UpdateEntryList(Entry[] entryList)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            EditEntry edit = new EditEntry();

            edit.ShowDialog();
        }
    }
}
