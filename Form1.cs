using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Encoder.Utilities;

namespace Encoder
{
    /// <summary>
    /// GUI event code.
    /// </summary>
    public partial class main : Form
    {
        /// <summary>
        /// Main method to initialize form.
        /// </summary>
        public main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles encode click button events. 
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void Encode_Click(object sender, EventArgs e)
        {
            string message = "";

            if (String.IsNullOrEmpty(ReplaceZero.Text) || String.IsNullOrEmpty(ReplaceOne.Text))
            {
                MessageBox.Show("Make sure 0 and 1 replacements are set!");
                return;
            }

            if (CaeserOption.Checked)
            {
                message = EncoderUtils.CaeserEncode(toEncode.Text, (int) CaesarKey.Value);
            }
            else if (VigenereOption.Checked)
            {
                message = EncoderUtils.VigenereEncode(toEncode.Text);
            }
            else if (PlainBinaryOption.Checked)
            {
                message = toEncode.Text;
            }

            toDecode.Text = EncoderUtils.BinaryEncode(
                EncoderUtils.ToBinary(Encoding.ASCII.GetBytes(message)),
                ReplaceZero.Text,
                ReplaceOne.Text
            );
        }

        /// <summary>
        /// Handles decode click button events.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void Decode_Click(object sender, EventArgs e)
        {
            string message = "";

            if (CaeserOption.Checked)
            {
                message = EncoderUtils.CaeserDecode(toDecode.Text);
            }
            else if (VigenereOption.Checked)
            {
                message = EncoderUtils.VigenereDecode(toDecode.Text);
            }
            else if (PlainBinaryOption.Checked)
            {
                message = toDecode.Text;
            }

            toEncode.Text = EncoderUtils.BinaryDecode(message, ReplaceZero.Text, ReplaceOne.Text);
        }

        /// <summary>
        /// Handles send email click button events
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void Email_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO Look into using OpenId library for auth?
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

                // You'd think an encryption app would have better security.
                smtp.Credentials = new NetworkCredential("csharpmessageencoder@gmail.com", "Encoder1");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
