using CurriculoDigital.Api.Controllers.Base;
using CurriculoDigital.Domain.Entities.Midias;
using CurriculoDigital.Domain.Services.Base;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class SocialMediaController : ControllerGeneric<SocialMedia>
    {
        public SocialMediaController(ServiceGeneric<SocialMedia> service) : base(service) { }
    }
}
