using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInfoWebAPI.Data;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StudentInfoWebAPI.Controllers
{

    [ApiController]
    [Route("/api/[Controller]")]
    public class StudentController : Controller
    {
        private readonly DatabaseContext _context;

        public StudentController(DatabaseContext context)
        {
            _context=context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> student = _context.Students.Include(x => x.College).Include(x => x.Computers).ToList();

            return Ok(student);
        }
    }
}
