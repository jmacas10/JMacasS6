

using JMacasS6.Models;
using System.Net;
using System.Text;

namespace JMacasS6.Vistas;

public partial class vActEliminar : ContentPage
{
    private HttpClient client;

    public vActEliminar() {
        InitializeComponent();
        client = new HttpClient();
    }
    public vActEliminar( Estudiante datos)
	{
		InitializeComponent();
        txtCodigo.Text=datos.codigo.ToString();
        txtnombre.Text=datos.nombre.ToString();
        txtapellido.Text=datos.apellido.ToString();
        txtedad.Text=  datos.edad.ToString();
	}

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {
        var url = "http://192.168.1.35/moviles/post.php";
        string parametros = $"codigo={txtCodigo.Text}&nombre={txtnombre.Text}&apellido={txtapellido.Text}&edad={txtedad.Text}";

        using (var client = new WebClient())
        {

            var urlCompleta = $"{url}?{parametros}";
            byte[] parametrosBytes = Encoding.ASCII.GetBytes(parametros);
            byte[] responseBytes = client.UploadData(urlCompleta, "PUT", parametrosBytes);
            string responseData = Encoding.ASCII.GetString(responseBytes);
            // Manejar la respuesta
            Console.WriteLine(responseData);
            DisplayAlert("Alerta", "Item Actualizado Correctamente" + responseData, "OK");

        }
        Navigation.PushAsync(new VEstudiante());
    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {
        var url = "http://192.168.1.35/moviles/post.php";
        string parametros = $"codigo={txtCodigo.Text}";
        using (var client = new WebClient())
        {
            var urlCompleta = $"{url}?{parametros}";
            var respuesta = client.UploadData(urlCompleta, "DELETE", new byte[0]);

            DisplayAlert("Alerta", "Item eliminado Correctamente", "OK");

        }
        Navigation.PushAsync(new VEstudiante());

    }
}