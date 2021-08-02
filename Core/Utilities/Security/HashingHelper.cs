using System;
using System.Security.Cryptography;
using System.Text;

namespace Core.Utilities.Security
{
    public class HashingHelper
    {
        /// <summary>
        /// Compute hash in Rfc2898 schema.
        /// </summary>
        /// <param name="size">Salt size</param>
        /// <param name="password">Entered password</param>
        /// <param name="passwordHash">Parameter to hash. Needs out keyword</param>
        /// <param name="passwordSalt">Parameter to salt. Needs out keyword</param>
        public static void ComputeHash(int size, string password, out string passwordHash, out string passwordSalt)
        {
            using (var provider = new RNGCryptoServiceProvider())
            {
                var saltBytes = new byte[size];
                provider.GetNonZeroBytes(saltBytes);
                var salt = Convert.ToBase64String(saltBytes);

                using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000))
                {
                    var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));
                    passwordSalt = salt;
                    passwordHash = hashPassword;
                }
            }
        }

        /// <summary>
        /// Verify password came from the user.
        /// </summary>
        /// <param name="password">Entered password</param>
        /// <param name="passwordHash">Current user`s hashed password from db</param>
        /// <param name="passwordSalt">Current user`s salted password from db</param>
        /// <returns>Login is valid returns true, otherwise false</returns>
        public static bool VerifyPassword(string password, string passwordHash, string passwordSalt)
        {
            var saltBytes = Convert.FromBase64String(passwordSalt);
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == passwordHash;
            }
        }

    }
}
