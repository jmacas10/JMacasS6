using System.Net.Mail;

namespace JMacasS6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new Vistas.VEstudiante();
            MainPage = new NavigationPage(new Vistas.VEstudiante());
        }
    }
}
