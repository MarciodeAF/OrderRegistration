using System.Reflection.Metadata;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderRegistration.Application.DTO;
using OrderRegistration.Application.Services;
using OrderRegistration.Domain.Entities;

namespace OrderRegistration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ret = await _pedidoService.GetAllAsync();
            return Ok(ret);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ret = await _pedidoService.GetByIdAsync(id);
            if (ret == null)
            {
                return NotFound();
            }
            return Ok(ret);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PedidoDTO pedidoDto)
        {
            var novoPedido = new Pedido()
            {
                NomeCliente = pedidoDto.NomeCliente,
                EmailCliente = pedidoDto.EmailCliente,
                Pago = false,
                DataCriacao = DateTime.Now
            };

            var createdPedido = await _pedidoService.CreateAsync(novoPedido);

            return CreatedAtAction(nameof(GetById), new { id = createdPedido.Id }, createdPedido);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Pedido updatedPedido)
        {
            int existingPedido = await _pedidoService.UpdateAsync(id, updatedPedido);
            if (existingPedido == 0)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            int ret = await _pedidoService.DeleteAsync(id);
            if (ret == 0)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
