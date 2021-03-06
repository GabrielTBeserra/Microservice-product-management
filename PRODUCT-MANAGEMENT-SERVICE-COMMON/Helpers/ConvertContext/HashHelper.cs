using System.Security.Cryptography;
using System.Text;

namespace PRODUCT_MANAGEMENT_SERVICE_COMMON.Helpers.ConvertContext
{
    public static class HashHelper
    {
        public static string ToSha256(this string password)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(password));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
