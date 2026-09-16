using DescribeTranspiler.CLI;
using System.Security.Cryptography;
using System.Text;

namespace DescribeTranspiler.Cli
{
    //https://stackoverflow.com/questions/12804231/c-sharp-equivalent-to-hash-hmac-in-php
    //https://puvox.software/blog/two-way-encryption-decryption-between-php-and-c-sharp/
    //https://stackoverflow.com/questions/45567962/convert-encrypt-and-decrypt-c-sharp-function-to-php-function

    internal class CryptoUtil_Implementation1 : CryptoUtil
    {
        public override byte[] defaultIV
        {
            get
            {
                return new byte[16] {
                0x88, 0x91, 0x21, 0x25, 0xe9, 0x02, 0x6b, 0xfe,
                0x6c, 0x34, 0xa9, 0xd3, 0xfb, 0x8f, 0xab, 0x99 };
            }
        }



        public override string HashHMAC(string key, string message)
        {
            var hash = new HMACSHA256(StringEncode(key));
            var hmac = hash.ComputeHash(StringEncode(message));
            return HashEncode(hmac);
        }
        private byte[] HashHMAC(byte[] key, byte[] message)
        {
            var hash = new HMACSHA256(key);
            return hash.ComputeHash(message);
        }
        private byte[] StringEncode(string text)
        {
            var encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(text);
        }
        private string HashEncode(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
        string GetHashSha256(string input)
        {
            //https://stackoverflow.com/questions/12416249/hashing-a-string-with-sha256
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        public override string EncryptString(string plaintext, string password)
        {
            byte[] plainText = Encoding.Unicode.GetBytes(plaintext); // this is UTF-16 LE
            string cipherText;
            using (Aes encryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes("worldinlists"));
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16); //encryptor.IV = defaultIV;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(plainText, 0, plainText.Length);
                        cs.Close();
                    }
                    var cryptoArray = ms.ToArray();
                    cipherText = Convert.ToBase64String(cryptoArray);
                }
            }

            return cipherText;
        }
        public override string DecryptString(string cipherText, string password)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            string plaintext;
            using (Aes decryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes("worldinlists"));
                decryptor.Key = pdb.GetBytes(32);
                decryptor.IV = pdb.GetBytes(16); // Using the same IV derivation as encryption
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    byte[] decryptedData = ms.ToArray();
                    plaintext = Encoding.Unicode.GetString(decryptedData); // UTF-16 LE as used in encryption
                }
            }

            return plaintext;

            //byte[] key = StringToByteArrayFastest(password);
            //return DecryptString(cipherText, key, defaultIV);
        }

        private int GetHexVal(char hex)
        {
            int val = (int)hex;
            //For uppercase A-F letters:
            //return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }
    }
}
