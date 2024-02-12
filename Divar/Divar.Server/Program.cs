
using UnitOfWork;
using UnitOfWork.Tools;
using UnitOfWork.Tools.Enums;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>(sp =>
{
    Options options =
        new Options
        {
            Provider =
                (Provider)
                Convert.ToInt32(builder.Configuration.GetSection(key: "DatabaseProvider").Value),
            #region EntityFrameworkCore ConnectionString(commented)

            /*
              using Microsoft.EntityFrameworkCore;
              ConnectionString =
            	Configuration.GetConnectionString().GetSection(key: "MyConnectionString").Value,
            */

            #endregion

            ConnectionString =
                builder.Configuration.GetSection(key: "ConnectionStrings").GetSection(key: "MyConnectionString").Value,
            DatabaseName = builder.Configuration.GetSection(key: "ConnectionStrings").GetSection(key:"DatabaseName").Value,
        };

    return new UnitOfWork.UnitOfWork(options: options);
});

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
