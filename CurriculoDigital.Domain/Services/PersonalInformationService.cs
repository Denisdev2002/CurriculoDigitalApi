using CurriculoDigital.Application.DTOs;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace CurriculoDigital.Domain.Services
{
    public class PersonalInformationService
    {
        private readonly string _jsonPath;

        public PersonalInformationService(string jsonPath)
        {
            _jsonPath = jsonPath;
        }

        public async Task<IEnumerable<PersonalInformationDTO>> GetAllAsync()
        {
            var json = await File.ReadAllTextAsync(_jsonPath);
            return JsonSerializer.Deserialize<List<PersonalInformationDTO>>(json);
        }
    }
}
