using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRegistration.Application.DTO
{
    public class PedidoDTO
    {
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public ItensPedidoDTO ItensPedido { get; set; }

    }
}
