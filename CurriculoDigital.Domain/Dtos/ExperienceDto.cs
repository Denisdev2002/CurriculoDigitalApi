namespace CurriculoDigital.Application.DTOs
{
    public class ExperienceDTO
    {
        public string CompanyName { get; set; }
        public string JobDescription { get; set; }
        public string ImageCompanyUrl { get; set; }
        public long PersonalInformationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

