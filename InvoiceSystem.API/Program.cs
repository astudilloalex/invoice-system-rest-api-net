using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;
using InvoiceSystem.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
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
    options.SwaggerDoc(_swaggerDocName, new OpenApiInfo { Title = "Invoice System API v1.0", Version = "1.0" });
});

builder.Services.AddDbContext<PostgreSQLContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQLConnection"));
});

#region Declare all repositories sorted alphabetically
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IDialInCodeRepository, DialInCodeRepository>();
builder.Services.AddScoped<IEmailRepository, EmailRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEstablishmentRepository, EstablishmentRepository>();
builder.Services.AddScoped<IGenderRepository, GenderRepository>();
builder.Services.AddScoped<IInvoiceDetailRepository, InvoiceDetailRepository>();
builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
builder.Services.AddScoped<IPersonDocumentTypeRepository, PersonDocumentTypeRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IPhoneRepository, PhoneRepository>();
builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
builder.Services.AddScoped<ITaxRepository, TaxRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
#endregion

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/" + _swaggerDocName + "/swagger.json", "Cities V1.0");
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();
