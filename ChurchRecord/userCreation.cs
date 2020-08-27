using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
//using System.Threading.Tasks;

namespace ChurchRecord
{
    public partial class userCreation : Form
    {
        public userCreation()
        {
            InitializeComponent();
            descObj = Rijndael.Create();
        }

        private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");
        private const int keysize = 256;
        public string cipheredText;

        string cipherData;
        byte[] chipherbytes;
        byte[] plainbytes;
        byte[] plainbytes2;
        byte[] plainKey;

        string passEncrypted;

        SymmetricAlgorithm descObj;

        commonFunctionsClass commFcn = new commonFunctionsClass();


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string encryptedPass = commFcn.Encrypt(txtPlainText.Text, "123456");


            txtEncrypted.Text = encryptedPass;

            //string encryptedPass = Encrypt(txtPlainText.Text, "123456");
            

            //cipherData = txtPlainText.Text;
            //plainbytes = Encoding.ASCII.GetBytes(cipherData);
            //plainKey = Encoding.ASCII.GetBytes("0123456789abcdef");
            //descObj.Key = plainKey;
            //descObj.Mode = CipherMode.CBC;                      //CBC is ...
            //descObj.Padding = PaddingMode.PKCS7;
            //System.IO.MemoryStream memstrm = new System.IO.MemoryStream();
            //CryptoStream crypstrm = new CryptoStream(memstrm, descObj.CreateEncryptor(), CryptoStreamMode.Write);
            //crypstrm.Write(plainbytes, 0, plainbytes.Length);
            //crypstrm.Close();
            //chipherbytes = memstrm.ToArray();
            //memstrm.Close();
            //txtEncrypted.Text = Encoding.ASCII.GetString(chipherbytes);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //txtDecrypted.Text = Decrypt(txtEncrypted.Text);

            //System.IO.MemoryStream memStream = new System.IO.MemoryStream(chipherbytes);
            //CryptoStream cryptStream = new CryptoStream(memStream, descObj.CreateDecryptor(), CryptoStreamMode.Read);

            //cryptStream.Read(chipherbytes, 0, chipherbytes.Length);
            //plainbytes2 = memStream.ToArray();
            //cryptStream.Close();
            //memStream.Close();

            //txtDecrypted.Text = Encoding.ASCII.GetString(plainbytes2);
            //string ecrypted22 = Encrypt
            //txtDecrypted.Text = Decrypt();

        }

        private void userCreation_Load(object sender, EventArgs e)
        {

        }

        public string checkPassword(string passEntered)
        {
            cipherData = passEntered;
            plainbytes = Encoding.ASCII.GetBytes(cipherData);
            plainKey = Encoding.ASCII.GetBytes("0123456789abcdef");
            descObj.Key = plainKey;
            descObj.Mode = CipherMode.CBC;                      //CBC is ...
            descObj.Padding = PaddingMode.PKCS7;
            System.IO.MemoryStream memstrm = new System.IO.MemoryStream();
            CryptoStream crypstrm = new CryptoStream(memstrm, descObj.CreateEncryptor(), CryptoStreamMode.Write);
            crypstrm.Write(plainbytes, 0, plainbytes.Length);
            crypstrm.Close();
            chipherbytes = memstrm.ToArray();
            memstrm.Close();
            passEncrypted = Encoding.ASCII.GetString(chipherbytes);
            return passEncrypted;
        }

        //public static class StringCipher
        //{
        // This constant string is used as a "salt" value for the PasswordDeriveBytes function calls.
        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.

        //private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");

        // This constant is used to determine the keysize of the encryption algorithm.
        //private const int keysize = 256;

        public static string Encrypt2(string plainText, string passPhrase)
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

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "abc123";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        //System.IO.MemoryStream memstrm = new System.IO.MemoryStream();
                        //CryptoStream crypstrm = new CryptoStream(memstrm, descObj.CreateEncryptor(), CryptoStreamMode.Write);
                        //crypstrm.Write(plainbytes, 0, plainbytes.Length);
                        //crypstrm.Close();

                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;

        }

    }
}