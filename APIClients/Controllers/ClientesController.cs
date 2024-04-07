using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/clientes")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClientesController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    [Route("Listar")]
    [SwaggerResponse(200, "Lista de clientes retornada com sucesso.")]
    [SwaggerResponse(404, "Nenhum cliente encontrado.")]
    [ProducesResponseType(typeof(IEnumerable<Cliente>), 200)]
    public async Task<ActionResult<IEnumerable<Cliente>>> GetAllClientes()
    {
        try
        {
            var clientes = await _clienteService.GetClientesAsync();
            if (clientes == null || clientes.Count == 0)
            {
                return NotFound();
            }

            return Ok(clientes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
        }
    }

    [HttpGet]
    [Route("ObterById/{id}")]
    [SwaggerResponse(200, "Cliente encontrado.", typeof(Cliente))]
    [SwaggerResponse(404, "Cliente não encontrado.")]
    [ProducesResponseType(typeof(Cliente), 200)]
    public async Task<ActionResult<Cliente>> GetCliente(int id)
    {
        try
        {
            var cliente = await _clienteService.GetClienteByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
        }
    }

    [HttpPost]
    [Route("Adicionar")]
    [SwaggerResponse(201, "Cliente criado com sucesso.", typeof(Cliente))]
    [ProducesResponseType(typeof(Cliente), 201)]
    public async Task<ActionResult<Cliente>> CreateCliente(Cliente cliente)
    {
        try
        {
            var newCliente = await _clienteService.CreateClienteAsync(cliente);
            return CreatedAtAction(nameof(GetCliente), new { id = newCliente.Id }, newCliente);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
        }
    }

    [HttpPut]
    [Route("Editar/{id}")]
    [SwaggerResponse(204, "Cliente atualizado com sucesso.")]
    [SwaggerResponse(400, "Solicitação inválida.")]
    [SwaggerResponse(404, "Cliente não encontrado.")]
    public async Task<IActionResult> UpdateCliente(int id, Cliente cliente)
    {
        if (id != cliente.Id)
        {
            return BadRequest();
        }

        try
        {
            await _clienteService.UpdateClienteAsync(cliente);
            return NoContent();
        }
        catch (ArgumentException)
        {
            return NotFound();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
        }
    }

    [HttpDelete]
    [Route("Excluir/{id}")]
    [SwaggerResponse(204, "Cliente excluído com sucesso.")]
    [SwaggerResponse(404, "Cliente não encontrado.")]
    public async Task<IActionResult> DeleteCliente(int id)
    {
        try
        {
            await _clienteService.DeleteClienteAsync(id);
            return NoContent();
        }
        catch (ArgumentException)
        {
            return NotFound();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
        }
    }
}
