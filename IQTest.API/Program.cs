using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using IQTest.API.Middlewares;
using IQTest.API.Modules;
using IQTest.Core.Repositories;
using IQTest.Core.Services;
using IQTest.Core.UnitOfWorks;
using IQTest.Repository;
using IQTest.Repository.Repositories;
using IQTest.Repository.UnitOfWorks;
using IQTest.Service.Mapping;
using IQTest.Service.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));

//builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
//builder.Services.AddScoped<IQuestionService, QuestionService>();

void ConfigureServices(IServiceCollection services)
{

    services.AddCors(options =>
    {
        options.AddPolicy("AllowSpecificOrigin",
            builder => builder
                .WithOrigins("https://localhost:7170/api/Questions") // Ýzin verilen origin
                .AllowAnyHeader()
                .AllowAnyMethod()
            );
    });


}

void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{

    app.UseCors("AllowSpecificOrigin");

}


builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

builder.Host.UseServiceProviderFactory
    (new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UserCustomException();
app.UseAuthorization();

app.MapControllers();

app.Run();
