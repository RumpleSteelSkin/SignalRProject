using MediatR;
using Microsoft.AspNetCore.Mvc;
using SRP.Application.Features.Mails.Commands;

namespace SRP.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MailsController(IMediator mediator, IConfiguration configuration) : ControllerBase
{
    [HttpPost("SendMail")]
    public async Task<IActionResult> SendMail(MailSendCommand command)
    {
        command.FromName = configuration["MailConfigurations:FromName"];
        command.FromKey = configuration["MailConfigurations:FromKey"];
        command.FromMail = configuration["MailConfigurations:FromMail"];
        return Ok(await mediator.Send(command));
    }
}