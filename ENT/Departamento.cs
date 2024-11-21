using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Departamento
    {
        #region atributos / propiedades
        public int ID { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Departamento() { }

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        public Departamento(int id, String nombre) { 
            this.ID = id;
            this.Nombre = nombre;
        }
        #endregion
    }
}
