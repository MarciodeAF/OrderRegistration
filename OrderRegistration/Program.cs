using Microsoft.EntityFrameworkCore;
using OrderRegistration.Application.Services;
using OrderRegistration.Domain.Interface;
using OrderRegistration.Infrastructure.Data;
using OrderRegistration.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration.GetConnectionString("SqlConnection");

//builder.Services.AddDbContext<OrderDbContext>(options => 
//options.UseSqlServer(connection ??
//throw new InvalidOperationException("Connection string 'OrderDbContext' not found.")));

builder.Services.AddDbContext<OrderDbContext>(options =>
options.UseInMemoryDatabase("MemoryDB"));

builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();
builder.Services.AddTransient<IPedidoService, PedidoService>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
