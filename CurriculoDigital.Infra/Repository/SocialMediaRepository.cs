using CurriculoDigital.Domain.Entities.Midias;
using CurriculoDigital.Infra.Base;
using CurriculoDigital.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CurriculoDigital.Infra.Repositories
{
    public class SocialMediaRepository
            : RepositoryGeneric<SocialMedia>, ISocialMediaRepository
    {
        public SocialMediaRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
