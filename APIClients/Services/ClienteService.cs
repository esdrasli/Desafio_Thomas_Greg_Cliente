public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<List<Cliente>> GetClientesAsync()
    {
        return await _clienteRepository.GetAllClientesAsync();
    }

    public async Task<Cliente> GetClienteByIdAsync(int id)
    {
        return await _clienteRepository.GetClienteByIdAsync(id);
    }

    public async Task<Cliente> CreateClienteAsync(Cliente cliente)
    {
        await _clienteRepository.AddClienteAsync(cliente);
        return cliente;
    }

    public async Task UpdateClienteAsync(Cliente cliente)
    {
        await _clienteRepository.UpdateClienteAsync(cliente);
    }

    public async Task DeleteClienteAsync(int id)
    {
        await _clienteRepository.DeleteClienteAsync(id);
    }
}
