// Aqui configuramos a injeção de dependência para criar e usar os serviços
using MyWebApp.Services.Interfaces;
using MyWebApp.Services;

// Registramos a implementação da interface para usar a instância do serviço
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IWelcomeService, WelcomeService>();

var app = builder.Build();

// Mapeamos a rota para mostrar a mensagem de boas-vindas no site
app.MapGet("/", async (IWelcomeService welcomeService1, IWelcomeService welcomeService2) =>
    {
        string message1 = $"Message1: {welcomeService1.GetWelcomeMessage()}";
        string message2 = $"Message2: {welcomeService2.GetWelcomeMessage()}";
        return $"{message1}\n{message2}";
    });

app.Run();
