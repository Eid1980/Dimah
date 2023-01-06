using System;

namespace Dimah.Core.Domain.Entities
{
    public class NewsComment
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public string Comment { get; set; }
        public int NewsCommentStageId { get; set; }
        public string Email { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual User ModifiedUser { get; set; }
        public News News { get; set; }
        public NewsCommentStage NewsCommentStage { get; set; }
    }
}
