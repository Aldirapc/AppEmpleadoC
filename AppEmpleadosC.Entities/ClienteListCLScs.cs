using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleadosC.Entities
{
    public class ClienteListCLScs
    {
        public int CodigoCliente { get; set; }
        public string NombreCliente { get; set; } = null!;
        public string Representante { get; set; } = null!;
        public decimal LimiteCredito { get; set; }

    }
}
