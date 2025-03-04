using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pharmacy
{
   public static class Functions
    {
        public static bool isLetterString(string s)
        {
            return s.Replace(" ", "").All(char.IsLetter);
        }

        public static bool isNumberString(string s)
        {
            return s.Replace(" ", "").All(char.IsDigit);
        }

        public static bool isNumberCharacter(char c)
        {
            return char.IsDigit(c);
        }
        
        public static bool isLetter(char c)
        {
            return char.IsLetter(c);
        }
        public static bool isAlphanumericCharacter(char c)
        {
            return char.IsLetterOrDigit(c);
        }

        public static bool isAlphanumericString(string s)
        {
            return s.Replace(" ", "").All(char.IsLetterOrDigit);
        }

        public static bool isNullOrEmpty(string s)
        {
            return string.IsNullOrEmpty(s);
        }

       public static bool isNonAlphanumericCharacterExceptDotOrComma(char c)
        {
            return (!char.IsLetterOrDigit(c) && c != '.' && c != ',');
        }

        public static bool isSpecificCharacter(char c)
        {
            return @"#!""'-+*\/$%&()=?~ˇ^˘°˛`˙´˝¨¸@{}[]Łłß<>:;".Contains(c);
        }

        public static bool isNonEmailCharacter(char c)
        {
            return @"#!""'-+*\/$%&()=?~ˇ^˘°˛`˙´˝¨¸{}[]Łłß<>:;".Contains(c);
        }

        public static bool isEmailFormat(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }

        public static string generatePasswordHash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hash);
            }
        }
    }
}
