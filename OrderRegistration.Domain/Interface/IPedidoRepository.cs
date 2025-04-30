using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using OrderRegistration.Domain.Entities;

namespace OrderRegistration.Domain.Interface
{
    public interface IPedidoRepository
    {
        Task<List<Pedido>> GetAllAsync();
        Task<Pedido> GetByIdAsync(int id);
        Task<Pedido> CreateAsync(Pedido pedido);
        Task<int> UpdateAsync(int id, Pedido pedido);
        Task<int> DeleteAsync(int id);
    }
}
