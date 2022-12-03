
namespace Dimah.Core.Domain.Entities
{
    public class CharityProject : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int CharityId { get; set; }
        public int ProjectTypeId { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public double ProjectCost { get; set; }
        public string ProjectLocation { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }

        public virtual Charity Charity { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
