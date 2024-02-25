using ATLASWepAPI.DataAccessLayer.Implementation.DataAccessObjects;
using ATLASWepAPI.DataAccessLayer.Implementation.Repositories;
using ATLASWepAPI.DataAccessLayer.Interface.DataAccessObjects;
using ATLASWepAPI.DataAccessLayer.Interface.Repositories;
using ATLASWepAPI.Helpers.AutoMapping;
using ATLASWepAPI.Models.DataTransferObjects;
using ATLASWepAPI.Models.Entities;
using Microsoft.Extensions.DependencyInjection;
using ProcessorLibrary.DataProcessor.Implementation.Caching;
using ProcessorLibrary.DataProcessor.Interface.Caching;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ATLASDbContext>();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSingleton<IDataCacheProcessor, IMDistributedCacheProcessor>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

builder.Services.AddScoped<IDataAccessObject<Order>, OrderDAO>();
builder.Services.AddScoped<IDataAccessObject<OrderNote>, OrderNoteDAO>();
builder.Services.AddScoped<IDataAccessObject<OrderItem>, OrderItemDAO>();

builder.Services.AddScoped<IRepository<OrderDTO>, OrdersRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
