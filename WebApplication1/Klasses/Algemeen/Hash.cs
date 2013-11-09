using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApplication1.Klasses.Algemeen
{
    public class Hash
    {
        public static string Password_Encryption_md5(string value)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(value);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                stringBuilder.Append(hash[i].ToString("x2"));
            return stringBuilder.ToString();
        }
    }
}