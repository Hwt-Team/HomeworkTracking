using System.Security.Cryptography;
using System.Text;

namespace Core.Utilities.Security
{
    public class HashingHelper
    {
        public static void ComputeHash(string password, out byte[] passwordHash)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPassword(string password, byte[] passwordHash)
        {
            using (var hmac = new HMACSHA512())
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < hash.Length; i++)
                {
                    if (hash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

    }
}
