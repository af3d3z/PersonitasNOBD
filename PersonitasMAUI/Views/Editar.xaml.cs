using ENT;
using PersonitasMAUI.Models;
using PersonitasMAUI.Models.ViewModels;

namespace PersonitasMAUI.Views {
    public partial class Editar : ContentPage
    {
        public Editar(Persona personaSeleccionada)
        {
            InitializeComponent();
            EditarVM vm = new EditarVM(personaSeleccionada);
            BindingContext = vm;
        }
    }
}