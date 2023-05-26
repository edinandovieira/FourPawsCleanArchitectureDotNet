using System.Security.Cryptography;
using System.Text;

namespace FourPawsCleanArchitecture.Application.Helpers
{
    public class HashHelper
    {
        public static string secretKey = "3d4c9634-bde6-4208-bb6b-ab6907b6f3cb";

        public static string ComputeHash(string password)
        {
            byte[] secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            byte[] passSecretKeyBytes = new byte[passwordBytes.Length + secretKeyBytes.Length];
            passwordBytes.CopyTo(passSecretKeyBytes, 0);
            secretKeyBytes.CopyTo(passSecretKeyBytes, passwordBytes.Length);

            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(passSecretKeyBytes);
                string hash = Convert.ToBase64String(hashBytes);
                return hash;
            }
        }
        public static bool VerifyHash(string password, string bdpassword)
        {
            string computedHash = ComputeHash(password);
            return computedHash.Equals(bdpassword);
        }
    }
}
