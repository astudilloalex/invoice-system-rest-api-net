using Microsoft.OpenApi.Models;
using NLog;

string _swaggerDocName = "v1.0";

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//Configure log.
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc(_swaggerDocName, new OpenApiInfo { Title = "SIPROK Appointments API v1.0", Version = "1.0" });
});

#region Declare all repositories sorted alphabetically
//builder.Services.AddScoped<IAddressRepository, AddressRepository>();
#endregion

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
