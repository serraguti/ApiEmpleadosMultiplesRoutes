using ApiEmpleadosMultiplesRoutes.Models;
using ApiEmpleadosMultiplesRoutes.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpleadosMultiplesRoutes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Empleado>> GetEmpleados()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            return empleados;
        }

        [HttpGet("{id}")]
        public ActionResult<Empleado> FindEmpleado(int id)
        {
            Empleado empleado = this.repo.FindEmpleado(id);
            return empleado;
        }
    }
}
