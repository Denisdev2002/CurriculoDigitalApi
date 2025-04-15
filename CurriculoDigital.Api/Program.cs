using CurriculoDigital.Domain.IRepository;
using CurriculoDigital.Domain.Services;
using CurriculoDigital.Domain.Services.Base;
using CurriculoDigital.Infra;
using CurriculoDigital.Infra.Base;
using CurriculoDigital.Infra.Interfaces;
using CurriculoDigital.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(IRepositoryGeneric<>), typeof(RepositoryGeneric<>));

builder.Services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();
builder.Services.AddScoped<IPersonalInformationRepository, PersonalInformationRepository>();
builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();

builder.Services.AddScoped(typeof(ServiceGeneric<>));

builder.Services.AddScoped<SocialMediaService>();
builder.Services.AddScoped<PersonalInformationService>();
builder.Services.AddScoped<ExperienceService>();

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
