using Azure.Communication.Email;
using Azure.Communication.Email.Models;

namespace KlaraKarl.Services
{
    public class MailService
    {
        public void sendmail()
        {

            EmailClient emailClient = new EmailClient("https://klarakarlcommunicationservice.communication.azure.com/;accesskey=aks9aKrKuQspV+9poX+PYu93Ktja053yDpewwOWIBBJcaGhUEIw3vNlIdlKGHSRCEX/vK3d1GN/WdxP0aoWcLQ==");
            EmailContent emailContent = new EmailContent("Welcome to Azure Communication Service Email APIs.");
            emailContent.PlainText = "This email message is sent from Azure Communication Service Email using .NET SDK.";
            List<EmailAddress> emailAddresses = new List<EmailAddress> { new EmailAddress("erik9996@hotmail.com") { DisplayName = "Friendly Display Name" } };
            EmailRecipients emailRecipients = new EmailRecipients(emailAddresses);
            EmailMessage emailMessage = new EmailMessage("donotreply@xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx.azurecomm.net", emailContent, emailRecipients);
            SendEmailResult emailResult = emailClient.Send(emailMessage, CancellationToken.None);
        }
    }
}
