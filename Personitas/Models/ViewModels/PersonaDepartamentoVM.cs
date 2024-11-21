using ENT;

namespace Personitas.Models.ViewModels
{
    public class PersonaDepartamentoVM
    {
        public Persona Persona { get; set; }
        public string Departamento { get; set; }


        public PersonaDepartamentoVM(Persona p) {
            Persona = p;
            Departamento = BL.ManejadoraDepartamentoBL.GetDepartamentoBL(Persona.IDDepartamento).Nombre;
        }
    }
}
