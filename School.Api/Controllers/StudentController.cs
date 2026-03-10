using Escola.Escola.Business.DTOs;
using Escola.Escola.Business.Entities;
using Escola.Escola.Business.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Escola.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController: ControllerBase
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create([FromBody] StudentDTO dto)
        {
            try
            {
                _service.Create(dto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] int Id)
        {
            try
            {
                _service.Delete(Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromQuery] int Id, [FromBody] StudentDTO studentDto)
        {
            try
            {
                _service.Update(Id, studentDto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult FindById(int Id)
        {
            try
            {
                Student studentResponse = _service.FindById(Id);
                return Ok(studentResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("FindAll")]
        public IActionResult FindAll()
        {
            try
            {
                List<Student> studentResponse = _service.FindAll();
                return Ok(studentResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
