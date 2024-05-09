using Microsoft.AspNetCore.Mvc;
using PortalPruebaTropic.Interface;

namespace PortalPruebaTropic.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly IEmpleado _iempleado;

        public EmpleadosController(IEmpleado iempleado) 
        {
            this._iempleado = iempleado;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> listaEmpleado()
        {
            try
            {
                var res = await _iempleado.listaEmpleado();

                return PartialView("EmpleadosCons", res);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
