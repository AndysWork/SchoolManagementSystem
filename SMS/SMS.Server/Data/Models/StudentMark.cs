using SMS.Server.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Server.Data.Models
{
    public class StudentMark
    {
        [Key]
        public Guid MarkEntryId { get; set; }
        public Guid StudentId { get; set; }
        public int? ObtainedScore { get; set; }
        public Grades? Grade { get; set; } = Grades.A;
        public ResultType? PassStatus { get; set; } = ResultType.Passed;
        public string? Feedback { get; set; }
        public Student? Student { get; set; }
        public Guid SubjectId { get; set; }
        public Subject? Subject { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastUpdatedBy { get; set; }
    }
}
