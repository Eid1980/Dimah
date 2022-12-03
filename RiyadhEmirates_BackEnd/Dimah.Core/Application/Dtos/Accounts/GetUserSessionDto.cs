
namespace Dimah.Core.Application.Dtos
{
    public class GetUserSessionDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public bool IsEmployee { get; set; }
        public UploadedFileBase64Dto Image { get; set; }
    }
}
