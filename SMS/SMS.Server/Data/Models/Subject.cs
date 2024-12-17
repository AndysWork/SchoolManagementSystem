using System.ComponentModel.DataAnnotations;

namespace SMS.Server.Data.Models
{
    public class Subject
    {
        [Key]
        public Guid SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastUpdatedBy { get; set; }
    }
}
