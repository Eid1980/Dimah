using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Dimah.Core.Application.Services.Shared;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Services.FileManagers;

namespace Dimah.API.Controllers.InternalPortal
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class FileManagerController : BaseController
    {
        private readonly IFileManagerService _fileManager;
        private readonly IMapper _mapper;
        public FileManagerController(IFileManagerService fileManager,
            ILocalizationService localizationService,
            IMapper mapper)
             : base(localizationService)
        {
            _fileManager = fileManager;
            _mapper = mapper;
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> Upload()
        {
            var formCollection = await Request.ReadFormAsync();

            CreateUploadedFileDto createUploadedFileDto = new()
            {
                EntityId = Request.Form["entityId"].ToString(),
                EntityName = Request.Form["entityName"].ToString(),
                SubEntityName = Request.Form["subEntityName"].ToString(),
                Files = formCollection.Files
            };

            _fileManager.Upload(createUploadedFileDto);

            return StatusCode(201);
        }

        [HttpGet("ChangeStatus/{fileId}")]
        public IActionResult ChangeStatus(Guid fileId)
        {
            _fileManager.ChangeStatus(fileId);
            return Ok();
        }

        [HttpDelete("{fileId}")]
        public IActionResult Delete(Guid fileId)
        {
            _fileManager.Delete(fileId);
            return NoContent();
        }

        [HttpPost("DeleteByEntityName")]
        public IActionResult DeleteByEntityName(DeleteFilesByEntityNameAndIdDto model)
        {
            _fileManager.DeleteByEntityName(model.EntityId, model.EntityName);
            return Ok(true);
        }

        [HttpGet("Download/{id}"), DisableRequestSizeLimit]
        public IActionResult Download(Guid id)
        {
            var res =  _fileManager.Download(id);
            return Ok(res);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_fileManager.GetById(id));
        }

        [HttpGet("GetByEntityId/{entityId}")]
        public IActionResult GetByEntityId(string entityId)
        {
            return Ok(_fileManager.GetByEntityId(entityId));
        }

        [HttpGet("GetByEntityName/{entityName}")]
        public IActionResult GetByEntityName(string entityName)
        {
            return Ok(_fileManager.GetByEntityName(entityName));
        }

        [HttpGet("GetByEntityNameAndActive/{entityName}")]
        public IActionResult GetByEntityNameAndActive(string entityName)
        {
            return Ok(_fileManager.GetByEntityNameAndActive(entityName));
        }


        // added by salah
        [HttpPost("UploadFile"), DisableRequestSizeLimit]
        public async Task<IActionResult> UploadFile()
        {
            var formCollection = await Request.ReadFormAsync();
            UploadedFileDto uploadedFileDto = new()
            {
                CategueryName = Request.Form["categueryName"].ToString(),
                Name = Request.Form["name"].ToString(),
                File = formCollection.Files.Any() ? formCollection.Files[0] : null
            };
            _fileManager.Upload(uploadedFileDto);
            return StatusCode(201);
        }
        [HttpPost("DeleteFile")]
        public IActionResult DeleteFile(DeleteFileDto deleteFileDto)
        {
            _fileManager.Delete(deleteFileDto);
            return NoContent();
        }

        [HttpGet("GetByEntityIdEntityName")]
        public IActionResult GetByEntityIdEntityName(string entityId, string entityName)
        {
            return Ok(_fileManager.GetByEntityIdEntityName(entityId, entityName));
        }
    }
}
