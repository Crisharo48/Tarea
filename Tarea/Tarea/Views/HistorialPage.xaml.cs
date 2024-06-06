using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarea.Models;
using System;

namespace Tarea.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistorialPage : ContentPage
    {
        public HistorialPage()
        {
            InitializeComponent();
            LoadOperaciones();
        }

        private async void LoadOperaciones()
        {
            OperacionesListView.ItemsSource = await App.Database.GetOperacionesAsync();
        }

        private async void OnEliminarClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var operacion = button.CommandParameter as Operacion;
            await App.Database.DeleteOperacionAsync(operacion);
            LoadOperaciones();
        }
    }
}
