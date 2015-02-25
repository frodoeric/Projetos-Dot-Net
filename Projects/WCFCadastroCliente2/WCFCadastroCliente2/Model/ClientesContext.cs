using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WCFCadastroCliente2.Model
{
    public class ClientesContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}