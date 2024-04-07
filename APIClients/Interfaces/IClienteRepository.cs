using System.Collections.Generic;
using System.Threading.Tasks;

public interface IClienteRepository
{
    Task<List<Cliente>> GetAllClientesAsync();
    Task<Cliente> GetClienteByIdAsync(int id);
    Task AddClienteAsync(Cliente cliente);
    Task UpdateClienteAsync(Cliente cliente);
    Task DeleteClienteAsync(int id);
}
