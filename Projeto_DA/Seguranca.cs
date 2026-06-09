using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA
{
    internal class Seguranca
    {
        public static string EncriptarPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                //converte a password em bytes
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                //calcula o hash
                byte[] hashBytes = sha256.ComputeHash(bytes);

                //converte os bytes do hash de volta para uma string hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
