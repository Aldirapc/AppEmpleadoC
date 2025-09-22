using System.ComponentModel;
using AppEmpleadosC.Entities;
namespace AppEmpleadoC.Client.Services
{
    public class SucursalService
    {
        private List<SucursalCLS> lista;

        public SucursalService()
        {
            lista = new List<SucursalCLS>();
            lista.Add(new SucursalCLS() {idSucursal=1, nombreSucursal="La Paz" });
            lista.Add(new SucursalCLS() { idSucursal = 2, nombreSucursal = "Santa Cruz" });
            lista.Add(new SucursalCLS() { idSucursal = 3, nombreSucursal = "Cochabamba" });
        }
        public List<SucursalCLS> listarSucursal()
        {
            return lista;
        }   
    }
}
