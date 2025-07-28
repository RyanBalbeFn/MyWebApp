using MyWebApp.Services.Interfaces;

namespace MyWebApp.Services;

// Classe que implementa a interface do IWelcomeService
// Responsável por dar boas-vindas com informações da instância do serviço
public class WelcomeService : IWelcomeService
{
    // Data e hora em que o serviço foi criado
    DateTime _serviceCreated;
    // Atribui o ID único para instância requisitada
    Guid _serviceId;

    // Inicializa a data/hora e o ID da instância
    public WelcomeService()
    {
        _serviceCreated = DateTime.Now;
        _serviceId = Guid.NewGuid();
    }

    // Retorna a mensagem de boas-vindas com data/hora e ID da instância
    public string GetWelcomeMessage()
    {
        return $"Welcome to Contoso! The current time is {_serviceCreated}. This service instance has an ID of {_serviceId}";
    }
}