using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class ClienteService : IClienteService
{
    private readonly HttpClient _httpClient;

    public ClienteService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Cliente>> GetClientes()
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<Cliente>>("api" + "/api/clientes");
    }

    public async Task<Cliente> GetCliente(int id)
    {
        return await _httpClient.GetFromJsonAsync<Cliente>("_apiUrl" + $"/api/clientes/{id}");
    }

    public async Task CreateCliente(Cliente cliente)
    {
        var response = await _httpClient.PostAsJsonAsync("_apiUrl" + "/api/clientes", cliente);
        response.EnsureSuccessStatusCode();
    }

    public async Task UpdateCliente(int id, Cliente cliente)
    {
        var response = await _httpClient.PutAsJsonAsync("_apiUrl" + $"/api/clientes/{id}", cliente);
        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteCliente(int id)
    {
        var response = await _httpClient.DeleteAsync("_apiUrl" + $"/api/clientes/{id}");
        response.EnsureSuccessStatusCode();
    }
}
