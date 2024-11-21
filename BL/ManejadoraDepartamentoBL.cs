using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManejadoraDepartamentoBL
    {
        public static Departamento GetDepartamentoBL(int id) {
            return DAL.ManejadoraDepartamento.GetDepartamento(id);
        }
    }
}
