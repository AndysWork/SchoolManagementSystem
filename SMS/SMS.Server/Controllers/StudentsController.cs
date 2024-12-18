using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMS.Server.Commands.Students;
using SMS.Server.Queries.Students;

namespace SMS.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(CreateStudentCommand command)
        {
            var studentId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetStudentById), new { id = studentId }, studentId);
        }

        [HttpGet("{studentid}")]
        public async Task<IActionResult> GetStudentById(Guid studentid)
        {
            var student = await _mediator.Send(new GetStudentByIdQuery(studentid));
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
