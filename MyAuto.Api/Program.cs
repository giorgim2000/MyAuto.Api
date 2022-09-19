using Application.Abstraction;
using Application.Implementation;
using Infrastructure.DataContext;
using Infrastructure.Repository.Abstraction;
using Infrastructure.Repository.Implementation;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddTransient<ICarAdService, CarAdService>();
builder.Services.AddTransient<ICarAdRepository, CarAdRepository>();
builder.Services.AddTransient<ITransmissionTypeRepository, TransmissionTypeRepository>();

builder.Services.AddCors(options => 
    options.AddPolicy("corsPol", 
        builder => builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsPol");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
