using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Kalorian.Common.Utility.Cryptography
{
    public class Cl_Cryptography
    {
        private const string vrlInputKey = "232E02B1-110F-4747-8BD2-02F28D918B4E";

        public string SimpleEncrypt(string vrpSource)
        {
            if (string.IsNullOrEmpty(vrpSource))
                throw new ArgumentNullException("Przekazano puste dane");

            string vrlSalt = new Guid().ToString();
            RijndaelManaged vrlRijandel = new RijndaelManaged();
            byte[] vrlSaltBytes = Encoding.ASCII.GetBytes(vrlSalt);
            Rfc2898DeriveBytes vrlKey = new Rfc2898DeriveBytes(vrlInputKey, vrlSaltBytes);
            vrlRijandel.Key = vrlKey.GetBytes(vrlRijandel.KeySize/8);
            vrlRijandel.IV = vrlKey.GetBytes(vrlRijandel.BlockSize / 8);
            ICryptoTransform vrlEncryptor = vrlRijandel.CreateEncryptor(vrlRijandel.Key, vrlRijandel.IV);
            MemoryStream vrlMemoryStream = new MemoryStream();
            using (var vrlCryptoStreamEncrypt = new CryptoStream(vrlMemoryStream, vrlEncryptor, CryptoStreamMode.Write))
            using (var vrlStreamWriter = new StreamWriter(vrlCryptoStreamEncrypt))
            {
                vrlStreamWriter.Write(vrpSource);
            }

            return Convert.ToBase64String(vrlMemoryStream.ToArray());
        }

        public string SimpleDecrypt(string vrpSource)
        {
            string vrlDecryptedMessage;

            string vrlSalt = new Guid().ToString();
            byte[] vrlSaltBytes = Encoding.ASCII.GetBytes(vrlSalt);
            Rfc2898DeriveBytes vrlKey = new Rfc2898DeriveBytes(vrlInputKey, vrlSaltBytes);
            RijndaelManaged vrlRijandel = new RijndaelManaged();
            vrlRijandel.Key = vrlKey.GetBytes(vrlRijandel.KeySize / 8);
            vrlRijandel.IV = vrlKey.GetBytes(vrlRijandel.BlockSize / 8);
            var vrlDecryptor = vrlRijandel.CreateDecryptor(vrlRijandel.Key, vrlRijandel.IV);
            var cipher = Convert.FromBase64String(vrpSource);

            using (var MemoryStreamDecrypt = new MemoryStream(cipher))
            {
                using (var vrlCryptoStream = new CryptoStream(MemoryStreamDecrypt, vrlDecryptor, CryptoStreamMode.Read))
                {
                    using (var vrlStreamReaderDecrypt = new StreamReader(vrlCryptoStream))
                    {
                        vrlDecryptedMessage = vrlStreamReaderDecrypt.ReadToEnd();
                    }
                }
            }
            return vrlDecryptedMessage;
        }
    }
}
