using AutoMapper;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Shared;
using Dimah.Core.Domain.Entities;
using Dimah.Core.Domain.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Dimah.Core.Application.Services.DailyRequests
{
    public class DailyRequestService : BaseService, IDailyRequestService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DailyRequestService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper, 
            IHttpContextAccessor httpContextAccessor)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public IApiResponse Create(CreateDailyRequestDto createModel)
        {
            createModel.StartDate = createModel.StartDate == null ? DateTime.Now : createModel.StartDate;
            var addedModel = _dimahUnitOfWork.Repository<DailyRequestMain>().Add(_mapper.Map<DailyRequestMain>(createModel));
            for (int i = 0; i < createModel.DonationPeriod; i++)
            {
                addedModel.DailyRequestDetails.Add(new DailyRequestDetail
                {
                    Day = DateTime.Now.AddDays(i),
                    IsPayed = false
                });
            }
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse PayRequest(Guid id)
        {
            var request = _dimahUnitOfWork.Repository<DailyRequestMain>().FirstOrDefault(n => n.Id == id, x => x.DailyRequestDetails);
            if (request == null)
                throw new NotFoundException(typeof(DailyRequestMain).Name);
            else if(request.DailyRequestStatusId != (int)SystemEnums.DailyRequestStatus.New)
                throw new BusinessException("لا يمكنكم دفع هذا الطلب");

            foreach (var item in request.DailyRequestDetails.Where(x => x.Day.Date <= DateTime.Now.Date))
            {
                item.IsPayed = true;
                // Send SMS
            }
            if (request.DailyRequestDetails.Max(x => x.Day.Date) <= DateTime.Now.Date)
                request.DailyRequestStatusId = (int)SystemEnums.DailyRequestStatus.Finished;
            else
                request.DailyRequestStatusId = (int)SystemEnums.DailyRequestStatus.Payed;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse();
        }
        public IApiResponse GetRequestProfile()
        {
            var myRequests = _mapper.Map<List<GetDailyRequestListDto>>(_dimahUnitOfWork.Repository<DailyRequestMain>().Where(x => x.CreatedBy == GetUserId() && x.DailyRequestStatusId != (int)SystemEnums.DailyRequestStatus.Deleted).Include(d => d.DailyRequestDetails).OrderByDescending(c => c.CreatedDate));
            var resposeData = new RequestProfileDto
            {
                PayedRequests = myRequests.Where(x => x.DailyRequestStatusId == (int)SystemEnums.DailyRequestStatus.Payed).ToList(),
                NewRequests = myRequests.Where(x => x.DailyRequestStatusId == (int)SystemEnums.DailyRequestStatus.New).ToList(),
                FinishedRequests = myRequests.Where(x => x.DailyRequestStatusId == (int)SystemEnums.DailyRequestStatus.Finished).ToList()
            };
            resposeData.CurrentBalance = resposeData.PayedRequests.Sum(x => x.DonationValue * x.NotPayedCount);
            resposeData.AllDonation = resposeData.PayedRequests.Sum(x => x.DonationValue * x.PayedCount) + resposeData.FinishedRequests.Sum(x => x.DonationValue * x.DonationPeriod);
            resposeData.CurrentDayDonation = _dimahUnitOfWork.Repository<DailyRequestDetail>().Where(x => x.DailyRequestMain.CreatedBy == GetUserId() && x.Day.Date == DateTime.Now.Date && x.IsPayed).Sum(x => x.DailyRequestMain.DonationValue);
            return GetResponse(data: resposeData);
        }
        public IApiResponse GetRequestDashBoard()
        {
            var myRequests = _mapper.Map<List<GetDailyRequestListDto>>(_dimahUnitOfWork.Repository<DailyRequestMain>().Where(x => x.DailyRequestStatusId != (int)SystemEnums.DailyRequestStatus.New && x.DailyRequestStatusId != (int)SystemEnums.DailyRequestStatus.Deleted).Include(d => d.DailyRequestDetails).OrderByDescending(c => c.CreatedDate));
            var resposeData = new RequestDashBoardDto
            {
                PayedRequests = myRequests.Where(x => x.DailyRequestStatusId == (int)SystemEnums.DailyRequestStatus.Payed).ToList(),
                FinishedRequests = myRequests.Where(x => x.DailyRequestStatusId == (int)SystemEnums.DailyRequestStatus.Finished).ToList()
            };
            resposeData.CurrentBalance = resposeData.PayedRequests.Sum(x => x.DonationValue * x.PayedCount) + resposeData.FinishedRequests.Sum(x => x.DonationValue * x.PayedCount);
            resposeData.RemainingBalance = resposeData.PayedRequests.Sum(x => x.DonationValue * x.NotPayedCount);
            resposeData.CurrentDayDonation = _dimahUnitOfWork.Repository<DailyRequestDetail>().Where(x => x.Day.Date == DateTime.Now.Date && x.IsPayed).Sum(x => x.DailyRequestMain.DonationValue);
            resposeData.DonationPersonCount = myRequests.GroupBy(x => x.CreatedBy).Count();

            return GetResponse(data: resposeData);
        }
        public IApiResponse GetRequestDetailsById(Guid id)
        {
            var requestDetails = _dimahUnitOfWork.Repository<DailyRequestDetail>().Where(x => x.DailyRequestMainId == id).Include(m => m.DailyRequestMain).OrderBy(s => s.Day);
            return GetResponse(data: _mapper.Map<List<GetDailyRequestDetailsListDto>>(requestDetails));
        }
        public IApiResponse Delete(Guid id)
        {
            var request = _dimahUnitOfWork.Repository<DailyRequestMain>().FirstOrDefault(n => n.Id == id);
            if (request == null)
                throw new NotFoundException(typeof(DailyRequestMain).Name);
            request.DailyRequestStatusId = (int)SystemEnums.DailyRequestStatus.Deleted;
            _dimahUnitOfWork.ContextSaveChanges();
            return GetResponse(message: CustumMessages.DeleteSuccess());
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
