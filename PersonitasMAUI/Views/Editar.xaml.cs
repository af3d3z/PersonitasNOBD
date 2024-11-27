using PersonitasMAUI.Models;

namespace PersonitasMAUI.Views;

public partial class Editar : ContentPage
{
	public Editar(PersonaConNombreDepartamento personaSeleccionada)
	{
		InitializeComponent();
		BindingContext = personaSeleccionada;
	}
}