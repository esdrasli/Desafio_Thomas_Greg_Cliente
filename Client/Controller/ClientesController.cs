using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var clientes = await _clienteService.GetClientes();
                return View(clientes);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = $"Erro interno do servidor: {ex.Message}";
                return View("Error");
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var cliente = await _clienteService.GetCliente(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = $"Erro interno do servidor: {ex.Message}";
                return View("Error");
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _clienteService.CreateCliente(cliente);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ViewData["ErrorMessage"] = $"Erro interno do servidor: {ex.Message}";
                    return View("Error");
                }
            }
            return View(cliente);
        }

        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var cliente = await _clienteService.GetCliente(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = $"Erro interno do servidor: {ex.Message}";
                return View("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _clienteService.UpdateCliente(id, cliente);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ViewData["ErrorMessage"] = $"Erro interno do servidor: {ex.Message}";
                    return View("Error");
                }
            }
            return View(cliente);
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = await _clienteService.GetCliente(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return View(cliente);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = $"Erro interno do servidor: {ex.Message}";
                return View("Error");
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _clienteService.DeleteCliente(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = $"Erro interno do servidor: {ex.Message}";
                return View("Error");
            }
        }
    }
}
