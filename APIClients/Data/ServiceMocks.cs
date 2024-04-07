using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class ServiceMocks
{
    public static Mock<IClienteService> CreateClienteServiceMock()
    {
        var clienteServiceMock = new Mock<IClienteService>();

        clienteServiceMock.Setup(service => service.GetClientesAsync()).ReturnsAsync(new List<Cliente>
        {
            new Cliente { Id = 1, Nome = "Cliente 1", Email = "cliente1@example.com" },
            new Cliente { Id = 2, Nome = "Cliente 2", Email = "cliente2@example.com" }
        });

        clienteServiceMock.Setup(service => service.GetClienteByIdAsync(It.IsAny<int>())).ReturnsAsync((int id) =>
        {
            return new Cliente { Id = id, Nome = $"Cliente {id}", Email = $"cliente{id}@example.com" };
        });

        // Adicione outros métodos e comportamentos conforme necessário

        return clienteServiceMock;
    }

    public static Mock<ILogradouroService> CreateLogradouroServiceMock()
    {
        var logradouroServiceMock = new Mock<ILogradouroService>();

        logradouroServiceMock.Setup(service => service.GetLogradourosByClienteIdAsync(It.IsAny<int>())).ReturnsAsync(new List<Logradouro>
        {
            new Logradouro { Id = 1, Endereco = "Endereço 1", ClienteId = 1 },
            new Logradouro { Id = 2, Endereco = "Endereço 2", ClienteId = 1 }
        });

        // Adicione outros métodos e comportamentos conforme necessário

        return logradouroServiceMock;
    }
}
