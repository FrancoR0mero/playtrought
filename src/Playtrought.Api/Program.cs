using Microsoft.EntityFrameworkCore;
using Playtrought.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// EF Core — empty DbContext, MySQL placeholder connection (lazy; never opened in Sprint 0)
builder.Services.AddDbContext<AppDbContext>(o =>
    o.UseMySQL(builder.Configuration.GetConnectionString("MySql") ?? ""));

// Swagger / OpenAPI
builder.Services.AddSwaggerGen();

// CORS — Angular dev server
builder.Services.AddCors(o =>
{
    o.AddPolicy("AngularDev", p =>
    {
        var origins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>()
            ?? new[] { "http://localhost:4200" };
        p.WithOrigins(origins).AllowAnyHeader().AllowAnyMethod();
    });
});

// SignalR services (no hub yet — Sprint 0 registers the framework only)
builder.Services.AddSignalR();

// Health checks
builder.Services.AddHealthChecks();

var app = builder.Build();

// Pipeline
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AngularDev");
app.MapControllers();
app.MapHealthChecks("/health");
app.Run();
