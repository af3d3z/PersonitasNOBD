using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManejadoraPersonaBL
    {
        /// <summary>
        /// Devuelve una persona a partir de su id desde la capa DAL
        /// PRE: El id debe ser mayor a 0
        /// </summary>
        /// <param name="id"></param>
        /// <param name="personas"></param>
        /// <returns></returns>
        public static Persona GetPersonaBL(int id) {
            return ManejadoraPersona.GetPersona(id);
        }

        /// <summary>
        /// Agrega una persona a la lista de la capa DAL
        /// PRE: la persona debe estar rellena
        /// </summary>
        /// <param name="persona"></param>
        public static void AgregarPersonaBL(Persona persona) { 
            ManejadoraPersona.AgregarPersona(persona);
        }

        public static bool EditarPersona(Persona persona) { 
            return ManejadoraPersona.EditarPersona(persona);
        }
    }
}
