using BD.Interface;
using BD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Service
{
    public class EmpleadoServices : IEmpleados
    {
        private readonly TropicFruitXportContext _context;

        public EmpleadoServices(TropicFruitXportContext context)
        {
            this._context = context;
        }

        public async Task<List<Empleado>> ListaEmpleado()
        {
            var lista = new List<Empleado>();
            try
            {

                var query = from emp in _context.Empleados
                            join dpt in _context.Departamentos on emp.codeDepto equals dpt.codDepto
                            select new Empleado
                            {
                                nDIEmp = emp.nDIEmp,
                                nomEmp = emp.nomEmp,
                                seEmp = emp.seEmp,
                                fecNac = emp.fecNac,
                                fecIncorporacion = emp.fecIncorporacion,
                                salEmp = emp.salEmp,
                                comisionE = emp.comisionE,
                                cargoE = emp.cargoE,
                                jefeId = emp.jefeId,
                                codeDepto = emp.codeDepto,
                                departamentos = dpt
                            };

                lista = await query.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public async Task<string> InsertEmpleado(Empleado empleado)
        {
            var res = string.Empty;
            try
            {
                _context.Add(empleado);
                await _context.SaveChangesAsync();

                res = "OK";
            }
            catch (Exception)
            {
                res = "BAD";
            }
            return res;
        }
    }
}
