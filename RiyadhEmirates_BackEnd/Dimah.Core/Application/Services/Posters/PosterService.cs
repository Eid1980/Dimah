using AutoMapper;
using AutoMapper.QueryableExtensions;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.FileManagers;
using Dimah.Core.Domain.Entities;
using X.PagedList;
using Dimah.Core.Domain.IRepositories;
using Dimah.Core.Application.Shared;

namespace Dimah.Core.Application.Services.Posters
{
    public class PosterService : BaseService, IPosterService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;
        public PosterService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper, IFileManagerService fileManagerService)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetById(Guid id)
        {
            var poster = _dimahUnitOfWork.Repository<Poster>().FirstOrDefault(l => l.Id.Equals(id));
            if (poster == null)
                throw new NotFoundException(typeof(Poster).Name);
            return GetResponse(data: _mapper.Map<GetPosterDetailsDto>(poster));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _dimahUnitOfWork.Repository<Poster>().GetQueryable()
               .ProjectTo<GetPosterListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetPosterListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var emiratesPrinces = _dimahUnitOfWork.Repository<Poster>().Where(l => l.IsActive).OrderBy(d => d.Order);
            return GetResponse(data: _mapper.Map<List<GetPosterListDto>>(emiratesPrinces));
        }

        public IApiResponse Create(CreatePosterDto createModel)
        {
            var addedModel = _dimahUnitOfWork.Repository<Poster>().Add(_mapper.Map<Poster>(createModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: new FileToUploadDto { Id = addedModel.Id.ToString(), FileName = addedModel.ImageName });
        }
        public IApiResponse Update(UpdatePosterDto updateModel)
        {
            var poster = _dimahUnitOfWork.Repository<Poster>().FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (poster == null)
                throw new NotFoundException(typeof(Poster).Name);

            var newPoster = _mapper.Map<Poster>(updateModel);
            newPoster.ImageName = string.IsNullOrEmpty(newPoster.ImageName) ? poster.ImageName : newPoster.ImageName;
            string oldImageName = poster.ImageName;

            _dimahUnitOfWork.Repository<Poster>().Update(poster, newPoster);
            if (_dimahUnitOfWork.ContextSaveChanges())
            {
                if (!string.IsNullOrEmpty(updateModel.ImageName) && !string.IsNullOrEmpty(oldImageName))
                    _fileManagerService.Delete(new DeleteFileDto
                    {
                        CategueryName = SystemEnums.FileCateguery.Posters,
                        Name = oldImageName
                    });
            }
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: new FileToUploadDto { Id = updateModel.Id.ToString(), FileName = newPoster.ImageName });
        }
        public IApiResponse ChangeStatus(Guid id)
        {
            var poster = _dimahUnitOfWork.Repository<Poster>().FirstOrDefault(n => n.Id == id);
            if (poster == null)
                throw new NotFoundException(typeof(Poster).Name);

            poster.IsActive = !poster.IsActive;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse();
        }
        public IApiResponse Delete(Guid id)
        {
            var poster = _dimahUnitOfWork.Repository<Poster>().FirstOrDefault(n => n.Id == id);
            if (poster == null)
                throw new NotFoundException(typeof(Poster).Name);

            _dimahUnitOfWork.Repository<Poster>().Remove(poster);
            if (_dimahUnitOfWork.ContextSaveChanges())
                _fileManagerService.Delete(new DeleteFileDto
                {
                    CategueryName = SystemEnums.FileCateguery.Posters,
                    Name = poster.ImageName
                });
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
