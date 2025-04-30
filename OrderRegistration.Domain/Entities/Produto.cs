using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrderRegistration.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal Valor { get; set; }

       // [JsonIgnore]
        public List<ItensPedido> ItensPedidos { get; set; }
    }
}
