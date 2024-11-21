using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ENT
{
    public class Persona
    {
        #region atributos / propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Foto { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public int IDDepartamento { get; set; }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Persona() { }

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="Apellidos"></param>
        /// <param name="Foto"></param>
        /// <param name="fechaNac"></param>
        /// <param name="idDepartamento"></param>
        public Persona(int id, string nombre, string Apellidos, string Foto, DateOnly fechaNac, int idDepartamento) {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = Apellidos;
            this.Foto = Foto;
            this.FechaNacimiento = fechaNac;
            this.IDDepartamento = idDepartamento;
        }
        public Persona(Persona p) { 
            this.Id = p.Id;
            this.Nombre = p.Nombre;
            this.Apellidos = p.Apellidos;
            this.Foto = p.Foto;
            this.FechaNacimiento = p.FechaNacimiento;
            this.IDDepartamento = p.IDDepartamento;
        }
        #endregion

    }
}
