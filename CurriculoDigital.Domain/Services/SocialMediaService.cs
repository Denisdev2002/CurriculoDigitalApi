using CurriculoDigital.Domain.Entities.Midias;
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
    public class SocialMediaService : ServiceGeneric<SocialMedia>
    {
        public SocialMediaService(IRepositoryGeneric<SocialMedia> repository) : base(repository)
        {
        }
    }
}
