using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SendGrid;

namespace CourseProjectApp.Services
{
    public class EmailSend:IEmailSend
    {
        public MessageSenderOptions Options { get; set; }
        public EmailSend(IOptions<MessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
            
        }

        /*public async Task SendEmailAsync(string email, string subject, string message)
        {
            var apiKey = Options.SendGridAPIKey;
            /*var client = new SendGridClient(apiKey);
            var from = new EmailAddress("prannoy.mulmi@haw-hamburg.de", "test");
   
            var to = new EmailAddress(email, "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = $"<strong>Email for resettiing password</strong>{message}";
            var toSendMsg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(toSendMsg);#1#
            
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("prannoy.mulmi@gmail.com", "Example User");
            var subjects = "Sending with SendGrid is Fun";
            var to = new EmailAddress(email, "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
           
            var msg = MailHelper.CreateSingleEmail(from, to, subjects, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            int a = 1;
        }*/

        public Task SendEmailAsync(string email, string subject, string message)
        {
            var apiKey = Options.SendGridAPIKey;
            var myMessage = new SendGridMessage();
            myMessage.AddTo(email);
            myMessage.From = new MailAddress("joe@example.com", "Application");
            myMessage.Subject = subject;
            //myMessage.Text = message;

            

            var transportWeb = new Web(apiKey);

            return transportWeb.DeliverAsync(myMessage);
        }
    }
}