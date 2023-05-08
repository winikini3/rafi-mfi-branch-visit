using Microsoft.EntityFrameworkCore;
using rafi_mfi_branch_visit_api.Data;
using rafi_mfi_branch_visit_api.Helpers;
using rafi_mfi_branch_visit_api.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IWeatherForecaseHelper, WeatherForecasetHelper>();
builder.Services.AddTransient<ICountryHelper, CountryHelper>();
builder.Services.AddTransient<IBranchVisitFormsHelper, BranchVisitFormsHelper>();
builder.Services.AddDbContext<DataContext>(database => database.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient, ServiceLifetime.Singleton);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
