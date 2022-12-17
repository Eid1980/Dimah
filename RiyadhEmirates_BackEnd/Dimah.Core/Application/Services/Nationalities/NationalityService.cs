using AutoMapper;
using AutoMapper.QueryableExtensions;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Search;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Shared;
using Dimah.Core.Domain.Entities;
using Dimah.Core.Domain.IRepositories;
using X.PagedList;

namespace Dimah.Core.Application.Services.Nationalities
{
    public class NationalityService : BaseService, INationalityService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public NationalityService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var nationality = _dimahUnitOfWork.Repository<Nationality>().FirstOrDefault(l => l.Id.Equals(id));
            if (nationality == null)
                throw new NotFoundException(typeof(Nationality).Name);
            return GetResponse(data: _mapper.Map<GetNationalityDetailsDto>(nationality));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _dimahUnitOfWork.Repository<Nationality>().GetQueryable()
               .ProjectTo<GetNationalityListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetNationalityListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var Nationalities = _dimahUnitOfWork.Repository<Nationality>().Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetNationalityListDto>>(Nationalities));
        }

        public IApiResponse Create(CreateNationalityDto createModel)
        {
            if (_dimahUnitOfWork.Repository<Nationality>().Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<Nationality>().Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _dimahUnitOfWork.Repository<Nationality>().Add(_mapper.Map<Nationality>(createModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateNationalityDto updateModel)
        {
            var nationality = _dimahUnitOfWork.Repository<Nationality>().FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (nationality == null)
                throw new NotFoundException(typeof(Nationality).Name);

            if (_dimahUnitOfWork.Repository<Nationality>().Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<Nationality>().Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _dimahUnitOfWork.Repository<Nationality>().Update(nationality, _mapper.Map<Nationality>(updateModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var nationality = _dimahUnitOfWork.Repository<Nationality>().FirstOrDefault(n => n.Id == id);
            if (nationality == null)
                throw new NotFoundException(typeof(Nationality).Name);

            nationality.IsActive = !nationality.IsActive;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var nationality = _dimahUnitOfWork.Repository<Nationality>().FirstOrDefault(n => n.Id == id, x => x.Users);
            if (nationality == null)
                throw new NotFoundException(typeof(Nationality).Name);
            if (nationality.Users.Count > 0)
                throw new BusinessException("الجنسية مرتبطة بمستخدمين");

            _dimahUnitOfWork.Repository<Nationality>().Remove(nationality);
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
