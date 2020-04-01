using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace PasswordManager
{
    

    public class Entry
    {
        public string Title { get; }
        public string Username { get; }
        public byte[] EncryptedPassword { set; get; }

        

        public Entry(string title, string username, byte[] password)
        {
            this.Title = title;
            this.Username = username;
            this.EncryptedPassword = password;
        }

        
    }
}
