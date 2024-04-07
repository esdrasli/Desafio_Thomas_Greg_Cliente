using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class LogradouroService : ILogradouroService
{
    private readonly ILogradouroRepository _logradouroRepository;

    public LogradouroService(ILogradouroRepository logradouroRepository)
    {
        _logradouroRepository = logradouroRepository;
    }

    public async Task<List<Logradouro>> GetLogradourosByClienteIdAsync(int clienteId)
    {
        try
        {
            return await _logradouroRepository.GetLogradourosByClienteIdAsync(clienteId);
        }
        catch (Exception ex)
        {
            // Aqui você pode logar a exceção ou tratar de outra forma
            throw new Exception("Erro ao obter logradouros do cliente.", ex);
        }
    }

    public async Task<Logradouro> GetLogradouroByIdAsync(int clienteId, int logradouroId)
    {
        try
        {
            var logradouro = await _logradouroRepository.GetLogradouroByIdAsync(clienteId, logradouroId);
            if (logradouro == null)
            {
                throw new Exception("Logradouro não encontrado.");
            }
            return logradouro;
        }
        catch (Exception ex)
        {
            // Aqui você pode logar a exceção ou tratar de outra forma
            throw new Exception("Erro ao obter logradouro por ID.", ex);
        }
    }

    public async Task<Logradouro> AddLogradouroAsync(int clienteId, Logradouro logradouro)
    {
        try
        {
            var existingLogradouro = await _logradouroRepository.GetLogradouroByIdAsync(clienteId, logradouro.Id);
            if (existingLogradouro != null)
            {
                throw new Exception("Já existe um logradouro com o mesmo ID para este cliente.");
            }
            return await _logradouroRepository.AddLogradouroAsync(clienteId, logradouro);
        }
        catch (Exception ex)
        {
            // Aqui você pode logar a exceção ou tratar de outra forma
            throw new Exception("Erro ao adicionar logradouro.", ex);
        }
    }

    public async Task UpdateLogradouroAsync(int clienteId, Logradouro logradouro)
    {
        try
        {
            var existingLogradouro = await _logradouroRepository.GetLogradouroByIdAsync(clienteId, logradouro.Id);
            if (existingLogradouro == null)
            {
                throw new Exception("Logradouro não encontrado.");
            }
            await _logradouroRepository.UpdateLogradouroAsync(clienteId, logradouro);
        }
        catch (Exception ex)
        {
            // Aqui você pode logar a exceção ou tratar de outra forma
            throw new Exception("Erro ao atualizar logradouro.", ex);
        }
    }

    public async Task DeleteLogradouroAsync(int clienteId, int logradouroId)
    {
        try
        {
            var existingLogradouro = await _logradouroRepository.GetLogradouroByIdAsync(clienteId, logradouroId);
            if (existingLogradouro == null)
            {
                throw new Exception("Logradouro não encontrado.");
            }
            await _logradouroRepository.DeleteLogradouroAsync(clienteId, logradouroId);
        }
        catch (Exception ex)
        {
            // Aqui você pode logar a exceção ou tratar de outra forma
            throw new Exception("Erro ao excluir logradouro.", ex);
        }
    }
}
