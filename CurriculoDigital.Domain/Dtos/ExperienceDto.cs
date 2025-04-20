namespace CurriculoDigital.Application.DTOs
{
    public class ExperienceDTO
    {
        public string companyName { get; set; }
        public string jobDescription { get; set; }
        public string workdescription { get; set; }
        public string imageCompanyUrl { get; set; }
        public long personalInformationId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
}

