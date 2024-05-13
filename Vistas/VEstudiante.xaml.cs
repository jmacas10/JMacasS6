using JMacasS6.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace JMacasS6.Vistas;

public partial class VEstudiante : ContentPage
{
	private const string Url = "http://192.168.68.123/moviles/post.php";
	private readonly HttpClient cliente = new HttpClient();
	//private ObservableCollection<Estudiante> estu;
	public VEstudiante()
	{
		InitializeComponent();
		obtenerDatos();
	}
	public async void obtenerDatos() {

        var content = await cliente.GetStringAsync(Url);
        var estudiantes = JsonConvert.DeserializeObject<List<Estudiante>>(content);

        //  List<Estudiante> mostrarEst = JsonConvert.DeserializeObject<List<Estudiante>>(content);
        // estu= new ObservableCollection<Estudiante>(mostrarEst);
        //listaEstudiantes.ItemsSource = estu;

        int contador = 1;
        ///////////
        foreach (var estudiante in estudiantes)
        {
            tablaEstudiantes.Root[0].Add(new ViewCell
            {
                View = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children =
                        {
                         new Label { Text = contador.ToString(), HorizontalOptions = LayoutOptions.FillAndExpand }, // muestra el numero de registo para evitar mostrar el id
                            new Label { Text = estudiante.nombre, HorizontalOptions = LayoutOptions.FillAndExpand },
                            new Label { Text = estudiante.apellido, HorizontalOptions = LayoutOptions.FillAndExpand },
                             new Label { Text = estudiante.edad.ToString(), HorizontalOptions = LayoutOptions.FillAndExpand }// se convierte a string
                        }
                }
            });
            contador++; // incrementa el contador despues de una iteracion
        }
    }

}