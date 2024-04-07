using System.Collections.Generic;
using System.Threading.Tasks;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> GetClientes();
    Task<Cliente> GetCliente(int id);
    Task CreateCliente(Cliente cliente);
    Task UpdateCliente(int id, Cliente cliente);
    Task DeleteCliente(int id);
}
