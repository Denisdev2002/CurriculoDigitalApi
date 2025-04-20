using CurriculoDigital.Domain.Services;
using Microsoft.Extensions.FileProviders;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Add services to the container.
builder.Services.AddScoped(provider =>
{
    var env = provider.GetRequiredService<IWebHostEnvironment>();
    var jsonPath = Path.Combine(env.ContentRootPath, "Data", "socialMedia.json");
    return new SocialMediaService(jsonPath);
});
builder.Services.AddScoped(provider =>
{
    var env = provider.GetRequiredService<IWebHostEnvironment>();
    var jsonPath = Path.Combine(env.ContentRootPath, "Data", "personalInformation.json");
    return new PersonalInformationService(jsonPath);
});
builder.Services.AddScoped(provider =>
{
    var env = provider.GetRequiredService<IWebHostEnvironment>();
    var jsonPath = Path.Combine(env.ContentRootPath, "Data", "experience.json");
    return new ExperienceService(jsonPath);
});
builder.Services.AddScoped(provider =>
{
    var env = provider.GetRequiredService<IWebHostEnvironment>();
    var jsonPath = Path.Combine(env.ContentRootPath, "..", "CurriculoDigital.Infra", "Data", "project.json");
    return new ProjectService(jsonPath);
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseCors("AllowAll");

app.UseStaticFiles();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
