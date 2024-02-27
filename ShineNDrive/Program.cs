
using Microsoft.EntityFrameworkCore;
using ShineNDrive_DAL;
using ShineNDrive_BLL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(o => o.AddPolicy("AllowAnyOrigin",
                     builder =>
                     {
                         builder.AllowAnyOrigin()
                                 .AllowAnyMethod()
                                 .AllowAnyHeader();
                     }));

builder.Services.RegisterDALDependencies(builder.Configuration);
builder.Services.RegisterBLLDependencies(builder.Configuration);



var app = builder.Build();

app.UseCors("AllowAnyOrigin");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
