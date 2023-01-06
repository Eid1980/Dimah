
namespace Dimah.Core.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? NationalityId { get; set; }
        public bool IsMale { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsActive { get; set; }

        public bool TwoFactorEnabled { get; set; } = true;

        public string Last2Factor { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }


        public virtual Nationality Nationality { get; set; }

        public virtual ICollection<Poster> CreatedPosters { get; set; }
        public virtual ICollection<Poster> ModifiedPosters { get; set; }

        public virtual ICollection<Role> CreatedRoles { get; set; }
        public virtual ICollection<Role> ModifiedRoles { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserRole> CreatedUserRoles { get; set; }
        public virtual ICollection<UserRole> ModifiedUserRoles { get; set; }

        public virtual ICollection<UploadedFile> CreatedUploadedFiles { get; set; }
        public virtual ICollection<UploadedFile> ModifiedUploadedFiles { get; set; }

        public virtual ICollection<Nationality> CreatedNationalities { get; set; }
        public virtual ICollection<Nationality> ModifiedNationalities { get; set; }

        public virtual ICollection<Charity> CreatedCharities { get; set; }
        public virtual ICollection<Charity> ModifiedCharities { get; set; }

        public virtual ICollection<CharityProject> CreatedCharityProjects { get; set; }
        public virtual ICollection<CharityProject> ModifiedCharityProjects { get; set; }
        
        public virtual ICollection<ProjectType> CreatedProjectTypes { get; set; }
        public virtual ICollection<ProjectType> ModifiedProjectTypes { get; set; }

        public virtual ICollection<ChartItem> CreatedChartItems { get; set; }
        public virtual ICollection<ChartItem> ModifiedChartItems { get; set; }

        public virtual ICollection<DailyRequestMain> CreatedDailyRequestMains { get; set; }

    }
}
