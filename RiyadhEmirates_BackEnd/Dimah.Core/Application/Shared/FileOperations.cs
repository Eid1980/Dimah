using Microsoft.AspNetCore.Http;

namespace Dimah.Core.Application.Shared
{
    public static class FileOperations
    {
        /// <summary>
        /// Save Image in server 
        /// </summary>
        /// <param name="attachment">attachement(image)</param>
        /// <returns> return unique file name</returns>
        public static string SaveImage(IFormFile attachment)
        {
            bool isValid = ValidateImage(attachment.FileName);

            if (!isValid)
                throw new Exception("Not valid image");

            string uniqueFileName = SaveFile(attachment);
            return uniqueFileName;
        }

        public static string UploadFile(IFormFile attachment)
        {
            bool isValid = ValidateFile(attachment.FileName);

            if (!isValid)
                throw new Exception("Not valid File");

            string uniqueFileName = SaveFile(attachment);
            return uniqueFileName;
        }


        /// <summary>
        /// Save file in server 
        /// </summary>
        /// <param name="attachment">attachement(file , image , ...)</param>
        /// <returns> return unique file name</returns>
        private static string SaveFile(IFormFile attachment)
        {
            try
            {
                string uniqueFileName = GenerateUniqueFileName(attachment.FileName);

                string basePath = Directory.GetCurrentDirectory();

                string uploads = Path.Combine(basePath, "wwwroot\\uploads\\");

                string filePath = uploads + uniqueFileName;

                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    attachment.CopyTo(fileStream);
                }

                return uniqueFileName;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Generate unique name for file name
        /// </summary>
        /// <param name="fileName">file name</param>
        /// <returns></returns>
        private static string GenerateUniqueFileName(string fileName)
        {
            string uniqueFileName = new string(Path.GetFileNameWithoutExtension(fileName).Take(10).ToArray()).Replace(" ", "-");

            uniqueFileName += DateTime.Now.ToString("yymmssfff") + Path.GetExtension(fileName);

            return uniqueFileName;
        }


        /// <summary>
        /// Validate extension
        /// </summary>
        /// <param name="fileName">file name</param>
        /// <returns></returns>
        private static bool ValidateImage(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName).ToLower().Trim();

            if (string.IsNullOrEmpty(fileExtension))
                return false;

            if (!fileExtension.Equals(".jpg") && fileExtension.Equals(".png") && fileExtension.Equals(".jpeg"))
                return false;

            return true;
        }

        private static bool ValidateFile(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName).ToLower().Trim();

            if (string.IsNullOrEmpty(fileExtension))
                return false;

            if (!fileExtension.Equals(".jpg") && fileExtension.Equals(".png") && fileExtension.Equals(".jpeg") && fileExtension.Equals(".txt") && fileExtension.Equals(".pdf"))
                return false;


            return true;
        }
    }
}
