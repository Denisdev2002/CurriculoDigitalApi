using CurriculoDigital.Application.DTOs;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace CurriculoDigital.Domain.Services
{
    public class SocialMediaService
    {
        private readonly string _jsonPath;

        public SocialMediaService(string jsonPath)
        {
            _jsonPath = jsonPath;
        }

        public async Task<IEnumerable<SocialMediaDTO>> GetAllAsync()
        {
            var json = await File.ReadAllTextAsync(_jsonPath);
            return JsonSerializer.Deserialize<List<SocialMediaDTO>>(json);
        }
    }
}