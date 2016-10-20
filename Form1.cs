﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder {
    public partial class main : Form {
        public main() {
            InitializeComponent();
        }

        private void encode_Click(object sender, EventArgs e) {
            string input = toBinary(Encoding.ASCII.GetBytes(toEncode.Text));
            input = input.Replace("0", "l");
            input = input.Replace("1", "I");
            toEncode.Text = "";
            toDecode.Text = input;
        }

        private void decode_Click(object sender, EventArgs e) {
            string binaryString = toDecode.Text.Replace("l", "0");
            binaryString = binaryString.Replace("I", "1");
            binaryString = binaryString.Replace(" ", "");
            string dataTest = binaryToString(binaryString);

            toEncode.Text = dataTest;
            toDecode.Text = "";
        }

        public static String toBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
        }

        public string binaryToString(string binary)
        {

            if ((binary.Length % 8) != 0)
                throw new ArgumentException("Binary string must be divisible by 8", "binary");

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
                builder.Append((char)ascii);
            }
            return builder.ToString();
        }
    }
}
