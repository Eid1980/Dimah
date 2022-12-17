using AutoMapper;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Shared;
using Dimah.Core.Domain.Entities;
using Dimah.Core.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimah.Core.Application.Services.Home
{
    public class HomeService : BaseService, IHomeService
    {
        private readonly IGenericUnitOfWork _dimahUnitOfWork;
        private readonly IMapper _mapper;
        public HomeService(IGenericUnitOfWork dimahUnitOfWork, IMapper mapper)
        {
            _dimahUnitOfWork = dimahUnitOfWork;
            _mapper = mapper;
        }

        public IApiResponse GetCharityProjects(Guid id)
        {
            var items = _dimahUnitOfWork.Repository<CharityProject>().Where(x => x.CharityId == id && x.IsActive && x.Charity.IsActive).
                Include(x => x.ProjectType).Select(model =>
                new DimahProjectsListDto
                {
                    Id = model.Id,
                    ProjectName = model.NameAr,
                    ProjectTypeImageName = model.ProjectType.ImageName
                }).ToList();
            return GetResponse(data: items);
        }
        public IApiResponse GetDimahTop4Projects()
        {
            var items = _dimahUnitOfWork.Repository<CharityProject>().Where(x => x.CharityId == new Guid("22d0eeca-467a-48bc-a600-3624ff0887b6") && x.IsActive).
                Include(x => x.ProjectType).OrderByDescending(x => x.CreatedDate).Take(4).Select(model =>
                new DimahProjectsListDto
                {
                    Id = model.Id,
                    ProjectName = model.NameAr,
                    ProjectTypeImageName = model.ProjectType.ImageName
                }).ToList();
            return GetResponse(data: items);
        }

        public IApiResponse GetProjectDetails(Guid id)
        {
            var charityProject = _dimahUnitOfWork.Repository<CharityProject>().FirstOrDefault(l => l.Id.Equals(id) && l.IsActive);
            if (charityProject == null)
                throw new NotFoundException(typeof(CharityProject).Name);
            var response = new ProjectDetailsDto
            {
                Id = charityProject.Id,
                CharityId = charityProject.CharityId,
                Name = charityProject.NameAr,
                Description = charityProject.DescriptionAr,
                ProjectCost = charityProject.ProjectCost,
                ProjectLocation = charityProject.ProjectLocation,
                Image = charityProject.Image,
                RelatedProjects = _dimahUnitOfWork.Repository<CharityProject>().Where(x => x.CharityId == charityProject.CharityId && x.Id != id && x.IsActive).Include(i => i.ProjectType).
                    OrderByDescending(o => o.CreatedDate).Take(10).Select(model =>
                    new DimahProjectsListDto
                    {
                        Id = model.Id,
                        ProjectName = model.NameAr,
                        ProjectTypeImageName = model.ProjectType.ImageName
                    }).ToList()
            };
            return GetResponse(data: response);
        }
    }
}
