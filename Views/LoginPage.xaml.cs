

namespace JSEXAMEN.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "estudiante", "moviles" },
            { "uisrael", "2024" }
        };

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string usuario = usuarioEntry.Text;
            string contrasena = contraseñaEntry.Text;

            if (usuarios.TryGetValue(usuario, out string contrasenaCorrecta) && contrasena == contrasenaCorrecta)
            {
                // Navegar a la ventana de registro
                await Navigation.PushAsync(new RegistroPage(usuario));
            }
            else
            {
                await DisplayAlert("Error", "Datos incorrectos", "OK");
            }
        }
    }
}



