using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderRegistration.Domain.Entities;

namespace OrderRegistration.Infrastructure.Data
{
    public class OrderDbContext : DbContext
    {

        public OrderDbContext(DbContextOptions<OrderDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ItensPedido> ItensPedidos { get; set; }

        public DbSet<Produto> Produtos { get; set; }

    }
}
