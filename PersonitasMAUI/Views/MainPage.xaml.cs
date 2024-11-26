using PersonitasMAUI.Models.ViewModels;

namespace PersonitasMAUI.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {

            base.OnAppearing();
            /*ListaPersonasConNombreDpto vm = BindingContext as ListaPersonasConNombreDpto;
            vm.ActualizarLista();*/
        }
    }

}
