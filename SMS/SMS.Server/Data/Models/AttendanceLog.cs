using System.ComponentModel.DataAnnotations;

namespace SMS.Server.Data.Models
{
    public class AttendanceLog
    {
        [Key]
        public Guid AttendanceId { get; set; }
        public Guid PersonId { get; set; }
        public bool IsPresent { get; set; }
        public string? Reason { get; set; }
        public DateTime AttendanceDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastUpdatedBy { get; set; }
    }
}
