using MediatR;
using SMS.Server.Data;
using SMS.Server.Data.Models;
using SMS.Server.Queries.Students;
using Microsoft.EntityFrameworkCore;

namespace SMS.Server.Handlers.Students
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
    {
        private readonly SMSDbContext _context;
        public GetStudentByIdHandler(SMSDbContext context) => _context = context;

        public async Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.StudentId == request.StudentId);
        }
    }
}
