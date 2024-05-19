
using System.Net;

namespace JMacasS6.Vistas;

public partial class Vagregar : ContentPage
{
	public Vagregar()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {

		try
		{ 
		WebClient cliente = new WebClient();
			var parametros = new System.Collections.Specialized.NameValueCollection();
			parametros.Add("nombre", txtNombre.Text);
            parametros.Add("apellido", txtApellido.Text);
            parametros.Add("edad", txtedad.Text);
			cliente.UploadValues("http://192.168.1.35/moviles/post.php", "POST", parametros);
			Navigation.PushAsync(new VEstudiante());


        }
        catch(Exception ex)
		{
			DisplayAlert("Alefrta",ex.Message,"cerrar");
		}
    }

  
}