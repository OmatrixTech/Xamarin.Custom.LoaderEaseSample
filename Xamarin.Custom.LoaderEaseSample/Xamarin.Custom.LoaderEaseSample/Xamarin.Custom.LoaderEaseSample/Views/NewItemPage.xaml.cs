using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Custom.LoaderEaseSample.Models;
using Xamarin.Custom.LoaderEaseSample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Custom.LoaderEaseSample.Views
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