using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaNegocio
{
    public class N_Empleado
    {
        D_Empleado objEmpleado = new D_Empleado();

        public DataTable N_listado()
        {
            return objEmpleado.D_listado();
        }
    }
}