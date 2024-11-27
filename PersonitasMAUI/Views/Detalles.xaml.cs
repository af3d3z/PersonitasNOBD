using PersonitasMAUI.Models;

namespace PersonitasMAUI.Views;

public partial class Detalles : ContentPage
{
	public Detalles(int idPersona)
	{
		InitializeComponent();
		BindingContext = new PersonaConNombreDepartamento(BL.ManejadoraPersonaBL.GetPersonaBL(idPersona));
	}
}