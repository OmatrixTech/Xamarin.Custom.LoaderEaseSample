using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Custom.LoaderEase.Utility;
using Xamarin.Custom.LoaderEaseSample.ViewModels;
using Xamarin.Forms;

namespace Xamarin.Custom.LoaderEaseSample.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = App.serviceProvider.GetRequiredService<AboutViewModel>();
        }
        
    }
}