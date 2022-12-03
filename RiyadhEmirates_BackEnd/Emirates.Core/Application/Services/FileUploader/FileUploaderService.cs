using Microsoft.AspNetCore.Http;

namespace Dimah.Core.Application.Services.FileUploader
{
    public class FileUploaderService : IFileUploaderService
    {
        public List<string> ExculdedFiles
        {
            get
            {
                return new List<string>()
                {
                    "exe",
                    "bat",
                    "bin",
                    "cmd",
                    "com",
                    "cpl",
                    "gadget",
                    "msi",
                    "ps1",
                    "scr",
                    "ws",
                    "wsf"
                };
            }
            set => throw new NotImplementedException();
        }

        public string UploadedFile(IFormFile file, string path)
        {
            string uniqueFileName = null;

            if (file != null)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(path, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                file.CopyTo(fileStream);
            }
            return uniqueFileName;
        }
        public string SaveBase64Image(string base64Image, string path)
        {
            if (!string.IsNullOrEmpty(base64Image))
            {
                if (!string.IsNullOrEmpty(path))
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }

                string extention = base64Image.Substring(base64Image.IndexOf("/") + 1,
                                               base64Image.IndexOf(";") - base64Image.IndexOf("/"));

                var index = base64Image.IndexOf("base64,") + 7;
                base64Image = base64Image.Substring(index);

                string imageName = Guid.NewGuid().ToString() + (extention == "jpeg" ? ".jpg" : $".{extention}");
                string imgPath = Path.Combine(path, imageName);
                byte[] imageBytes = Convert.FromBase64String(base64Image);

                File.WriteAllBytes(imgPath, imageBytes);

                return imageName;
            }
            else
                return "";
        }
        public void DeleteFile(string path)
        {
            if (!Directory.Exists(path))
                File.Delete(path);
        }
    }
}
