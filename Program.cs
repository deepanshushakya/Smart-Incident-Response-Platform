using SmartIncidentManagement.Controllers;
using SmartIncidentManagement.DbContext;
using SmartIncidentManagement.Factory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Factory and Services
builder.Services.AddScoped<IServiceFactory, ServiceFactory>();
builder.Services.AddScoped<IDbContext, ApplicationDbContext>();
builder.Services.AddScoped<IIncidentController, IncidentController>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

