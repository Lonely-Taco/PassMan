using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    

    public class Entry
    {
        private string title { get; }
        private string username { get; }
        private string password { get; }

        Entry(string title, string username, string password)
        {
            this.title = title;
            this.username = username;
            this.password = password;
        }


    }
}
