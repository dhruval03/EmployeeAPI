using Microsoft.EntityFrameworkCore;
using EmployeeAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Enable Swagger/OpenAPI for API documentation and testing in development environments.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Retrieve the connection string from the configuration.
string connectionString = builder.Configuration.GetConnectionString("DevConnection")
                          ?? throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null or empty.");

// Register the DbContext with dependency injection, configuring it to use SQL Server.
builder.Services.AddDbContext<APIDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

// Map controller endpoints.
app.MapControllers();

// Run the application.
app.Run();
