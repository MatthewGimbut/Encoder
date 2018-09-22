using System;
using System.Linq;
using System.Text;

namespace Encoder.Utilities
{
    /// <summary>
    /// Static methods to encode/decode text.
    /// </summary>
    public static class EncoderUtils
    {
        /// <summary>
        /// Consumes a binary string and replaces 0s and 1s with designated characters.
        /// </summary>
        /// <param name="input">The original input string.</param>
        /// <param name="zeroReplacement">The string which will be used to replace 0s.</param>
        /// <param name="oneReplacement">The string which will be used to replace 1s.</param>
        /// <returns>A string representation of the previous binary except with replacements.</returns>
        public static string BinaryEncode(string input, string zeroReplacement, string oneReplacement)
        {
            return input.Replace("0", zeroReplacement).Replace("1", oneReplacement);
        }

        /// <summary>
        /// Consumes an encoded binary string and replaces characters with 0s and 1s.
        /// </summary>
        /// <param name="input">The original input string.</param>
        /// <param name="zeroReplacement">The string which represents 0s.</param>
        /// <param name="oneReplacement">The string which represents 1s.</param>
        /// <returns></returns>
        public static string BinaryDecode(string input, string zeroReplacement, string oneReplacement)
        {
            return BinaryToString(input
                .Replace(zeroReplacement, "0")
                .Replace(oneReplacement, "1")
                .Replace(" ", "")
            );
        }

        /// <summary>
        /// Converts a byte array to a binary string.
        /// </summary>
        /// <param name="convert">The array of bytes to convert.</param>
        /// <returns>A string representation of a byte array.</returns>
        public static string ToBinary(Byte[] convert)
        {
            return string.Join(" ", convert.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
        }

        /// <summary>
        /// Encrypt string using Caesar cipher.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>An encoded string.</returns>
        public static string CaeserEncode(string input, int key)
        {
            string message = "";

            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    message += c;
                }
                else
                {
                    // Check to see if value is upper or lower case. Set ASCII value mod appropriately.
                    int mod = char.IsUpper(c) ? 65 : 97;
                    message += (char)((((c + key) - mod) % 26) + mod);
                }
            }

            Console.WriteLine(message);
            return message;
        }

        public static string CaeserDecode(string input)
        {
            return input;
        }

        public static string VigenereEncode(string input)
        {
            return input;
        }

        public static string VigenereDecode(string input)
        {
            return input;
        }

        /// <summary>
        /// Convert from a binary string to a normal string.
        /// </summary>
        /// <param name="binary">The input string which contains all binary characters.</param>
        /// <returns>A string which was converted from binary.</returns>
        private static string BinaryToString(string binary)
        {
            if ((binary.Length % 8) != 0)
                throw new ArgumentException("String must be divisible by 8!", "binary");

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < binary.Length; i += 8)
            {
                string section = binary.Substring(i, 8);
                int ascii = 0;
                try
                {
                    ascii = Convert.ToInt32(section, 2);
                }
                catch
                {
                    throw new ArgumentException("Binary string contains invalid section: " + section, "binary");
                }
                builder.Append((char) ascii);
            }
            return builder.ToString();
        }
    }
}
