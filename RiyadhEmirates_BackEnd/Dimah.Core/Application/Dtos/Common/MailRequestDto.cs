using Microsoft.AspNetCore.Http;

namespace Dimah.Core.Application.Dtos
{
    public class MailRequestDto
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }
}
