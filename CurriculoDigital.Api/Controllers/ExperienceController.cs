using CurriculoDigital.Api.Controllers.Base;
using CurriculoDigital.Domain.Entities.Personal;
using CurriculoDigital.Domain.Services.Base;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class ExperienceController : ControllerGeneric<Experience>
    {
        public ExperienceController(ServiceGeneric<Experience> service) : base(service) { }
    }
}
