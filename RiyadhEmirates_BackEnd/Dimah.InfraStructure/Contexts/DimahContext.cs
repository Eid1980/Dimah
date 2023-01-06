using Microsoft.EntityFrameworkCore;
using Dimah.Core.Domain.Entities;
using Dimah.Core.Domain;
using Microsoft.AspNetCore.Http;
using Dimah.Core.Application.Shared;

namespace Dimah.InfraStructure.Contexts
{
    public class DimahContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DimahContext()
        {
        }
        public DimahContext(IHttpContextAccessor httpContextAccessor, DbContextOptions<DimahContext> options) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public override int SaveChanges()
        {
            try
            {
                ChangeTracker.DetectChanges();
                foreach (var entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
                {
                    _Logging.ApplyAudit(entry, GetUserId().Value);
                }
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new BusinessException("خطأ في قاعدة البيانات برجاء التواصل مع مدير النظام");
            }
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Charity
            modelBuilder.Entity<Charity>(b =>
            {
                b.ToTable("Charities", DimahDbSchemas.DataManagement);
                b.Property(x => x.NameAr).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.Address).HasMaxLength(DimahConstants.MaxMultiTextLength);
                b.Property(x => x.Email).HasMaxLength(DimahConstants.MaxNameLength).IsRequired();
                b.Property(x => x.PhoneNumber).HasMaxLength(DimahConstants.MaxShortLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedCharities).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedCharities).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Charities());
            });
            #endregion

            #region ChartItem
            modelBuilder.Entity<ChartItem>(b =>
            {
                b.ToTable("ChartItems", DimahDbSchemas.RequestSehema);
                b.Property(x => x.CharityProjectId).IsRequired();
                b.Property(x => x.DonationValue).IsRequired();
                b.Property(x => x.DonationPeriod).IsRequired();
                b.Property(x => x.ChartItemStatusId).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<CharityProject>(x => x.CharityProject).WithMany(x => x.ChartItems).HasForeignKey(x => x.CharityProjectId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<ChartItemStatus>(x => x.ChartItemStatus).WithMany(x => x.ChartItems).HasForeignKey(x => x.ChartItemStatusId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedChartItems).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedChartItems).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region ChartItemStatus
            modelBuilder.Entity<ChartItemStatus>(b =>
        {
            b.ToTable("ChartItemStatuses", DimahDbSchemas.RequestSehema);
            b.Property(x => x.NameAr).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
            b.Property(x => x.NameEn).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
            b.Property(x => x.IsActive).IsRequired();

            b.HasData(DefaultData.ChartItemStatuses());
        });
            #endregion

            #region CharityProject
            modelBuilder.Entity<CharityProject>(b =>
            {
                b.ToTable("CharityProjects", DimahDbSchemas.DataManagement);
                b.Property(x => x.NameAr).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.CharityId).IsRequired();
                b.Property(x => x.ProjectTypeId).IsRequired();
                b.Property(x => x.DescriptionAr).HasMaxLength(DimahConstants.MaxMultiTextLength);
                b.Property(x => x.DescriptionEn).HasMaxLength(DimahConstants.MaxMultiTextLength);
                b.Property(x => x.ProjectCost).IsRequired();
                b.Property(x => x.ProjectLocation).HasMaxLength(DimahConstants.MaxDescriptionLength);
                b.Property(x => x.Image).HasMaxLength(DimahConstants.MaxDescriptionLength);
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<Charity>(x => x.Charity).WithMany(x => x.CharityProjects).HasForeignKey(x => x.CharityId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<ProjectType>(x => x.ProjectType).WithMany(x => x.CharityProjects).HasForeignKey(x => x.ProjectTypeId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedCharityProjects).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedCharityProjects).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region DailyRequestDetail
            modelBuilder.Entity<DailyRequestDetail>(b =>
            {
                b.ToTable("DailyRequestDetails", DimahDbSchemas.RequestSehema);
                b.Property(x => x.DailyRequestMainId).IsRequired();
                b.Property(x => x.Day).IsRequired();
                b.Property(x => x.IsPayed).IsRequired();

                b.HasOne<DailyRequestMain>(x => x.DailyRequestMain).WithMany(x => x.DailyRequestDetails).HasForeignKey(x => x.DailyRequestMainId).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region DailyRequestMain
            modelBuilder.Entity<DailyRequestMain>(b =>
            {
                b.ToTable("DailyRequestMains", DimahDbSchemas.RequestSehema);
                b.Property(x => x.DonationValue).IsRequired();
                b.Property(x => x.DonationPeriod).IsRequired();
                b.Property(x => x.ActForName).HasMaxLength(DimahConstants.MaxLongNameLength);
                b.Property(x => x.ActForMobile).HasMaxLength(DimahConstants.MaxShortLength);
                b.Property(x => x.IsFinished).IsRequired();
                b.Property(x => x.CreatedBy).IsRequired();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedDailyRequestMains).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
            });
            #endregion

            #region Nationality
            modelBuilder.Entity<Nationality>(b =>
            {
                b.ToTable("Nationalities", DimahDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.Code).HasMaxLength(DimahConstants.MaxShortLength);
                b.Property(x => x.Iso2).HasMaxLength(DimahConstants.MaxShortLength);
                b.Property(x => x.DialCode).HasMaxLength(DimahConstants.MaxShortLength);
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedNationalities).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Nationalities());
            });
            #endregion

            #region Poster
            modelBuilder.Entity<Poster>(b =>
            {
                b.ToTable("Posters", DimahDbSchemas.DataManagement);
                b.Property(x => x.TitleAr).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.TitleEn).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.Order).IsRequired();
                b.Property(x => x.ImageName).HasMaxLength(DimahConstants.MaxMultiTextLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedPosters).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedPosters).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Posters());
            });
            #endregion

            #region ProjectType
            modelBuilder.Entity<ProjectType>(b =>
            {
                b.ToTable("ProjectTypes", DimahDbSchemas.LookupSehema);
                b.Property(x => x.NameAr).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedProjectTypes).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedProjectTypes).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.ProjectTypes());
            });
            #endregion

            #region Role
            modelBuilder.Entity<Role>(b =>
            {
                b.ToTable("Roles", DimahDbSchemas.AuthSehema);
                b.Property(x => x.NameAr).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.NameEn).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.IsActive).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedRoles).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedRoles).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Roles());
            });
            #endregion

            #region UploadedFile
            modelBuilder.Entity<UploadedFile>(b =>
            {
                b.ToTable("UploadedFiles", DimahDbSchemas.FileManager);
                b.Property(x => x.EntityId).HasMaxLength(DimahConstants.MaxShortLength);
                b.Property(x => x.EntityName).HasMaxLength(DimahConstants.MaxLongNameLength);
                b.Property(x => x.SubEntityName).HasMaxLength(DimahConstants.MaxLongNameLength);
                b.Property(x => x.Name).HasMaxLength(DimahConstants.MaxLongNameLength);
                b.Property(x => x.OriginalName).HasMaxLength(DimahConstants.MaxLongNameLength);
                b.Property(x => x.Extention).HasMaxLength(DimahConstants.MaxShortLength);
                b.Property(x => x.IsActive).IsRequired();

                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedUploadedFiles).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedUploadedFiles).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

            });
            #endregion

            #region User
            modelBuilder.Entity<User>(b =>
            {
                b.ToTable("Users", DimahDbSchemas.AuthSehema);
                b.Property(x => x.UserName).HasMaxLength(DimahConstants.MaxShortLength).IsRequired();

                b.Property(x => x.FullNameAr).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();
                b.Property(x => x.FullNameEn).HasMaxLength(DimahConstants.MaxLongNameLength).IsRequired();

                b.Property(x => x.Email).HasMaxLength(DimahConstants.MaxNameLength).IsRequired();
                b.Property(x => x.PhoneNumber).HasMaxLength(DimahConstants.MaxShortLength).IsRequired();
                b.Property(x => x.Last2Factor).HasMaxLength(DimahConstants.MaxShortLength);
                b.Property(x => x.IsActive).IsRequired();

                b.HasOne<Nationality>(x => x.Nationality).WithMany(x => x.Users).HasForeignKey(x => x.NationalityId).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.Users());
            });
            #endregion

            #region UserRole
            modelBuilder.Entity<UserRole>(b =>
            {
                b.ToTable("UserRoles", DimahDbSchemas.AuthSehema);
                b.Property(x => x.UserId).IsRequired();
                b.Property(x => x.RoleId).IsRequired();
                b.Property(x => x.ConcurrencyStamp).IsRequired().IsConcurrencyToken();

                b.HasOne<User>(x => x.User).WithMany(x => x.UserRoles).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<Role>(x => x.Role).WithMany(x => x.UserRoles).HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.CreatedUser).WithMany(x => x.CreatedUserRoles).HasForeignKey(x => x.CreatedBy).OnDelete(DeleteBehavior.NoAction);
                b.HasOne<User>(x => x.ModifiedUser).WithMany(x => x.ModifiedUserRoles).HasForeignKey(x => x.LastModifiedBy).OnDelete(DeleteBehavior.NoAction);

                b.HasData(DefaultData.UserRoles());
            });
            #endregion

        }

        public DbSet<Charity> Charities { get; set; }
        public DbSet<ChartItem> ChartItems { get; set; }
        public DbSet<DailyRequestDetail> DailyRequestDetails { get; set; }
        public DbSet<DailyRequestMain> DailyRequestMains { get; set; }
        public DbSet<ChartItemStatus> ChartItemStatuses { get; set; }
        public DbSet<CharityProject> CharityProjects { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Poster> Posters { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UploadedFile> UploadedFiles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


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
