using CurriculoDigital.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoDigital.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiKeyAuth]
    public class SocialMediaController : ControllerBase
    {
        private readonly SocialMediaService _service;

        public SocialMediaController(SocialMediaService service)
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