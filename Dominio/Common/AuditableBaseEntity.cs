using System;

namespace Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool Estado {get; set;} = true;
    }
}