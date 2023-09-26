using ResteurantApiAspNetCore2;
using ResteurantApiAspNetCore2.Repositories;
using ResteurantApiAspNetCore2.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddEndpointsApiExplorer(); - dodano do DependencyInjection.cs
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerConfiguration();

//builder.Services.AddScoped<IResteurantRepository, ResteurantRepository>();  //wstrzykiwanie za³e¿noœci  - dependenci injection
//AddScoped - na czas odczytywania httm
//AddSingleton - raz dodane na cykl ¿ycia aplikacji
//AddTransient - za ka¿dym razem kiedy robimy zapytanie
builder.Services.AddRepositories();
builder.Services.AddServices();

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

//Duck duck= new Duck();
//IFlyable flyable = new IFlyable();
//IFlyable duck2 = new Duck();