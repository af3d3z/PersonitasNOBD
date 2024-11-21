using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ListadosBL
    {
        /// <summary>
        /// Devuelve una lista de personas de la capa DAL
        /// </summary>
        /// <returns>List<Persona></returns>
        public static List<Persona> GetListaPersonasBL() {
            return Listados.ListaPersonas;
        }

        /// <summary>
        /// Devuelve una lista de Departamentos de la capa DAL
        /// </summary>
        /// <returns>List<Departamento></returns>
        public static List<Departamento> GetListaDepartamentosBL() {
            return Listados.ListaDepartamentos;
        }

        /// <summary>
        /// Devuelve el número de personas que contiene la lista de personas en Listados
        /// </summary>
        /// <returns></returns>
        public static int GetNumeroPersonas() { 
            return Listados.ListaPersonas.Count;
        }

        /// <summary>
        /// Devuelve el número de departamentos que contiene la lista de departamentos en Listados
        /// </summary>
        /// <returns></returns>
        public static int GetNumeroDepartamentos() {
            return Listados.ListaDepartamentos.Count;
        }

    }
}
