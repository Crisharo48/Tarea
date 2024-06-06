using System.ComponentModel;
using Tarea.ViewModels;
using Xamarin.Forms;

namespace Tarea.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}