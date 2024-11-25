using System.Text.Encodings;
using System.Security.Cryptography;
using System.Text;
namespace ReactApp1.Server
{
    public class HashFunction
    {
        public string CreateHash(string input)
        {
            byte[] tempSource = ASCIIEncoding.ASCII.GetBytes(input);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] tempHash = sha256.ComputeHash(tempSource);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in tempHash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public bool CompareHashes(string existinghash, string input)
        {
            byte[] existingHash = Convert.FromHexString(existinghash);
            byte[] tempHash = ASCIIEncoding.ASCII.GetBytes(input);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] compareHash = sha256.ComputeHash(tempHash);

                if (existingHash.SequenceEqual(compareHash))
                {
                    return true;
                }
                return false;
            }
        }
   }
}
