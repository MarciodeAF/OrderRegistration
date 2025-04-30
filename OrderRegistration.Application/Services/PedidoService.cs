using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using OrderRegistration.Domain.Entities;
using OrderRegistration.Domain.Interface;

namespace OrderRegistration.Application.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<Pedido> CreateAsync(Pedido pedido)
        {
            return await _pedidoRepository.CreateAsync(pedido);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _pedidoRepository.DeleteAsync(id);
        }

        public async Task<List<Pedido>> GetAllAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

        public async Task<Pedido> GetByIdAsync(int id)
        {
            return await _pedidoRepository.GetByIdAsync(id);
        }

        public async Task<int> UpdateAsync(int id, Pedido pedido)
        {
            return await _pedidoRepository.UpdateAsync(id, pedido);
        }
    }
}
