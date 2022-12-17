using AutoMapper;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Shared;
using Dimah.Core.Domain.Entities;
using Dimah.Core.Domain.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Dimah.Core.Application.Services.ChartItems
{
    public class ChartItemService : BaseService, IChartItemService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ChartItemService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper,
            IHttpContextAccessor httpContextAccessor)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public IApiResponse GetById(Guid id)
        {
            var chartItem = _dimahUnitOfWork.Repository<ChartItem>().FirstOrDefault(l => l.Id.Equals(id), i => i.CharityProject);
            if (chartItem == null)
                throw new NotFoundException(typeof(ChartItem).Name);
            return GetResponse(data: _mapper.Map<GetChartItemDetailsDto>(chartItem));
        }
        public IApiResponse GetCurrentChart()
        {
            var chartItems = _dimahUnitOfWork.Repository<ChartItem>()
                .Where(x => x.CreatedBy == GetUserId() && x.ChartItemStatusId == (int)SystemEnums.ChartItemStatuses.New)
                .Include(i => i.CharityProject).ToList();
            return GetResponse(data: _mapper.Map<List<CurrentChartListDto>>(chartItems));
        }

        public IApiResponse Create(CreateChartItemDto createModel)
        {
            Guid response;
            var existItem = _dimahUnitOfWork.Repository<ChartItem>().Where(x => x.CreatedBy == GetUserId() &&
                x.ChartItemStatusId == (int)SystemEnums.ChartItemStatuses.New &&
                x.CharityProjectId == createModel.CharityProjectId &&
                x.DonationValue == createModel.DonationValue).FirstOrDefault();
            if (existItem == null)
            {
                var addedModel = _dimahUnitOfWork.Repository<ChartItem>().Add(_mapper.Map<ChartItem>(createModel));
                addedModel.ChartItemStatusId = (int)SystemEnums.ChartItemStatuses.New;
                response = addedModel.Id;
            }
            else
            {
                existItem.DonationPeriod = existItem.DonationPeriod + createModel.DonationPeriod;
                response = existItem.Id;
            }
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: response);
        }
        public IApiResponse Update(UpdateChartItemDto updateModel)
        {
            var chartItem = _dimahUnitOfWork.Repository<ChartItem>().FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (chartItem == null)
                throw new NotFoundException(typeof(ChartItem).Name);
            updateModel.ChartItemStatusId = chartItem.ChartItemStatusId;
            updateModel.CharityProjectId = chartItem.CharityProjectId;

            var existItem = _dimahUnitOfWork.Repository<ChartItem>().Where(x => x.CreatedBy == GetUserId() &&
                x.ChartItemStatusId == (int)SystemEnums.ChartItemStatuses.New &&
                x.CharityProjectId == updateModel.CharityProjectId &&
                x.DonationValue == updateModel.DonationValue && x.Id != updateModel.Id).FirstOrDefault();
            if (existItem == null)
                _dimahUnitOfWork.Repository<ChartItem>().Update(chartItem, _mapper.Map<ChartItem>(updateModel));
            else
            {
                chartItem.ChartItemStatusId = (int)SystemEnums.ChartItemStatuses.Deleted;
                existItem.DonationPeriod = existItem.DonationPeriod + updateModel.DonationPeriod;
            }
            
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse Delete(Guid id)
        {
            var chartItem = _dimahUnitOfWork.Repository<ChartItem>().FirstOrDefault(n => n.Id == id);
            if (chartItem == null)
                throw new NotFoundException(typeof(ChartItem).Name);
            chartItem.ChartItemStatusId = (int) SystemEnums.ChartItemStatuses.Deleted;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }

        public IApiResponse FinishPayment()
        {
            var currentItems = _dimahUnitOfWork.Repository<ChartItem>().Where(x => x.CreatedBy == GetUserId() &&
                x.ChartItemStatusId == (int)SystemEnums.ChartItemStatuses.New).ToList();
            if(currentItems.Count > 0)
            {
                foreach (var item in currentItems)
                {
                    var newIem = item;
                    newIem.ChartItemStatusId = (int)SystemEnums.ChartItemStatuses.Payed;
                    _dimahUnitOfWork.Repository<ChartItem>().Update(item, newIem);
                }
                _dimahUnitOfWork.ContextSaveChanges();
                return GetResponse(message: CustumMessages.MsgSuccess("تم الدفع بنجاح"));
            }
            throw new BusinessException("لا يوجد عناصر مضافة للسلة");
        }

        private Guid? GetUserId()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                Guid.TryParse(_httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type.ToLower().Contains("userid")).Value, out Guid userId);
                return userId;
            }
            return null;
        }

    }
}
