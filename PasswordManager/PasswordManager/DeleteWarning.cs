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
    public partial class DeleteWarning : Form
    {
        DB dashboard;
        int entryNumber;
        public DeleteWarning(DB dashboard, int entryNumber)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            this.entryNumber = entryNumber;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            dashboard.deleteEntry(entryNumber);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
