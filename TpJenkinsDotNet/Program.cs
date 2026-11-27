var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
    "Bonjour ! Application ASP.NET Core déployée avec Jenkins et Docker Swarm.");

app.MapGet("/info", () => new
{
    Application = "TpJenkinsDotNet",
    Technologie = ".NET",
    Deploiement = "Jenkins + Docker Swarm"
});

app.Run();
