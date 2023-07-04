using AutoMapper;
using MapperExample.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MapperExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
        
    { private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult PostStudent(List<StudentDto> studentDtos)
        {
           List< Student> student = _mapper.Map<List<StudentDto>, List<Student>>(studentDtos);
            return Ok(student);

        }
    }
}
