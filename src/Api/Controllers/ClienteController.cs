using Application.DTOs.Clientes;
using Application.UseCase.Clientes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteUseCase _clienteUseCase;
        public ClienteController(IClienteUseCase clienteUseCase)
        {
            _clienteUseCase = clienteUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> Obter(string cpf)
        {
            try
            {               
                var cliente = await _clienteUseCase.Obter(cpf);
                return Ok(cliente);               
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(CadastrarClienteDto cadastrarClienteDto)
        {
            try
            {
                return Ok(await _clienteUseCase.Cadastrar(cadastrarClienteDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
