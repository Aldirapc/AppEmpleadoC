using AppEmpleadoC.Entities;
using AppEmpleadosC.Entities;

namespace AppEmpleadoC.Client.Services
{
    public class EmpleadoService
    {
        private List<EmpleadoListCLS> lista;
        public EmpleadoService()
        {
            lista = new List<EmpleadoListCLS>
            {
                new EmpleadoListCLS { Num_Empl = 1, Nombre = "Juan Perez", Cargo = "Administrador" },
                new EmpleadoListCLS { Num_Empl = 2, Nombre = "Rosa Mamani", Cargo = "Asistente" },
                new EmpleadoListCLS { Num_Empl = 3, Nombre = "Julian Apaza", Cargo = "Administrador" }
            };
        }
        public List<EmpleadoListCLS> listarEmpleados()
        {
            return lista;
        }
        public void eliminarEmpleado(int Num_Empl)
        {
            var listaQueda = lista.Where(x => x.Num_Empl != Num_Empl).ToList();
            lista = listaQueda;
        }
        public EmpleadoFormCLS recuperarEmpleadoPorId(int Num_Empl)
        {
            var obj = lista.Where(p => p.Num_Empl == Num_Empl).FirstOrDefault();
            if (obj != null)
            {
                return new EmpleadoFormCLS { Num_Empl = obj.Num_Empl, Nombre = obj.Nombre, Cargo = obj.Cargo };
            }
            else
            {
                return new EmpleadoFormCLS();
            }
        }
        public void guardarEmpleado(EmpleadoFormCLS oEmpleadoFormCLS)
        {
            lista.Add(new EmpleadoListCLS { Num_Empl = oEmpleadoFormCLS.Num_Empl, Nombre = oEmpleadoFormCLS.Nombre, Cargo = oEmpleadoFormCLS.Cargo });
        }
    }
}
