using Dimah.Core.Application.Dtos;
using Microsoft.AspNetCore.Http;

namespace Dimah.Core.Application.Services.FileManagers
{
    public interface IFileManagerService
    {
        int Upload(CreateUploadedFileDto createUploadedFileModel);
        void Delete(Guid fileId);
        void DeleteByEntityName(string entityId, string entityName);
        UploadedFileBase64Dto GetById(Guid id);
        List<GetUploadedFileDto> GetByEntityId(string entityId);
        List<GetUploadedFileDto> GetByEntityName(string entityName);
        UploadedFileBase64Dto Download(Guid fileId);
        void ChangeStatus(Guid fileId);
        List<GetUploadedFileDto> GetByEntityNameAndActive(string entityName);
        UploadedFileBase64Dto GetBase64File(int entityId, string entityName);
        UploadedFileBase64Dto GetBase64File(Guid entityId, string entityName);
        List<UploadedFileBase64Dto> GetBase64BySubEntityName(string entityId, string entityName, string subEntityName);


        // added by salah
        bool Upload(UploadedFileDto uploadedFileDto);
        void Delete(DeleteFileDto deleteFileDto);
        GetUploadedFileDto GetByEntityIdEntityName(string entityId, string entityName);
    }
}
