using CurriculoDigital.Domain.Dtos;
using System.Text.Json;

namespace CurriculoDigital.Domain.Services
{
    public class ProjectService
    {
        private readonly string _jsonPath;
        public ProjectService(string jsonPath)
        {
            _jsonPath = jsonPath;
        }
        public async Task<IEnumerable<ProjectDto>> GetAllAsync()
        {
            var json = await File.ReadAllTextAsync(_jsonPath);
            return JsonSerializer.Deserialize<List<ProjectDto>>(json);
        }
    }
}
