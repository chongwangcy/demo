using ContextInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddScoped<DemoContext>();

var app = builder.Build();

app.MapControllers();
app.UseMiddleware<ExecutionMiddleware>();

app.Run();
