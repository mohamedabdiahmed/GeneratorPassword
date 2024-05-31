var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.MapGet("/", () => "Hello World Generator Password!.");

app.Run();
