using System;

namespace CRM.Models.Models
{
    public class BaseClass
    {
        public long ID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public long AssignedTo { get; set; }
        public string AssignedToUserGroup { get; set; }
    }
}
