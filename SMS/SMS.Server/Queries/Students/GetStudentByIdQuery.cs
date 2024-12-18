using MediatR;
using SMS.Server.Data.Models;

namespace SMS.Server.Queries.Students
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        public Guid StudentId { get; set; }

        public GetStudentByIdQuery(Guid studentId) => StudentId = studentId;
    }
}
