using System.Security.Cryptography;
using System.Text;

namespace DoublePartnersAPI.Utils
{
    public static class Common
    {
        public static string Base64Encode(string input)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);

                return Convert.ToBase64String(bytes);
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }

        public static string Base64Decode(string input)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(input);

                return Encoding.UTF8.GetString(bytes);
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }

        public static string ProcessStringAsMD5(string input)
        {
            try
            {
                MD5 md5 = MD5.Create();

                byte[] inputBytes = new UnicodeEncoding().GetBytes(input);

                byte[] hash = md5.ComputeHash(inputBytes);

                return BitConverter.ToString(hash);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
