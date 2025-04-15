using CurriculoDigital.Domain.Entities.Personal;
using CurriculoDigital.Domain.IRepository;
using CurriculoDigital.Domain.Services.Base;
using CurriculoDigital.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoDigital.Domain.Services
{
    public class ExperienceService : ServiceGeneric<Experience>
    {
        public ExperienceService(IRepositoryGeneric<Experience> repository) : base(repository)
        {
        }
    }
}
