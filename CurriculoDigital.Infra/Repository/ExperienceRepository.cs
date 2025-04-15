using CurriculoDigital.Domain.Entities.Personal;
using CurriculoDigital.Infra.Base;
using CurriculoDigital.Infra.Interfaces;
namespace CurriculoDigital.Infra.Repositories
{
    public class ExperienceRepository : RepositoryGeneric<Experience>, IExperienceRepository
    {
        public ExperienceRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
