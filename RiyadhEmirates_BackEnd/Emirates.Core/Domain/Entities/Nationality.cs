

namespace Dimah.Core.Domain.Entities
{
    public class Nationality : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Code { get; set; }
        public string Iso2 { get; set; }
        public string DialCode { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
