
namespace JSEXAMEN.Views
{
    public partial class ResumenPage : ContentPage
    {
        public ResumenPage(string usuario, string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string montoInicial, string pagoMensual, string pagoTotal)
        {
            InitializeComponent();
            usuarioConectadoLabel.Text = $"Usuario conectado: {usuario}";
            nombreLabel.Text = nombre;
            apellidoLabel.Text = apellido;
            edadLabel.Text = edad;
            fechaLabel.Text = fecha;
            ciudadLabel.Text = ciudad;
            paisLabel.Text = pais;
            montoInicialLabel.Text = montoInicial;
            pagoMensualLabel.Text = pagoMensual;
            pagoTotalLabel.Text = pagoTotal;
        }
    }
}
