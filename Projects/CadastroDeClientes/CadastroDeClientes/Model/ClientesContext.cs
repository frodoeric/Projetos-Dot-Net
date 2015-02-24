using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Model
{
    public class ClientesContext: DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

    }
}
