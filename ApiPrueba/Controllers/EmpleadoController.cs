using BD.Interface;
using BD.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiPrueba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleados _iempleados;

        public EmpleadoController (IEmpleados iempleados) 
        {
            this._iempleados = iempleados;
        }

        [HttpGet]
        [Route("ListaEmpleado")]
        public async Task<List<Empleado>> ListaEmpleado()
        {
            var lista = new List<Empleado>();
            try
            {
                lista = await _iempleados.ListaEmpleado();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

        [HttpPost]
        [Route("InsertEmpleado")]
        public async Task<string> InsertEmpleado([FromBody] Empleado empleado)
        {
            var res = string.Empty;
            try
            {
                res = await _iempleados.InsertEmpleado(empleado);
            }
            catch (Exception)
            {

                throw;
            }

            return res;
        }
    }
}
