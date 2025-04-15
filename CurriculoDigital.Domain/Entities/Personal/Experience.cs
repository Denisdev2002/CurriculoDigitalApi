using CurriculoDigital.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace CurriculoDigital.Domain.Entities.Personal
{
    public class Experience : EntidadeBase
    {
        public string CompanyName { get; set; }
        public string JobDescription { get; set; }
        public string ImageCompanyUrl { get; set; }
        public long PersonalInformationId { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [NotMapped]
        public string Duration =>
       EndDate.HasValue
           ? $"{StartDate:MMM/yyyy} - {EndDate:MMM/yyyy}"
           : $"{StartDate:MMM/yyyy} - Atual";
    }
}