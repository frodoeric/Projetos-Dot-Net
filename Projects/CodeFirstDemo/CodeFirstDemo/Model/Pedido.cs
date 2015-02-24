using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Model
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string Descricao { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }//propriedade de navegação
    }
}
