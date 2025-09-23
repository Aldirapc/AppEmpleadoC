using AppEmpleadosC.Entities;

namespace AppEmpleadoC.Client.Services
{
    public class ClienteService
    {
        public event Func<string, Task> OnSearch = delegate { return Task.CompletedTask; };
        public async Task notificarBusqueda(string nombre)
        {
            await OnSearch.Invoke(nombre);
        }

        private List<ClienteListCLS> lista;
        public ClienteService()
        {
            lista = new List<ClienteListCLS>
            {
                new ClienteListCLS { CodigoCliente = 1, NombreCliente = "María Fernández", Representante = "Juan Pérez", LimiteCredito = 5000m },
                new ClienteListCLS { CodigoCliente = 2, NombreCliente = "José Ramírez", Representante = "Ana López", LimiteCredito = 7500m },
                new ClienteListCLS { CodigoCliente = 3, NombreCliente = "Carolina Herrera", Representante = "Carlos Gómez", LimiteCredito = 10000m },
                new ClienteListCLS { CodigoCliente = 4, NombreCliente = "Daniel Castillo", Representante = "Lucía Martínez", LimiteCredito = 12000m }

            };
        }
        public List<ClienteListCLS> listarClientes()
        {
            return lista;
        }

        public List<ClienteListCLS> filtrarClientes(string nombre)
        {
            List<ClienteListCLS> l = listarClientes();
            if (nombre == "")
            {
                return l;
            }
            else
            {
                List<ClienteListCLS> listafiltrada = l.Where(p => p.NombreCliente.ToUpper().Contains(nombre.ToUpper())).ToList();
                return listafiltrada;
            }

        }

        public void eliminarCliente(int CodigoCliente)
        {
            var listaQueda = lista.Where(x => x.CodigoCliente != CodigoCliente).ToList();
            lista = listaQueda;
        }
        public ClienteFormCLS recuperarClientePorId(int CodigoCliente)
        {
            var obj = lista.Where(p => p.CodigoCliente == CodigoCliente).FirstOrDefault();
            if (obj != null)
            {
                return new ClienteFormCLS { CodigoCliente = obj.CodigoCliente, NombreCliente = obj.NombreCliente, Representante = obj.Representante, LimiteCredito = obj.LimiteCredito };
            }
            else
            {
                return new ClienteFormCLS();
            }
        }
        public void guardarCliente(ClienteFormCLS oClienteFormCLS)
        {
            lista.Add(new ClienteListCLS { CodigoCliente = oClienteFormCLS.CodigoCliente, NombreCliente = oClienteFormCLS.NombreCliente, Representante = oClienteFormCLS.Representante, LimiteCredito = oClienteFormCLS.LimiteCredito });
        }
    }
}
