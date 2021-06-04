using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProvider
{
    public class User
    {
        public string HashKey { get; set; } = "";
        public bool IsAdmin { get; set; } = false;
        public string NameUser { get; set; } = "";

        public void SetHashKey(string username, string password)
        {
            HashKey = Encoding.ASCII.GetString(GenerateHash.ComputeHash(Encoding.ASCII.GetBytes(username + password)));
        }
    }
}
