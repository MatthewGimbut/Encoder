using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoder {
    public partial class main : Form {
        public main() {
            InitializeComponent();
        }

        private void encode_Click(object sender, EventArgs e) {
            string input = ToBinary(Encoding.ASCII.GetBytes(toEncode.Text));
            string ZeroReplacement = ReplaceZero.Text;
            string OneReplacement = ReplaceOne.Text;

            if (ZeroReplacement == "") input = input.Replace("0", "l");
            else input = input.Replace("0", ZeroReplacement);
            

            if (OneReplacement == "") input = input.Replace("1", "I");
            else input = input.Replace("1", OneReplacement);
            

            toEncode.Text = "";
            toDecode.Text = input;
        }

        private void decode_Click(object sender, EventArgs e) {
            string BinaryString = toDecode.Text;
            string ZeroReplacement = ReplaceZero.Text;
            string OneReplacement = ReplaceOne.Text;

            if (ZeroReplacement == "") BinaryString = BinaryString.Replace("l", "0");
            else BinaryString = BinaryString.Replace(ZeroReplacement, "0");


            if (OneReplacement == "") BinaryString = BinaryString.Replace("I", "1");
            else BinaryString = BinaryString.Replace(OneReplacement, "1");

            BinaryString = BinaryString.Replace(" ", "");
            string dataTest = BinaryToString(BinaryString);

            toEncode.Text = dataTest;
            toDecode.Text = "";
        }

        public static String ToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
        }

        public string BinaryToString(string binary)
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
                builder.Append((char) ascii);
            }
            return builder.ToString();
        }

        private void email_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("csharpmessageencoder@gmail.com");
                message.To.Add(new MailAddress(to.Text.ToString()));
                message.Subject = subject.Text.ToString();
                message.Body = toDecode.Text.ToString();

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("csharpmessageencoder@gmail.com", "Encoder1");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

    }
}
