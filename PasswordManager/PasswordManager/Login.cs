﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Okay_Btn_Click(object sender, EventArgs e)
        {
           String pass = MP_Input.Text;
            
        }

        private void NewDB_Click(object sender, EventArgs e)
        {
            new_DB nb = new new_DB();

            nb.ShowDialog();
            
        }
    }
}