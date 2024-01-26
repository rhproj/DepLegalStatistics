using DLStat.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbConrtext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DLStatConnection")));

builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddCors(opt =>  //+
{
    opt.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
    //opt.AddPolicy("myAllow", builder => builder.WithOrigins("*"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors(); //+

app.UseAuthorization();

app.UseDeveloperExceptionPage(); //+
app.MapControllers();
app.Run();
