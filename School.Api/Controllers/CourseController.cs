using Escola.Escola.Business.DTOs;
using Escola.Escola.Business.Entities;
using Escola.Escola.Business.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Escola.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController: ControllerBase
    {

        private readonly ICourseService _service;
        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CourseDTO dto)
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
        public IActionResult Update([FromQuery] int Id, [FromBody] CourseDTO courseDto)
        {
            try
            {
                _service.Update(Id, courseDto);
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
                Course courseResponse = _service.FindById(Id);
                return Ok(courseResponse);
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
                List<Course> courseResponse = _service.FindAll();
                return Ok(courseResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
