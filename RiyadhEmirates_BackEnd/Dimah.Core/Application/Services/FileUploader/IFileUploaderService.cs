using Microsoft.AspNetCore.Http;

namespace Dimah.Core.Application.Services.FileUploader
{
    public interface IFileUploaderService
    {
        List<string> ExculdedFiles { get; set; }
        string UploadedFile(IFormFile file, string path);
        string SaveBase64Image(string base64Image, string path);
        void DeleteFile(string path);
    }
}
