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

