using rafi_mfi_branch_visit_api.Extensions;

var builder = WebApplication.CreateBuilder(args);
var allowedOrigin = "AllowedOrigin";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureSwagger();
builder.Services.ConfigureAutomapper();
builder.Services.ConfigureDependencyInjection();
builder.Services.ConfigureDBContext(builder.Configuration);
builder.Services.ConfigureCORS(builder.Configuration, allowedOrigin);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(allowedOrigin);

app.MapControllers();

app.Run();
