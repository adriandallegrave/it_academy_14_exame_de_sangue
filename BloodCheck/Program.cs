using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
using BloodCheck.Models;
using BloodCheck.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BloodCheckContext>(options => {
	options.UseSqlServer("name=ConnectionStrings:DefaultConnection");
	options.LogTo(Console.WriteLine).EnableSensitiveDataLogging();
});
builder.Services.AddScoped<IPatientRepository, PatientRepositoryEF>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepositoryEF>();
builder.Services.AddScoped<IExamRepository, ExamRepositoryEF>();
builder.Services.AddScoped<IRequestRepository, RequestRepositoryEF>();
builder.Services.AddScoped<IRequestExamRepository, RequestExamRepositoryEF>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader()
        );
    }
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
