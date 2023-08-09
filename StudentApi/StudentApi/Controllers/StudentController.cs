using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.Service.Interface;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [Route("api/getdetails")]
        public IActionResult Details()
        {
            try
            {
                var info = _studentService.DisplayData();
                if(info == null) 
                {
                    return NotFound();
                }
                return Ok(info);

            }catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
           
            
        }
        [HttpGet("{id}")]
        public IActionResult GetDetailsById(int id)
        {
            var d = _studentService.GetDataById(id);
            if(d == null)
            {
                return NotFound(id);
            }
            return Ok(d);
        }
        [HttpPost]
        public IActionResult PostData(StudentInfo s)
        {
            var d = _studentService.PostData(s);
            if (d == null)
            {
                return NotFound();
            }
            return Ok(d);
        }

        [HttpPut]
        public IActionResult UpdateData(StudentInfo s)
        {
            var d = _studentService.UpdateData(s);
            if (d == null)
            {
                return NotFound();
            }
            return Ok(d);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteData(int id)
        {
            var d = _studentService.DeleteData(id);
            if (d == null)
            {
                return NotFound();
            }
            return Ok(d);
        }
    }
}
