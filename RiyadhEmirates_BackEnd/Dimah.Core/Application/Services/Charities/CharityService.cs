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
using Microsoft.EntityFrameworkCore;
using Dimah.Core.Domain.IRepositories;

namespace Dimah.Core.Application.Services.Charities
{
    public class CharityService : BaseService, ICharityService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public CharityService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var charity = _dimahUnitOfWork.Repository<Charity>().Where(i => i.Id == id).Include(x => x.CharityProjects).ThenInclude((y => y.ProjectType)).FirstOrDefault();
            if (charity == null)
                throw new NotFoundException(typeof(Charity).Name);
            return GetResponse(data: _mapper.Map<GetCharityDetailsDto>(charity));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _dimahUnitOfWork.Repository<Charity>().GetQueryable()
               .ProjectTo<GetCharityListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetCharityListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var charities = _dimahUnitOfWork.Repository<Charity>().Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetCharityListDto>>(charities));
        }

        public IApiResponse Create(CreateCharityDto createModel)
        {
            if (_dimahUnitOfWork.Repository<Charity>().Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<Charity>().Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _dimahUnitOfWork.Repository<Charity>().Add(_mapper.Map<Charity>(createModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateCharityDto updateModel)
        {
            var charity = _dimahUnitOfWork.Repository<Charity>().FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (charity == null)
                throw new NotFoundException(typeof(Charity).Name);

            if (_dimahUnitOfWork.Repository<Charity>().Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_dimahUnitOfWork.Repository<Charity>().Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _dimahUnitOfWork.Repository<Charity>().Update(charity, _mapper.Map<Charity>(updateModel));
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var charity = _dimahUnitOfWork.Repository<Charity>().FirstOrDefault(n => n.Id == id);
            if (charity == null)
                throw new NotFoundException(typeof(Charity).Name);

            charity.IsActive = !charity.IsActive;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var charity = _dimahUnitOfWork.Repository<Charity>().FirstOrDefault(n => n.Id == id, x => x.CharityProjects);
            if (charity == null)
                throw new NotFoundException(typeof(Charity).Name);
            if (charity.CharityProjects.Count > 0)
                throw new BusinessException("الجهة مضافة على المشاريع");

            _dimahUnitOfWork.Repository<Charity>().Remove(charity);
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse GetLookupList()
        {
            return GetResponse(data: _dimahUnitOfWork.Repository<Charity>().Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
