using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace memoral
{
    public class hash
    {
        public static string md5(string txt)
        {
            if (txt != "")
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.ASCII.GetBytes(txt);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    string hashString = "";
                    foreach (byte b in hashBytes)
                    {
                        hashString += b.ToString("X2") + "-";
                    }
                    hashString = hashString.Substring(0, hashString.Length - 1);
                    return hashString;
                }
            }
            else
            {
                return "";
            }
        }
    }
}
