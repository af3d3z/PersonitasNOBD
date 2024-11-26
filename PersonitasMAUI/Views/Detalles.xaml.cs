using PersonitasMAUI.Models;

namespace PersonitasMAUI.Views;

public partial class Detalles : ContentPage
{
	public Detalles(PersonaConNombreDepartamento personaConNombreDepartamento)
	{
		InitializeComponent();
		BindingContext = personaConNombreDepartamento;
	}
}