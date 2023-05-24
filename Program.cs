using Movie_Hub_Backend.Models;
using Movie_Hub_Backend.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MovieHubDatabaseSettings>(builder.Configuration.GetSection("MovieHubDatabase"));

builder.Services.AddSingleton<MovieService>();

// Add services to the container.   

builder.Services.AddControllers().AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

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
