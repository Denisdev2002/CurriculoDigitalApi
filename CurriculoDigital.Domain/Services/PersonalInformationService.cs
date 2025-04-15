using CurriculoDigital.Domain.Entities.Personal;
using CurriculoDigital.Domain.IRepository;
using CurriculoDigital.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoDigital.Domain.Services
{
    public class PersonalInformationService : ServiceGeneric<PersonalInformation>
    {
        public PersonalInformationService(IRepositoryGeneric<PersonalInformation> repository) : base(repository)
        {
        }
    }
}
