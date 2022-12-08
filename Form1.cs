using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net.Mail;
using System.Net;
using System.ComponentModel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Email_sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples.SmtpExamples.Async
    {
        public class SimpleAsynchronousExample
        {
            static bool mailSent = false;
            private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
            {
                // Get the unique identifier for this asynchronous operation.
                String token = (string)e.UserState;

                if (e.Cancelled)
                {
                    Console.WriteLine("[{0}] Send canceled.", token);
                }
                if (e.Error != null)
                {
                    Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
                }
                else
                {
                    Console.WriteLine("Message sent.");
                }
                mailSent = true;
            }
            public static void Main(string[] args)
            {
                // Command-line argument must be the SMTP host.
                SmtpClient client = new SmtpClient(args[0]);
                // Specify the email sender.
                // Create a mailing address that includes a UTF8 character
                // in the display name.
                MailAddress from = new MailAddress("jane@contoso.com",
                   "Jane " + (char)0xD8 + " Clayton",
                System.Text.Encoding.UTF8);
                // Set destinations for the email message.
                MailAddress to = new MailAddress("ben@contoso.com");
                // Specify the message content.
                MailMessage message = new MailMessage(from, to);
                message.Body = "This is a test email message sent by an application. ";
                // Include some non-ASCII characters in body and subject.
                string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
                message.Body += Environment.NewLine + someArrows;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = "test message 1" + someArrows;
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                // Set the method that is called back when the send operation ends.
                client.SendCompleted += new
                SendCompletedEventHandler(SendCompletedCallback);
                // The userState can be any object that allows your callback
                // method to identify this send operation.
                // For this example, the userToken is a string constant.
                string userState = "test message1";
                client.SendAsync(message, userState);
                Console.WriteLine("Sending message... press c to cancel mail. Press any other key to exit.");
                string answer = Console.ReadLine();
                // If the user canceled the send, and mail hasn't been sent yet,
                // then cancel the pending operation.
                if (answer.StartsWith("c") && mailSent == false)
                {
                    client.SendAsyncCancel();
                }
                // Clean up.
                message.Dispose();
                Console.WriteLine("Goodbye.");
            }
        }
    }
}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var from = "from@example.com";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var Password = "12345";
        }

        private void to_TextChanged(object sender, EventArgs e)
        {
            var to = "to@example.com";

        }

        private void subject_TextChanged(object sender, EventArgs e)
        {
            var konu = "Test postası";

        }