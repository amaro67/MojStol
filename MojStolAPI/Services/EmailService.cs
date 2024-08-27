using MailKit.Net.Smtp;
using MimeKit;

namespace Services {
  public class EmailService {
    private readonly IConfiguration _config;

    public EmailService(IConfiguration config) {
      _config = config;
    }

    public void Send(string to, string subject, string body) {
      try {
        var message = new MimeMessage();

            var fromName = Environment.GetEnvironmentVariable("EMAIL_USERNAME");
            var fromEmail = Environment.GetEnvironmentVariable("EMAIL_FROM");

        if (!string.IsNullOrEmpty(fromName)) {
          message.From.Add(new MailboxAddress(fromName, fromEmail));
        } else {
          message.From.Add(new MailboxAddress(fromEmail, fromEmail));
        }

        message.To.Add(new MailboxAddress("", to));

        message.Subject = subject;

          string warningText = "This is a generated message, DO NOT SEND ANY DATA OR MESSAGE TO THIS SENDER.";
          string supportText = "If you have any trouble using our app, feel fre to contact our support: mojstolhelp@gmail.com";


          var completeBody = $"{body}<br><br>{warningText}<br><br>{supportText}";

          var bodyBuilder = new BodyBuilder
          {
              HtmlBody = completeBody
          };
          message.Body = bodyBuilder.ToMessageBody();

        var portString = Environment.GetEnvironmentVariable("EMAIL_PORT");

        if (string.IsNullOrEmpty(portString) || !int.TryParse(portString, out int port))
        {
            throw new ArgumentException("Invalid or missing email port configuration.");
        }
        
        
        using(var client = new SmtpClient()) {
            client.Connect(Environment.GetEnvironmentVariable("EMAIL_SERVER"), port, MailKit.Security.SecureSocketOptions.StartTls);

            client.Authenticate(Environment.GetEnvironmentVariable("EMAIL_FROM"), Environment.GetEnvironmentVariable("EMAIL_PASSWORD"));

            client.Send(message);

          client.Disconnect(true);
        }
      } catch (Exception ex) {
        Console.WriteLine($"Failed to send email: {ex.Message}");
        throw;
      }
    }

  }
}