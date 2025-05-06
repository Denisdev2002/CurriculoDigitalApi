using System.Text.Json;
using CurriculoDigital.Domain.Dtos;

namespace CurriculoDigital.Domain.Services
{
    public class CoursesService
    {
        private readonly string _jsonPath;

        public CoursesService(string jsonPath)
        {
            _jsonPath = jsonPath;
        }

        public async Task<IEnumerable<CoursesDto>> GetAllAsync()
        {
            var json = await File.ReadAllTextAsync(_jsonPath);
            return JsonSerializer.Deserialize<List<CoursesDto>>(json);
        }
    }
}