using System.ComponentModel.DataAnnotations;

namespace SMS.Server.Data.Models
{
    public class Class
    {
        [Key]
        public Guid ClassId { get; set; }
        public string ClassName { get; set; }
        public Guid SectionId { get; set; }
        public Section? Section { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastUpdatedBy { get; set; }
        public ICollection<ClassSchedule>? ClassSchedules { get; set; }
    }
}
