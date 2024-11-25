using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonitasMAUI.Models
{
    public class PersonaConNombreDepartamento: Persona
    {
        public string NombreDepartamento { get; }

        public PersonaConNombreDepartamento() { }

        public PersonaConNombreDepartamento(Persona persona, List<Departamento> departamentos) : base(persona) {
            Departamento depto = BL.ListadosBL.GetListaDepartamentosBL().Find(dpto => dpto.ID == persona.IDDepartamento);
            if (depto != null) {
                this.NombreDepartamento = depto.Nombre;
            }
        }
    }
}
