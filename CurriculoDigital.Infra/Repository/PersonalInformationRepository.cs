using CurriculoDigital.Domain.Entities.Personal;
using CurriculoDigital.Infra.Base;
using CurriculoDigital.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CurriculoDigital.Infra.Repositories
{
    public class PersonalInformationRepository
         : RepositoryGeneric<PersonalInformation>, IPersonalInformationRepository
    {
        public PersonalInformationRepository(DatabaseContext context) : base(context)
        {
        }

    }
}