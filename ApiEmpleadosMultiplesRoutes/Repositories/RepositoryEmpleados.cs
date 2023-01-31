﻿using ApiEmpleadosMultiplesRoutes.Data;
using ApiEmpleadosMultiplesRoutes.Models;

namespace ApiEmpleadosMultiplesRoutes.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in this.context.Empleados
                           select datos;
            return consulta.ToList();
        }

        public Empleado FindEmpleado(int idempleado)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.IdEmpleado == idempleado
                           select datos;
            return consulta.FirstOrDefault();
        }

        public List<string> GetOficios()
        {
            var consulta = (from datos in this.context.Empleados
                            select datos.Oficio).Distinct();
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Oficio == oficio
                           select datos;
            return consulta.ToList();
        }

        public List<Empleado> GetEmpleadosSalario(int salario)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Salario >= salario
                           select datos;
            return consulta.ToList();
        }
    }
}
