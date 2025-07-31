namespace SRP.WebUI.Dtos.Mail;

public class CreateMailDto
{
    public string? ToName { get; set; }
    public string? ToMail { get; set; }
    public string? Subject { get; set; }
    public string? Body { get; set; }
}