using System.Security.Cryptography;
using System.Text;

namespace PurchaSaler.Tools
{
    public class MD5Encryption
    {
        public string GetMd5Hash(string password)
        {
            StringBuilder targetStr = new StringBuilder();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            int length = data.Length;
            for (int i=0;i<length;i++)
            {
                targetStr.Append(data[i].ToString("X2"));
            }
            return targetStr.ToString();
        }
    }
}