using CurriculoDigital.Api.Filters;
using CurriculoDigital.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoDigital.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiKeyAuth]
    public class PersonalInformationController : ControllerBase
    {
        private readonly PersonalInformationService _service;

        public PersonalInformationController(PersonalInformationService service)
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