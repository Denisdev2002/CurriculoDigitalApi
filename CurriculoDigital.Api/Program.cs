using CurriculoDigital.Domain.Services;
using Microsoft.Extensions.FileProviders;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

void AddJsonService<TService>(string fileName) where TService : class
{
    builder.Services.AddScoped(provider =>
    {
        var env = provider.GetRequiredService<IWebHostEnvironment>();
        var jsonPath = Path.Combine(env.ContentRootPath, "Data", fileName);
        return Activator.CreateInstance(typeof(TService), jsonPath) as TService
               ?? throw new InvalidOperationException($"Failed to create {typeof(TService)}");
    });
}

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddAuthorization();

// Add services to the container.
AddJsonService<SocialMediaService>("socialMedia.json");
AddJsonService<PersonalInformationService>("personalInformation.json");
AddJsonService<ExperienceService>("experience.json");
AddJsonService<ProjectService>("project.json");

builder.Services.AddControllers();
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