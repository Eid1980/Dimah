using AutoMapper.QueryableExtensions;
using Dimah.Core.Application.CustomExceptions;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.DynamicSearch;
using Dimah.Core.Application.Interfaces.Helpers;
using Dimah.Core.Application.Response;
using Dimah.Core.Domain.Entities;
using X.PagedList;
using AutoMapper;
using Dimah.Core.Application.Helpers;
using Dimah.Core.Application.Services.FileManagers;
using Dimah.Core.Domain.IRepositories;

namespace Dimah.Core.Application.Services.CharityProjects
{
    public class CharityProjectService : BaseService, ICharityProjectService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;
        public CharityProjectService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper,
            IFileManagerService fileManagerService)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetById(int id)
        {
            var charityProject = _dimahUnitOfWork.Repository<CharityProject>().FirstOrDefault(l => l.Id.Equals(id), x => x.Charity, x => x.ProjectType);
            if (charityProject == null)
                throw new NotFoundException(typeof(CharityProject).Name);
            return GetResponse(data: _mapper.Map<GetCharityProjectDetailsDto>(charityProject));
        }
        public IApiResponse GetByCharityId(int id)
        {
            var charityProjects = _dimahUnitOfWork.Repository<CharityProject>().Where(l => l.CharityId == id).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetCharityProjectListDto>>(charityProjects));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _dimahUnitOfWork.Repository<CharityProject>().GetQueryable()
               .ProjectTo<GetCharityProjectListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetCharityProjectListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var charityProjects = _dimahUnitOfWork.Repository<CharityProject>().Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetCharityProjectListDto>>(charityProjects));
        }

        public IApiResponse Create(CreateCharityProjectDto createModel)
        {
            if (_dimahUnitOfWork.Repository<CharityProject>().Where(x => x.NameAr.Equals(createModel.NameAr) && x.CharityId.Equals(createModel.CharityId)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<CharityProject>().Where(x => x.NameEn.Equals(createModel.NameEn)&& x.CharityId.Equals(createModel.CharityId)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _dimahUnitOfWork.Repository<CharityProject>().Add(_mapper.Map<CharityProject>(createModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: new FileToUploadDto { Id = addedModel.Id, FileName = addedModel.Image });
        }
        public IApiResponse Update(UpdateCharityProjectDto updateModel)
        {
            var charityProject = _dimahUnitOfWork.Repository<CharityProject>().FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (charityProject == null)
                throw new NotFoundException(typeof(CharityProject).Name);

            if (_dimahUnitOfWork.Repository<CharityProject>().Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr) && x.CharityId.Equals(updateModel.CharityId)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<CharityProject>().Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn) && x.CharityId.Equals(updateModel.CharityId)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var newCharityProject = _mapper.Map<CharityProject>(updateModel);
            newCharityProject.Image = string.IsNullOrEmpty(newCharityProject.Image) ? charityProject.Image : newCharityProject.Image;
            string oldImage = charityProject.Image;

            _dimahUnitOfWork.Repository<CharityProject>().Update(charityProject, newCharityProject);
            if (_dimahUnitOfWork.ContextSaveChanges())
            {
                if (!string.IsNullOrEmpty(updateModel.Image) && !string.IsNullOrEmpty(oldImage))
                    _fileManagerService.Delete(new DeleteFileDto
                    {
                        CategueryName = SystemEnums.FileCateguery.Projects,
                        Name = oldImage
                    });
            }
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: new FileToUploadDto { Id = updateModel.Id, FileName = newCharityProject.Image });
        }
        public IApiResponse ChangeStatus(int id)
        {
            var charityProject = _dimahUnitOfWork.Repository<CharityProject>().FirstOrDefault(n => n.Id == id);
            if (charityProject == null)
                throw new NotFoundException(typeof(CharityProject).Name);

            charityProject.IsActive = !charityProject.IsActive;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var charityProject = _dimahUnitOfWork.Repository<CharityProject>().FirstOrDefault(n => n.Id == id, x => x.Charity, x => x.ProjectType);
            if (charityProject == null)
                throw new NotFoundException(typeof(CharityProject).Name);

            _dimahUnitOfWork.Repository<CharityProject>().Remove(charityProject);
            if (_dimahUnitOfWork.ContextSaveChanges())
                _fileManagerService.Delete(new DeleteFileDto
                {
                    CategueryName = SystemEnums.FileCateguery.Projects,
                    Name = charityProject.Image
                });
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _dimahUnitOfWork.Repository<CharityProject>().Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }

    }
}
