var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome to your first Minimal API!");

app.MapGet("/hello/{name}", (string name) => $"Hello, {name}!");
app.MapGet("/person", () => new { Name = "John Doe", Age = 30 });

app.Run();