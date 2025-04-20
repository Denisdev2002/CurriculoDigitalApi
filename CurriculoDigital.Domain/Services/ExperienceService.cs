using CurriculoDigital.Application.DTOs;
using System.Text.Json;

public class ExperienceService
{
    private readonly string _jsonPath;

    public ExperienceService(string jsonPath)
    {
        _jsonPath = jsonPath;
    }

    public async Task<IEnumerable<ExperienceDTO>> GetAllAsync()
    {
        var json = await File.ReadAllTextAsync(_jsonPath);
        return JsonSerializer.Deserialize<List<ExperienceDTO>>(json);
    }
}