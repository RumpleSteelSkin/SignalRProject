using MediatR;

namespace SRP.Application.Features.Mails.Commands;

public class MailSendCommand : IRequest<string>
{
    public string? FromName { get; set; }
    public string? FromMail { get; set; }
    public string? FromKey { get; set; }
    public string? ToName { get; set; }
    public string? ToMail { get; set; }
    public string? Subject { get; set; }
    public string? Body { get; set; }
}