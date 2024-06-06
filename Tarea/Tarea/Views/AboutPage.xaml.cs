using System;
using Xamarin.Forms;
using Tarea.Models;

namespace Tarea.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void OnCalcularClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Numero1Entry.Text, out double numero1) && double.TryParse(Numero2Entry.Text, out double numero2))
            {
                string operacion = OperacionPicker.SelectedItem as string;
                double resultado = 0;

                switch (operacion)
                {
                    case "Sumar":
                        resultado = numero1 + numero2;
                        break;
                    case "Restar":
                        resultado = numero1 - numero2;
                        break;
                    case "Multiplicar":
                        resultado = numero1 * numero2;
                        break;
                    case "Dividir":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            await DisplayAlert("Error", "No se puede dividir por cero", "OK");
                            return;
                        }
                        break;
                    default:
                        await DisplayAlert("Error", "Seleccione una operación válida", "OK");
                        return;
                }

                ResultadoLabel.Text = $"Resultado: {resultado}";

                var nuevaOperacion = new Operacion
                {
                    Fecha = DateTime.Now,
                    TipoOperacion = operacion,
                    Numero1 = numero1,
                    Numero2 = numero2,
                    Resultado = resultado
                };

                await App.Database.SaveOperacionAsync(nuevaOperacion);
            }
            else
            {
                await DisplayAlert("Error", "Ingrese números válidos", "OK");
            }
        }

        private async void OnHistorialClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistorialPage());
        }
    }
}
