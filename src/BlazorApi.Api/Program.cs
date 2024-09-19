using BlazorApi.Repository.Domain;
using BlazorApi.Repository.Repository;
using BlazorApi.Service;
using HealthChecks.MongoDb;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(c => c.AddProfile<MappingProfile>(), typeof(Program));
builder.Services.Configure<DbSetting>(
    builder.Configuration.GetSection("MGDatabaseSetting")
    );

var dbname = builder.Configuration.GetSection("MGDatabaseSetting:DatabaseName").Value;
var connectionString = builder.Configuration.GetSection("MGDatabaseSetting:ConnectionString").Value;
builder.Services.AddSingleton(new MongoDbHealthCheck(connectionString, dbname));
builder.Services.AddTransient(typeof(IProductRepository<>), typeof(ProductRepository<>));
builder.Services.AddTransient(typeof(IAccountRepository<>), typeof(AccountRepository<>));
builder.Services.AddTransient<IProductService, ProductService>();
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
