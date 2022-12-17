using Microsoft.EntityFrameworkCore;

namespace Dimah.InfraStructure.Contexts
{
    class _Logging
    {
        const string CreatedByProperty = "CreatedBy";
        const string CreatedAtProperty = "CreatedDate";

        const string LastModifiedByProperty = "LastModifiedBy";
        const string LastModifiedAtProperty = "LastModifiedDate";

        public static void ApplyAudit(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entityEntry, Guid UserId)
        {
            var type = entityEntry.Entity.GetType();
            if (entityEntry.State == EntityState.Added)
            {
                if (type.GetProperty(CreatedByProperty) != null)
                {
                    var createdByProperty = entityEntry.Property(CreatedByProperty);
                    createdByProperty.CurrentValue = UserId;
                }
                if (type.GetProperty(CreatedAtProperty) != null)
                {
                    var createdAtProperty = entityEntry.Property(CreatedAtProperty);
                    createdAtProperty.CurrentValue = DateTime.Now;
                }
            }
            if (entityEntry.State == EntityState.Modified)
            {
                if (type.GetProperty(CreatedByProperty) != null)
                {
                    var createdByProperty = entityEntry.Property(CreatedByProperty);
                    createdByProperty.IsModified = false;
                }
                if (type.GetProperty(CreatedAtProperty) != null)
                {
                    var createdAtProperty = entityEntry.Property(CreatedAtProperty);
                    createdAtProperty.IsModified = false;
                }
                if (type.GetProperty(LastModifiedByProperty) != null)
                {
                    var modifiedByProperty = entityEntry.Property(LastModifiedByProperty);
                    modifiedByProperty.CurrentValue = UserId;
                }
                if (type.GetProperty(LastModifiedAtProperty) != null)
                {
                    var modifiedAtProperty = entityEntry.Property(LastModifiedAtProperty);
                    modifiedAtProperty.CurrentValue = DateTime.Now;
                }
            }
        }
    }
}
