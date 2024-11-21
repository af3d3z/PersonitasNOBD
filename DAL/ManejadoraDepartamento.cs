using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManejadoraDepartamento
    {
        /// <summary>
        /// Devuelve un departamento de la lista en base a su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Departamento requerido o uno vacío si no se encuentra</returns>
        public static Departamento GetDepartamento(int id)
        {
            int contador = 0;
            bool encontrado = false;
            Departamento depto = new Departamento();
            List<Departamento> listaDepartamentos = Listados.ObtenerDepartamentos();
            while (contador <= listaDepartamentos.Count-1&& !encontrado)
            {
                depto = listaDepartamentos[contador];
                if (depto.ID == id)
                {
                    encontrado = true;
                }
                contador++;
            }

            return depto;
        }
    }
}
