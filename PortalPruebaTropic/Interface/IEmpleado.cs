using BD.Model;
using Microsoft.AspNetCore.Mvc;

namespace PortalPruebaTropic.Interface
{
    public interface IEmpleado
    {
        Task<List<Empleado>> listaEmpleado();
    }
}
