using Microsoft.EntityFrameworkCore;
using StudentApi.Data;
using Microsoft.AspNetCore.Mvc;
using Modules.Student;


namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        [HttpGet("{rollNumber}")]
        public async Task<ActionResult<Student>> GetStudent(int rollNumber)
        {
            var student = await _context.Students.FindAsync(rollNumber);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStudent), new { rollNumber = student.RollNumber }, student);
        }

        [HttpPut("{rollNumber}")]
        public async Task<IActionResult> UpdateStudent(int rollNumber, Student student)
        {
            if (rollNumber != student.RollNumber)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(rollNumber))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{rollNumber}")]
        public async Task<IActionResult> DeleteStudent(int rollNumber)
        {
            var student = await _context.Students.FindAsync(rollNumber);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentExists(int rollNumber)
        {
            return _context.Students.Any(e => e.RollNumber == rollNumber);
        }
    }
}