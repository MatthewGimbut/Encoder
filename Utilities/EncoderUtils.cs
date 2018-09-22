using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder.Utilities
{
    class EncoderUtils
    {
        public static string BinaryEncode(string input, string zeroReplacement, string oneReplacement)
        {
            return input.Replace("0", zeroReplacement).Replace("1", oneReplacement);
        }

        public static string BinaryDecode(string input, string zeroReplacement, string oneReplacement)
        {
            return BinaryToString(input
                .Replace(zeroReplacement, "0")
                .Replace(oneReplacement, "1")
                .Replace(" ", "")
                );
        }

        public static string ToBinary(Byte[] convert)
        {
            return string.Join(" ", convert.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
        }

        public static string CaeserEncode(string input)
        {
            return "";
        }

        public static string VigenereEncode(string input)
        {
            return "";
        }

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
