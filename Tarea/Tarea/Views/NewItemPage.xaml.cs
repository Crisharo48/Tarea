using System;
using System.Collections.Generic;
using System.ComponentModel;
using Tarea.Models;
using Tarea.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}