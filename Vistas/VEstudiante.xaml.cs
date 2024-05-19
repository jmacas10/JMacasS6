using JMacasS6.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace JMacasS6.Vistas;

public partial class VEstudiante : ContentPage
{
	private const string Url = "http://192.168.1.35/moviles/post.php";
	private readonly HttpClient cliente = new HttpClient();
	private ObservableCollection<Estudiante> estu;
	public VEstudiante()
	{
		InitializeComponent();
		obtenerDatos();
	}
	public async void obtenerDatos() {

        var content = await cliente.GetStringAsync(Url);
        var estudiantes = JsonConvert.DeserializeObject<List<Estudiante>>(content);

          List<Estudiante> mostrarEst = JsonConvert.DeserializeObject<List<Estudiante>>(content);
        estu= new ObservableCollection<Estudiante>(mostrarEst);
        listEstudiantes.ItemsSource = estu;

       
    }

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vagregar());
    }

    private void listEstudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var objEstudiante = (Estudiante)e.SelectedItem;
        Navigation.PushAsync(new vActEliminar(objEstudiante));
    }
}