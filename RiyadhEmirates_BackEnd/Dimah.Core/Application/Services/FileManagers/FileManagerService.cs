using AutoMapper;
using Microsoft.Extensions.Configuration;
using Dimah.Core.Domain.Entities;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Services.FileUploader;
using Microsoft.AspNetCore.Http;
using Dimah.Core.Domain.IRepositories;

namespace Dimah.Core.Application.Services.FileManagers
{
    public class FileManagerService : IFileManagerService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IFileUploaderService _fileUploaderService;

        public FileManagerService(IGenericUnitOfWork DimahUnitOfWork,
            IConfiguration config, IMapper mapper,
            IFileUploaderService fileUploaderService)
        {
            _fileUploaderService = fileUploaderService;
            _dimahUnitOfWork = DimahUnitOfWork;
            _config = config;
            _mapper = mapper;
        }

        public int Upload(CreateUploadedFileDto createUploadedFileDto)
        {
            List<CreateUploadedFileDto> uploadedFiles = new();

            foreach (var file in createUploadedFileDto.Files)
            {
                if (file.Length > 0)
                {
                    createUploadedFileDto.OriginalName = file.FileName;
                    createUploadedFileDto.Extention = Path.GetExtension(file.FileName).ToLower();

                    if (!_fileUploaderService.ExculdedFiles.Contains(createUploadedFileDto.Extention))
                    {
                        createUploadedFileDto.Name = _fileUploaderService.UploadedFile(file, _config.GetSection("FileUploadPaths:UploadedFiles").Value);
                        var model = _mapper.Map<UploadedFile>(createUploadedFileDto);
                        model.IsActive = true;
                        uploadedFiles.Add(createUploadedFileDto);

                        _dimahUnitOfWork.Repository<UploadedFile>().Add(model);
                    }
                }
            }
            if (!_dimahUnitOfWork.ContextSaveChanges())
            {
                // DELETE FILES
                foreach (var file in uploadedFiles)
                    _fileUploaderService.DeleteFile(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
            }

            return 1;
        }
        public void ChangeStatus(Guid fileId)
        {
            var uploadedFile = _dimahUnitOfWork.Repository<UploadedFile>().FirstOrDefault(f => f.Id == fileId);
            uploadedFile.IsActive = !uploadedFile.IsActive;
            _dimahUnitOfWork.ContextSaveChanges();
        }
        public void Delete(Guid fileId)
        {
            var uploadedFile = _dimahUnitOfWork.Repository<UploadedFile>().FirstOrDefault(f => f.Id == fileId);

            _dimahUnitOfWork.Repository<UploadedFile>().Remove(fileId);
            _fileUploaderService.DeleteFile(_config.GetSection("FileUploadPaths:UploadedFiles").Value + uploadedFile.Name);
            _dimahUnitOfWork.ContextSaveChanges();
        }
        public void DeleteByEntityName(string entityId, string entityName)
        {
            var uploadedFile = _dimahUnitOfWork.Repository<UploadedFile>()
                .FirstOrDefault(f => f.EntityId == entityId && f.EntityName == entityName);

            if (uploadedFile != null)
            {
                _dimahUnitOfWork.Repository<UploadedFile>().Remove(uploadedFile);
                _fileUploaderService.DeleteFile(_config.GetSection("FileUploadPaths:UploadedFiles").Value + uploadedFile.Name);
                _dimahUnitOfWork.ContextSaveChanges();
            }
        }

        public UploadedFileBase64Dto GetById(Guid id)
        {
            try
            {
                var uploadedFile = _dimahUnitOfWork.Repository<UploadedFile>().FirstOrDefault(f => f.Id.Equals(id) && f.IsActive);
                if (uploadedFile == null)
                    return null;
                var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + uploadedFile.Name);
                var base64String = Convert.ToBase64String(bytes);
                return new UploadedFileBase64Dto()
                {
                    FileName = uploadedFile.OriginalName,
                    Extention = uploadedFile.Extention,
                    Base64File = uploadedFile.Extention == ".pdf" || uploadedFile.Extention == ".docx" || uploadedFile.Extention == ".doc" || uploadedFile.Extention == ".xls" || uploadedFile.Extention == ".xlsx"
                                     ? base64String : $"data:image/{uploadedFile.Extention.Substring(1)};base64," + base64String,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<GetUploadedFileDto> GetByEntityId(string entityId)
        {
            try
            {
                var uploadedFiles = _dimahUnitOfWork.Repository<UploadedFile>().Where(f => f.EntityId == entityId && f.IsActive);
                return _mapper.Map<List<GetUploadedFileDto>>(uploadedFiles);
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<GetUploadedFileDto> GetByEntityName(string entityName)
        {
            try
            {
                var uploadedFiles = _dimahUnitOfWork.Repository<UploadedFile>().Where(f => f.EntityName == entityName);
                var mappedModels = _mapper.Map<List<GetUploadedFileDto>>(uploadedFiles);
                foreach (var file in mappedModels)
                {
                    var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                    var base64File = Convert.ToBase64String(bytes);
                    file.Base64File = file.Extention == ".pdf"
                                     || file.Extention == ".docx"
                                     || file.Extention == ".doc"
                                     || file.Extention == ".xls"
                                     || file.Extention == ".xlsx"
                                     ? base64File : $"data:image/{file.Extention.Substring(1)};base64," + base64File;
                }

                return mappedModels;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<GetUploadedFileDto> GetByEntityNameAndActive(string entityName)
        {
            try
            {
                var uploadedFiles = _dimahUnitOfWork.Repository<UploadedFile>().Where(f => f.EntityName == entityName && f.IsActive);
                var mappedModels = _mapper.Map<List<GetUploadedFileDto>>(uploadedFiles);
                foreach (var file in mappedModels)
                {
                    var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                    var base64File = Convert.ToBase64String(bytes);
                    file.Base64File = file.Extention == ".pdf"
                                     || file.Extention == ".docx"
                                     || file.Extention == ".doc"
                                     || file.Extention == ".xls"
                                     || file.Extention == ".xlsx"
                                     ? base64File : $"data:image/{file.Extention.Substring(1)};base64," + base64File;
                }

                return mappedModels;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public UploadedFileBase64Dto Download(Guid fileId)
        {
            try
            {
                var file = _dimahUnitOfWork.Repository<UploadedFile>().FirstOrDefault(f => f.Id == fileId);
                var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                var base64String = Convert.ToBase64String(bytes);

                return new UploadedFileBase64Dto()
                {
                    FileName = file.OriginalName,
                    Base64File = file.Extention == ".pdf"
                                     || file.Extention == ".docx"
                                     || file.Extention == ".doc"
                                     || file.Extention == ".xls"
                                     || file.Extention == ".xlsx"
                                     ? base64String : $"data:image/{file.Extention.Substring(1)};base64," + base64String,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
        public UploadedFileBase64Dto GetBase64File(int entityId, string entityName)
        {
            try
            {
                var file = _dimahUnitOfWork.Repository<UploadedFile>().FirstOrDefault(f => f.EntityId == entityId.ToString() && f.EntityName == entityName && f.IsActive);
                if (file == null)
                    return null;
                var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                var base64String = Convert.ToBase64String(bytes);
                return new UploadedFileBase64Dto()
                {
                    FileName = file.OriginalName,
                    Base64File = file.Extention == ".pdf" || file.Extention == ".docx" || file.Extention == ".doc" || file.Extention == ".xls" || file.Extention == ".xlsx"
                                     ? base64String : file.Extention == ".svg" ? "data:image/svg+xml;base64," + base64String : $"data:image/{file.Extention.Substring(1)};base64," + base64String,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public UploadedFileBase64Dto GetBase64File(Guid entityId, string entityName)
        {
            try
            {
                var file = _dimahUnitOfWork.Repository<UploadedFile>().FirstOrDefault(f => f.EntityId == entityId.ToString() && f.EntityName == entityName && f.IsActive);
                if (file == null)
                    return null;
                var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                var base64String = Convert.ToBase64String(bytes);
                return new UploadedFileBase64Dto()
                {
                    FileName = file.OriginalName,
                    Base64File = file.Extention == ".pdf" || file.Extention == ".docx" || file.Extention == ".doc" || file.Extention == ".xls" || file.Extention == ".xlsx"
                                     ? base64String : file.Extention == ".svg" ? "data:image/svg+xml;base64," + base64String : $"data:image/{file.Extention.Substring(1)};base64," + base64String,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<UploadedFileBase64Dto> GetBase64BySubEntityName(string entityId, string entityName, string subEntityName)
        {
            try
            {
                List<UploadedFileBase64Dto> fileList = new();

                var files = _dimahUnitOfWork.Repository<UploadedFile>().Where(f => f.EntityId == entityId
                    && f.EntityName == entityName && f.SubEntityName == subEntityName && f.IsActive);

                foreach (var file in files)
                {
                    var bytes = File.ReadAllBytes(_config.GetSection("FileUploadPaths:UploadedFiles").Value + file.Name);
                    var base64String = Convert.ToBase64String(bytes);
                    fileList.Add(new UploadedFileBase64Dto()
                    {
                        FileName = file.OriginalName,
                        Base64File = file.Extention == ".pdf"
                                     || file.Extention == ".docx"
                                     || file.Extention == ".doc"
                                     || file.Extention == ".xls"
                                     || file.Extention == ".xlsx"
                                     ? base64String : $"data:image/{file.Extention.Substring(1)};base64," + base64String,
                    });
                }

                return fileList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // added by salah
        public bool Upload(UploadedFileDto uploadedFileDto)
        {
            if (uploadedFileDto.File.Length > 0 && !_fileUploaderService.ExculdedFiles.Contains(Path.GetExtension(uploadedFileDto.Name).ToLower().Replace(".", string.Empty)))
            {
                string path = $"{_config.GetSection("FileUploadPaths:uploads").Value}{uploadedFileDto.CategueryName}";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                using var fileStream = new FileStream(Path.Combine(path, uploadedFileDto.Name), FileMode.Create);
                uploadedFileDto.File.CopyTo(fileStream);
                return true;
            }
            return false;
        }
        public void Delete(DeleteFileDto deleteFileDto)
        {
            string path = $"{_config.GetSection("FileUploadPaths:uploads").Value}{deleteFileDto.CategueryName}\\{deleteFileDto.Name}";
            if (File.Exists(path))
                File.Delete(path);
        }
        public GetUploadedFileDto GetByEntityIdEntityName(string entityId, string entityName)
        {
            var uploadedFile = _dimahUnitOfWork.Repository<UploadedFile>().FirstOrDefault(f => f.EntityId.Equals(entityId) && f.EntityName.Equals(entityName) && f.IsActive);
            if (uploadedFile == null)
                return null;
            return _mapper.Map<GetUploadedFileDto>(uploadedFile);
        }
    }
}
