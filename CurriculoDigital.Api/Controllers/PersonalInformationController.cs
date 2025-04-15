using CurriculoDigital.Api.Controllers.Base;
using CurriculoDigital.Domain.Entities.Personal;
using CurriculoDigital.Domain.Services.Base;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class PersonalInformationController : ControllerGeneric<PersonalInformation>
    {
        public PersonalInformationController(ServiceGeneric<PersonalInformation> service) : base(service) { }
    }
}
