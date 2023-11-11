using Microsoft.Extensions.DependencyInjection;
using Xamarin.Custom.LoaderEase.Interfaces;
using Xamarin.Custom.LoaderEase;
using Xamarin.Custom.LoaderEaseSample.Services;
using Xamarin.Custom.LoaderEaseSample.ViewModels;
using Xamarin.Forms;



namespace Xamarin.Custom.LoaderEaseSample
{
    public partial class App : Application
    {
        public static ServiceProvider serviceProvider = null;
        public App()
        {
            InitializeComponent();
            XamrinLoaderRegisterationSetup.SetConfigurationForXamarinCustomLoader(xamarinWaitLoaderColor: Color.FromHex("#ff5349"), loaderTextColor: Color.OrangeRed, loaderHeightRequest: 200.0, loaderWidthRequest: 200.0, loaderFontSize: 15.0);
            var services = new ServiceCollection();
            services.AddSingleton<IXamarinCustomLoader, XamarinCustomLoader>();
            services.AddTransient<AboutViewModel>();
            serviceProvider = services.BuildServiceProvider();
            DependencyService.Register<MockDataStore>();
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
