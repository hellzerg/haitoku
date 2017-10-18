using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;

namespace Haitoku
{
    public static class CryLain
    {
        public static string Base64Encode(string key)
        {
            string result = string.Empty;

            try
            {
                result = Convert.ToBase64String(Encoding.UTF8.GetBytes(key));
            }
            catch { }

            return result;
        }

        public static string Base64Decode(string base64)
        {
            string result = string.Empty;

            try
            {
                result = Encoding.UTF8.GetString(Convert.FromBase64String(base64));
            }
            catch { }

            return result;
        }
    }
}
