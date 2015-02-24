using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1
{
    public partial class Cliente
    {
        public string NomeCompleto
        {
            get { return Nome + " " + Sobrenome; }
        }
    }
}
