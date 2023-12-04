using AutoMapper;
using MagicVilla_VillaAPI;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Repository;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Conecção com banco de dados
string? connectionString = builder.Configuration.GetConnectionString("DefaultSQLConnection");
builder.Services.AddDbContext<ApplicationDbContext>(
    option => option.UseNpgsql(connectionString),
    ServiceLifetime.Transient,
    ServiceLifetime.Transient
);

var configMap = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<MappingConfig>();
});

IMapper mapper = configMap.CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddScoped<IVillaRepository, VillaRepository>();

// Problemas com o timestamp. Ao criar o seed e fazer a migration e tentar dar update no banco
// ele ficava reclamando de UTC mesmo eu usando DateTime.UtcNow nos campos dos seeds 
// Isso corrigiu
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddControllers(option =>
{
    // option.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "MagicVilla",
        Version = "v1",
    });
});


// caso queira usar um custom Logging, descomente abaixo
// builder.Services.AddSingleton<Ilogging, LoggingV2>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MagicVilla");
});
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
