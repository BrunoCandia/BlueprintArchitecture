using Blueprint.Application.DomainServices;
using Blueprint.Application.Interfaces.DomainServices.Security;
using Blueprint.Application.Interfaces.Repositories.Security;
using Blueprint.Infraestructure;
using Blueprint.Infraestructure.Repositories.Security;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// use in-memory database, add the package Microsoft.EntityFrameworkCore.InMemory to make it work
//builder.Services.AddDbContext<BlueprintContext>(c =>
//    c.UseInMemoryDatabase("AspnetRunConnection"));

// use real database
builder.Services.AddDbContext<BlueprintContext>(c =>
    c.UseSqlServer(builder.Configuration.GetConnectionString("BlueprintConnection")));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

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
