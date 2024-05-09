using BD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Interface
{
    public interface IEmpleados
    {
        Task<List<Empleado>> ListaEmpleado();
        Task<string> InsertEmpleado(Empleado empleado);
    }
}
