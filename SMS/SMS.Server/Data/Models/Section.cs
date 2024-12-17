using System.ComponentModel.DataAnnotations;

namespace SMS.Server.Data.Models
{
    public class Section
    {
        [Key]
        public Guid SectionId { get; set; }
        public string SectionName { get; set; }
        public Guid ClassId { get; set; }
        public Class? Class { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastUpdatedBy { get; set; }
    }
}
