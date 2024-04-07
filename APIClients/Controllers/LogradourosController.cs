using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/clientes/{clienteId}/logradouros")]
[ApiController]
public class LogradourosController : ControllerBase
{
    private readonly ILogradouroService _logradouroService;

    public LogradourosController(ILogradouroService logradouroService)
    {
        _logradouroService = logradouroService;
    }

    [HttpGet]
    [Route("Listar")]
    [SwaggerResponse(200, "Lista de logradouros retornada com sucesso.")]
    [SwaggerResponse(404, "Nenhum logradouro encontrado.")]
    [ProducesResponseType(typeof(IEnumerable<Logradouro>), 200)]
    public async Task<ActionResult<IEnumerable<Logradouro>>> GetLogradouros(int clienteId)
    {
        try
        {
            var logradouros = await _logradouroService.GetLogradourosByClienteIdAsync(clienteId);
            if (logradouros == null || logradouros.Count == 0)
            {
                return NotFound();
            }

            return Ok(logradouros);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
        }
    }

    [HttpGet]
    [Route("obterById/{id}")]
    [SwaggerResponse(200, "Logradouro encontrado.", typeof(Logradouro))]
    [SwaggerResponse(404, "Logradouro não encontrado.")]
    [ProducesResponseType(typeof(Logradouro), 200)]
    public async Task<ActionResult<Logradouro>> GetLogradouro(int clienteId, int id)
    {
        try
        {
            var logradouro = await _logradouroService.GetLogradouroByIdAsync(clienteId, id);
            if (logradouro == null)
            {
                return NotFound();
            }

            return Ok(logradouro);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
        }
    }

    [HttpPost]
    [Route("Adicionar")]
    [SwaggerResponse(201, "Logradouro criado com sucesso.", typeof(Logradouro))]
    [ProducesResponseType(typeof(Logradouro), 201)]
    public async Task<ActionResult<Logradouro>> PostLogradouro(int clienteId, Logradouro logradouro)
    {
        try
        {
            var newLogradouro = await _logradouroService.AddLogradouroAsync(clienteId, logradouro);
            return CreatedAtAction(nameof(GetLogradouro), new { clienteId = clienteId, id = newLogradouro.Id }, newLogradouro); // 201 Created
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

    [HttpPut]
    [Route("Editar/{id}")]
    [SwaggerResponse(204, "Logradouro atualizado com sucesso.")]
    [SwaggerResponse(400, "Solicitação inválida.")]
    [SwaggerResponse(404, "Logradouro não encontrado.")]
    public async Task<IActionResult> PutLogradouro(int clienteId, int id, Logradouro logradouro)
    {
        if (id != logradouro.Id || clienteId != logradouro.ClienteId)
        {
            return BadRequest();
        }

        try
        {
            await _logradouroService.UpdateLogradouroAsync(clienteId, logradouro);
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
    [SwaggerResponse(204, "Logradouro excluído com sucesso.")]
    [SwaggerResponse(404, "Logradouro não encontrado.")]
    public async Task<IActionResult> DeleteLogradouro(int clienteId, int id)
    {
        try
        {
            await _logradouroService.DeleteLogradouroAsync(clienteId, id);
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
