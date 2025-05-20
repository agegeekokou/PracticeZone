//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace SqueakyClean
//{
//    public class Identifier
//    {
//        public static string Clean(string identifier)
//        {
//            if (string.IsNullOrEmpty(identifier))
//                return identifier;

//            string? result = string.Empty;

//            // Change the string in char array
//            char[] chars = identifier.ToCharArray();

//            if (identifier == "")
//            {
//                return "";
//            }
//            else if (identifier.Contains(' '))
//            {
//                // Loop over the array and change the empty char " " with "_"
//                for(int i = 0; i < chars.Length; i++)
//                {
//                    if (chars[i] == ' ')
//                    {
//                        chars[i] = '_';
//                    }
//                }

//                // Convert the char array into a string
//                result = new string(chars);
//            }
//            else if (identifier.Contains('\'') || identifier.Contains('\"') || identifier.Contains('\\')
//                || identifier.Contains('\0') || identifier.Contains('\a') || identifier.Contains('\b')
//                || identifier.Contains('\f') || identifier.Contains('\n') || identifier.Contains('\r')
//                || identifier.Contains('\t'))

//            {
//                for (int i = 0; i < chars.Length; i++)
//                {
//                    if ((chars[i] == '\'') || (chars[i] == '\"') || (chars[i] == '\\') || (chars[i] == '\0')
//                        || (chars[i] == '\a') || (chars[i] == '\b') || (chars[i] == '\f') || (chars[i] == '\n')
//                        || (chars[i] == '\r') || (chars[i] == '\t'))
//                    {
//                        StringBuilder sb = new StringBuilder(identifier);

//                        result = sb.Replace(chars[i].ToString(), "CTRL").ToString();
//                    }
//                }              
//            }
//            else if (identifier.Contains('-'))
//            {
//                StringBuilder sb = new StringBuilder();
//                bool toUpper = false;

//                foreach (char c in identifier)
//                {
//                    if (c == '-')
//                    {
//                        toUpper = true;
//                    }
//                    else
//                    {
//                        sb.Append(toUpper ? char.ToUpper(c) : c);
//                        toUpper = false;
//                    }
//                }

//                result = sb.ToString();
//            }
//            else if (!identifier.All(char.IsLetter))
//            {
//                StringBuilder sb = new StringBuilder();

//                foreach (char c in identifier)
//                {
//                    if (char.IsLetter(c))
//                    {
//                        sb.Append(c);
//                    }
//                }

//                result = sb.ToString();
//            }
//            else if (identifier.All(char.IsLetterOrDigit))
//            {
//                StringBuilder sb = new StringBuilder();

//                foreach (char c in identifier)
//                {
//                    // Keep letters except Greek lowercase
//                    if (char.IsLetter(c) && !(c >= '\u03B1' && c <= '\u03C9'))
//                    {
//                        sb.Append(c);
//                    }
//                }

//                result = sb.ToString();
//            }

//            Console.WriteLine(result);
//            return result;
//        }
//    }
//}

using System;
using System.Linq;
using System.Text;

namespace SqueakyClean
{
    public class Identifier
    {
        public static string? Clean(string? identifier)
        {
            if (string.IsNullOrEmpty(identifier))
                return identifier;

            // Handle control characters
            if (ContainsControlCharacters(identifier))
            {
                return ReplaceControlCharacters(identifier);
            }

            // Replace spaces with underscores
            if (identifier.Contains(' '))
            {
                return identifier.Replace(' ', '_');
            }

            // Convert kebab-case to camelCase
            if (identifier.Contains('-'))
            {
                return ConvertKebabToCamel(identifier);
            }

            // Keep only letters
            if (!identifier.All(char.IsLetter))
            {
                return new string(identifier.Where(char.IsLetter).ToArray());
            }

            // Remove Greek lowercase letters
            if (identifier.All(char.IsLetterOrDigit))
            {
                return new string(identifier
                    .Where(c => !(c >= '\u03B1' && c <= '\u03C9'))
                    .ToArray());
            }

            return identifier;
        }

        private static bool ContainsControlCharacters(string input)
        {
            foreach (char c in input)
            {
                if (c == '\'' || c == '\"' || c == '\\' || c == '\0' ||
                    c == '\a' || c == '\b' || c == '\f' ||
                    c == '\n' || c == '\r' || c == '\t')
                {
                    return true;
                }
            }
            return false;
        }

        private static string ReplaceControlCharacters(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (c == '\'' || c == '\"' || c == '\\' || c == '\0' ||
                    c == '\a' || c == '\b' || c == '\f' ||
                    c == '\n' || c == '\r' || c == '\t')
                {
                    sb.Append("CTRL");
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        private static string ConvertKebabToCamel(string input)
        {
            StringBuilder sb = new StringBuilder();
            bool toUpper = false;

            foreach (char c in input)
            {
                if (c == '-')
                {
                    toUpper = true;
                }
                else
                {
                    sb.Append(toUpper ? char.ToUpper(c) : c);
                    toUpper = false;
                }
            }

            return sb.ToString();
        }
    }
}

