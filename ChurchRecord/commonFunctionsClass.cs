using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace ChurchRecord
{
    class commonFunctionsClass
    {
        public static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");
        public const int keysize = 256;

        public string Encrypt(string plainText, string passPhrase)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);

            byte[] keyBytes = password.GetBytes(keysize / 8);
            using (RijndaelManaged symmetricKey = new RijndaelManaged())
            {
                symmetricKey.Mode = CipherMode.CBC;
                using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                            cryptoStream.FlushFinalBlock();
                            byte[] cipherTextBytes = memoryStream.ToArray();
                            return Convert.ToBase64String(cipherTextBytes);
                        }
                    }
                }
            }
        }
    }
}
