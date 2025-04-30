using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderRegistration.Domain.Entities;
using OrderRegistration.Domain.Interface;
using OrderRegistration.Infrastructure.Data;

namespace OrderRegistration.Infrastructure.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly OrderDbContext _orderDbContext;

        public PedidoRepository(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        public async Task<Pedido> CreateAsync(Pedido pedido)
        {
            await _orderDbContext.Pedidos.AddAsync(pedido);
            await _orderDbContext.SaveChangesAsync();

            await _orderDbContext.Pedidos.Include(e => e.ItensPedidos).FirstOrDefaultAsync();

            return pedido;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _orderDbContext.Pedidos
                   .Where(model => model.Id == id)
                   .ExecuteDeleteAsync();
        }

        public async Task<List<Pedido>> GetAllAsync()
        {
            return await _orderDbContext.Pedidos.ToListAsync();
        }

        public async Task<Pedido> GetByIdAsync(int id)
        {
            return await _orderDbContext.Pedidos.AsNoTracking()
              .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<int> UpdateAsync(int id, Pedido pedido)
        {
            return await _orderDbContext.Pedidos
                  .Where(model => model.Id == id)
                  .ExecuteUpdateAsync(setters => setters                    
                    .SetProperty(m => m.NomeCliente, pedido.NomeCliente)
                    .SetProperty(m => m.EmailCliente, pedido.EmailCliente)             
                    .SetProperty(m => m.Pago, pedido.Pago)
                  );
        }
    }
}
