using MailKit.Net.Smtp;
using MediatR;
using MimeKit;

namespace SRP.Application.Features.Mails.Commands;

public class MailSendCommandHandler : IRequestHandler<MailSendCommand, string>
{
    public async Task<string> Handle(MailSendCommand request, CancellationToken cancellationToken)
    {
        BodyBuilder bodyBuilder = new BodyBuilder { TextBody = request.Body };
        using MimeMessage message = new MimeMessage();
        message.Body = bodyBuilder.ToMessageBody();
        message.Subject = request.Subject;
        message.From.Add(new MailboxAddress(request.FromName, request.FromMail));
        message.To.Add(new MailboxAddress(request.ToName, request.ToMail));

        using SmtpClient client = new SmtpClient();
        await client.ConnectAsync("smtp.gmail.com", 587, cancellationToken: cancellationToken);
        await client.AuthenticateAsync(request.FromMail, request.FromKey, cancellationToken: cancellationToken);
        await client.SendAsync(message, cancellationToken: cancellationToken);
        await client.DisconnectAsync(true, cancellationToken: cancellationToken);

        return $"Message {request.ToMail} Sent";
    }
}