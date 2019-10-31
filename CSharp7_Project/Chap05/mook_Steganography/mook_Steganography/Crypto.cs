using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;

namespace mook_Steganography
{
    class Crypto
    {
        private static byte[] _salt = Encoding.ASCII.GetBytes("123456789abcdefghijkllmn");
        public static string EncryptStringAES(string HiddenText, string PrivateKey)
        {
            string outStr = null;
            RijndaelManaged rjdm = null;

            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(PrivateKey, _salt);

                rjdm = new RijndaelManaged();
                rjdm.Key = key.GetBytes(rjdm.KeySize / 8);

                ICryptoTransform encryptor = rjdm.CreateEncryptor(rjdm.Key, rjdm.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(BitConverter.GetBytes(rjdm.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(rjdm.IV, 0, rjdm.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(HiddenText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                if (rjdm != null)
                    rjdm.Clear();
            }
            return outStr;
        }
        public static string DecryptStringAES(string ExtractedText, string PrivateKey)
        {
            RijndaelManaged rjdm = null;

            string plaintext = null;

            try
            {
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(PrivateKey, _salt);

                byte[] bytes = Convert.FromBase64String(ExtractedText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    rjdm = new RijndaelManaged();
                    rjdm.Key = key.GetBytes(rjdm.KeySize / 8);
                    rjdm.IV = ReadByteArray(msDecrypt);
                    ICryptoTransform decryptor = rjdm.CreateDecryptor(rjdm.Key, rjdm.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {
                if (rjdm != null)
                    rjdm.Clear();
            }
            return plaintext;
        }

        private static byte[] ReadByteArray(Stream stmstr)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (stmstr.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException();
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (stmstr.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException();
            }
            return buffer;
        }
    }
}
