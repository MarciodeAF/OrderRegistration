using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrderRegistration.Domain.Entities
{
    public class ItensPedido
    {
        public int Id { get; set; }           

        public int Quantidade { get; set; }

        public Produto Produto { get; set; }

       // [JsonIgnore]
        public Pedido Pedido { get; set; }

       // public int idProduto { get; set; }

      

    }
}
