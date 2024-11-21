using BL;
using ENT;

namespace Personitas.Models.ViewModels
{
    public class PersonaListaDepartamentos
    {
        public Persona Persona { get; set; }
        public List<Departamento> Departamentos { get; set; }

        public PersonaListaDepartamentos(Persona p)
        {
            Persona = p;
            Departamentos = ListadosBL.GetListaDepartamentosBL();
        }
    }
}
