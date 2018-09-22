using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Encoder.Utilities;

namespace Encoder
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            string message = toEncode.Text;

            if (CaeserOption.Checked)
            {

            }
            else if (VigenereOption.Checked)
            {

            }

            toDecode.Text = EncoderUtils.BinaryEncode(
                EncoderUtils.ToBinary(Encoding.ASCII.GetBytes(message)),
                ReplaceZero.Text,
                ReplaceOne.Text
                );
            toEncode.Text = "";
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            toEncode.Text = EncoderUtils.BinaryDecode(toDecode.Text, ReplaceZero.Text, ReplaceOne.Text);
            toDecode.Text = "";
        }

        private void Email_Click(object sender, EventArgs e)
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
    }
}
