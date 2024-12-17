using System.ComponentModel.DataAnnotations;

namespace SMS.Server.Data.Models
{
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string IdentityId { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public string LocalGuardianName { get; set; } = string.Empty;
        public string FatherEmail { get; set; } = string.Empty;
        public string FatherPhoneNumber { get; set; } = string.Empty;
        public string MotherEmail { get; set; } = string.Empty;
        public string MotherPhoneNumber { get; set; } = string.Empty;
        public string LocalGuardianEmail { get; set; } = string.Empty;
        public string LocalGuardianPhoneNumber { get; set; } = string.Empty;
        public DateTime EnrollmentTimeStamp { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastUpdatedBy { get; set; }
        public ICollection<AttendanceLog>? AttendanceLogs { get; set; }
        public ICollection<StudentMark>? StudentMarks { get; set; }

    }
}
