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
        String filePath = null;
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
            b.Show();
        }

        private void Okay_Btn_Click(object sender, EventArgs e)
        {
            String pass = MP_Input.Text;
            
            if(filePath == null)
            {
                MessageBox.Show("File path cannot be empty");
            } else
            {
                dashboard.entryTest(filePath);
                if (dashboard.UpdateEntryList(pass))
                {
                    this.dashboard.successfulLogin(pass, filePath);
                }
                else
                {
                    MessageBox.Show("Incorrect master password");
                }
            }
            
            
            
        }

        private void NewDB_Click(object sender, EventArgs e)
        {
            new_DB nb = new new_DB(dashboard);

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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}