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

namespace PasswordManager
{
    public partial class Login : Form
    {
        String filePath = "C://Users/Ramon Gonzalez/Desktop/database.xml";
        DB dashboard;
        public Login(DB dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            dialog_Box b = new dialog_Box();
            b.ShowDialog();
        }

        private void Okay_Btn_Click(object sender, EventArgs e)
        {
            String pass = MP_Input.Text;
            dashboard.masterPassword = pass;
            if (dashboard.UpdateEntryList())
            {
                this.dashboard.successfulLogin();
            }
            else
            {
                /*Error message with unsuccesful login pops up */
            }
            
        }

        private void NewDB_Click(object sender, EventArgs e)
        {
            new_DB nb = new new_DB();

            nb.ShowDialog();
            
        }


        private void Choose_Btn_Click(object sender, EventArgs e)
        {
          
            DialogResult result = Choose.ShowDialog();
            filePath = Choose.FileName;
            label2.Text = filePath;
            



        }
        public String GetFilePath()
        {
            return this.filePath;
        }
        private void Choose_FileOk(object sender, CancelEventArgs e)
        {
           
        }     

    }
}