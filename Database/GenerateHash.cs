using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DatabaseProvider
{
    class GenerateHash
    {
        public static byte[] ComputeHash(byte[] text)
        {
            return new MD5CryptoServiceProvider().ComputeHash(text);
        }
    }
}
