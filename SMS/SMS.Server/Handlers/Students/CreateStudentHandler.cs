using MediatR;
using SMS.Server.Commands.Students;
using SMS.Server.Data;
using SMS.Server.Data.Models;

namespace SMS.Server.Handlers.Students
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Guid>
    {
        private readonly SMSDbContext _context;
        public CreateStudentHandler(SMSDbContext context) => _context = context;
        public async Task<Guid> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student
            {
                Name = request.Name,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                City = request.City,
                State = request.State,
                Country = request.Country,
                ZipCode = request.ZipCode,
                IdentityId = request.IdentityId,
                FatherName = request.FatherName,
                MotherName = request.MotherName,
                LocalGuardianName = request.LocalGuardianName,
                FatherEmail = request.FatherEmail,
                FatherPhoneNumber = request.FatherPhoneNumber,
                MotherEmail = request.MotherEmail,
                MotherPhoneNumber = request.MotherPhoneNumber,
                LocalGuardianEmail = request.LocalGuardianEmail,
                LocalGuardianPhoneNumber = request.LocalGuardianPhoneNumber
            };
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student.StudentId;
        }
    }
}
