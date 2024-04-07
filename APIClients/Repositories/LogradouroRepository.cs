using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class LogradouroRepository : ILogradouroRepository
{
    private readonly ApplicationDbContext _context;

    public LogradouroRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Logradouro>> GetLogradourosByClienteIdAsync(int clienteId)
    {
        return await _context.Logradouros.Where(l => l.ClienteId == clienteId).ToListAsync();
    }

    public async Task<Logradouro> GetLogradouroByIdAsync(int clienteId, int logradouroId)
    {
        return await _context.Logradouros.FirstOrDefaultAsync(l => l.ClienteId == clienteId && l.Id == logradouroId);
    }

    public async Task<Logradouro> AddLogradouroAsync(int clienteId, Logradouro logradouro)
    {
        logradouro.ClienteId = clienteId;
        _context.Logradouros.Add(logradouro);
        await _context.SaveChangesAsync();

        return logradouro;
    }


    public async Task UpdateLogradouroAsync(int clienteId, Logradouro logradouro)
    {
        if (clienteId != logradouro.ClienteId)
            throw new ArgumentException("ClienteId do logradouro não corresponde ao ClienteId fornecido.");

        _context.Entry(logradouro).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteLogradouroAsync(int clienteId, int logradouroId)
    {
        await _context.Database.ExecuteSqlInterpolatedAsync(
            $"EXEC DeleteLogradouro {clienteId}, {logradouroId}");
    }
}
