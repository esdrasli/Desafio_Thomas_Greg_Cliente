public interface IClienteService
{
    Task<List<Cliente>> GetClientesAsync();
    Task<Cliente> GetClienteByIdAsync(int id);
    Task<Cliente> CreateClienteAsync(Cliente cliente);
    Task UpdateClienteAsync(Cliente cliente);
    Task DeleteClienteAsync(int id);
}
