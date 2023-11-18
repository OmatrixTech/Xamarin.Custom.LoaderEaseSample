using Microsoft.Extensions.DependencyInjection;
using Xamarin.Custom.LoaderEase.Interfaces;
using Xamarin.Custom.LoaderEase;
using Xamarin.Custom.LoaderEaseSample.Services;
using Xamarin.Custom.LoaderEaseSample.ViewModels;
using Xamarin.Forms;
using System;

namespace Xamarin.Custom.LoaderEaseSample
{
    public partial class App : Application
    {
        public static IServiceProvider serviceProvider = null;
        public App()
        {
            InitializeComponent();
            //Setting up the initial configuration for a custom loader. This configuration can also be applied at the page level.
            XamrinLoaderRegisterationSetup.SetConfigurationForXamarinCustomLoader(xamarinWaitLoaderColor: Color.FromHex("#FFFFFF"), loaderTextColor: Color.White, loaderHeightRequest: 350.0, loaderWidthRequest: 350.0, loaderFontSize: 12.0);
            //Ends here
            var services = new ServiceCollection();
            services.AddSingleton<IXamarinCustomLoader, XamarinCustomLoader>();
            services.AddTransient<AboutViewModel>();
            serviceProvider = services.BuildServiceProvider();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
