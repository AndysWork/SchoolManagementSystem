namespace SMS.Server.Data.Models
{
    public class ClassSchedule
    {
        public Guid ClassScheduleId { get; set; }
        public Guid ClassId { get; set; }
        public Guid TeacherId { get; set; }
        public Guid SubjectId { get; set; }
        public Subject? Subject { get; set; }
        public Class? Class { get; set; }
        public Teacher? Teacher { get; set; }
        public DateTime ScheduleTime { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastUpdatedBy { get; set; }
    }
}
