using CurriculoDigital.Api.Filters;
using CurriculoDigital.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoDigital.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiKeyAuth]
    public class CoursesController : ControllerBase
    {
        private readonly CoursesService _service;

        public CoursesController(CoursesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }
    }
}