

namespace JSEXAMEN.Views
{
    public partial class RegistroPage : ContentPage
    {
        string user_global="";
        public RegistroPage(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "USUARIO" + usuario;
            user_global = usuario;

        }

        private void OnCalcularPagoMensualClicked(object sender, EventArgs e)
        {
            
            if (double.TryParse(montoInicialEntry.Text, out double montoInicial) && montoInicial <= 1500)
            {
               
                double costoTotal = 1500.0;

                
                double saldoRestante = costoTotal - montoInicial;

                if (saldoRestante > 0)
                {
                    
                    double cuotaBase = saldoRestante / 4;
                    double cuotaFinal = cuotaBase + (cuotaBase * 0.04); 
                    montoCalculadoLabel.Text = cuotaFinal.ToString("F2"); 
                    pagoMensualEntry.Text = cuotaFinal.ToString("F2");
                }
                else
                {
                    DisplayAlert("Error", "El monto inicial no puede ser mayor o igual al costo total del curso.", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese un monto inicial válido (máximo 1500).", "OK");
            }
        }
        private async void OnVerResumenClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new ResumenPage(
                usuario: "Usuario", 
                nombre: "Nombre",
                apellido: "Apellido",
                edad: "Edad",
                fecha: fechaPicker.Date.ToString("d"),
                ciudad: ciudadPicker.SelectedItem?.ToString(),
                pais: paisPicker.SelectedItem?.ToString(),
                montoInicial: montoInicialEntry.Text,
                pagoMensual: "0", 
                pagoTotal: "0" 
            ));

   
        }
    }
}
