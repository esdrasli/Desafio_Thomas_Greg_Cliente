namespace APIClients.Repositories
{
    public interface ILogradouroRepository
    {
        Task<List<Logradouro>> GetLogradourosByClienteIdAsync(int clienteId);
        Task<Logradouro> GetLogradouroByIdAsync(int clienteId, int logradouroId);
        Task<Logradouro> AddLogradouroAsync(int clienteId, Logradouro logradouro);
        Task UpdateLogradouroAsync(int clienteId, Logradouro logradouro);
        Task DeleteLogradouroAsync(int clienteId, int logradouroId);
    }
}
