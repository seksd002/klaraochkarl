using Azure.Communication.Email;
using Azure.Communication.Email.Models;

namespace KlaraKarl.Services
{
    public class MailService
    {
        public async void sendmail(string recipent, string displayname, string subject, string html)
        {
            {
                var connectionString = "endpoint=https://klarakarlcommunicationservice.communication.azure.com/;accesskey=aks9aKrKuQspV+9poX+PYu93Ktja053yDpewwOWIBBJcaGhUEIw3vNlIdlKGHSRCEX/vK3d1GN/WdxP0aoWcLQ==";
                var emailClient = new EmailClient(connectionString);

                var emailContent = createEmailContent(subject, html);
                var sender = "KarlochKlara@99f0105c-2c86-42ce-93ad-5f42422626f3.azurecomm.net";

                var emailRecipients = new EmailRecipients(new List<EmailAddress> {
                new EmailAddress(recipent) { DisplayName = displayname }
            });

                var emailMessage = new EmailMessage(sender, emailContent, emailRecipients);

                try
                {
                    SendEmailResult sendEmailResult = emailClient.Send(emailMessage);

                    string messageId = sendEmailResult.MessageId;
                    if (!string.IsNullOrEmpty(messageId))
                    {
                        Console.WriteLine($"Email sent, MessageId = {messageId}");
                    }
                    else
                    {
                        Console.WriteLine($"Failed to send email.");
                        return;
                    }

                    // wait max 2 minutes to check the send status for mail.
                    var cancellationToken = new CancellationTokenSource(TimeSpan.FromMinutes(2));
                    do
                    {
                        SendStatusResult sendStatus = emailClient.GetSendStatus(messageId);
                        Console.WriteLine($"Send mail status for MessageId : <{messageId}>, Status: [{sendStatus.Status}]");

                        if (sendStatus.Status != SendStatus.Queued)
                        {
                            break;
                        }
                        await Task.Delay(TimeSpan.FromSeconds(10));

                    } while (!cancellationToken.IsCancellationRequested);

                    if (cancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine($"Looks like we timed out for email");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in sending email, {ex}");
                }
            }
        }
        private EmailContent createEmailContent(string subject, string html)
        {

            var emailContent = new EmailContent(subject)
            {
                //PlainText = "This is plain mail send test body \n Best Wishes!!",
                //Html = "<html><body><h1>Quick send email test</h1><br/><h4>Communication email as a service mail send app working properly</h4><p>Happy Learning!!</p></body></html>"
                Html = html
            };
            return emailContent;
        }
    }
}
