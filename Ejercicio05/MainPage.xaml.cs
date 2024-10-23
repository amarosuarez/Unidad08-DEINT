using Ejercicio05DAL;
using Ejercicio05ENT;
namespace Ejercicio05
{
    public partial class MainPage : ContentPage
    {
        public List<ClsPersona> lista;

        public MainPage()
        {
            InitializeComponent();

            lista = ClsListaPersonas.listaPersonas();

            listaView.ItemsSource = lista;
        }

    }

}
