
namespace Dimah.Core.Application.Dtos
{
    public class GetUploadedFileDto
    {
        public Guid Id { get; set; }
        public string EntityId { get; set; }
        public string EntityName { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public string Extention { get; set; }
        public string Base64File { get; set; }
        public bool IsActive { get; set; }
    }
}
