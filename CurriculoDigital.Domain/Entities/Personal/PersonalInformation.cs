using CurriculoDigital.Domain.Entities.Base;
using CurriculoDigital.Domain.Entities.Midias;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurriculoDigital.Domain.Entities.Personal
{
    public class PersonalInformation : EntidadeBase
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Apresentation { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
        public List<Experience> Experience { get; set; }

        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public int Idade => DateTime.Today.Year - DateOfBirth.Year;


    }
}
