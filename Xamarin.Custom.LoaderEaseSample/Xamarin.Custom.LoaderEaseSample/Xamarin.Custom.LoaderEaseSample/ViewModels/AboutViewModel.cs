using System;
using System.Windows.Input;
using Xamarin.Custom.LoaderEase.Interfaces;
using Xamarin.Custom.LoaderEase.Utility;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Xamarin.Custom.LoaderEaseSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private readonly IXamarinCustomLoader xamarinCustomLoader = null;
        public AboutViewModel(IXamarinCustomLoader xamarinCustomLoader)
        {
            Title = "About";
            RunLoaderCommand = new Command(()=>ShowLoader());
            this.xamarinCustomLoader = xamarinCustomLoader;
            ShowWaitWindow();
            CloseLoader();
        }
        private  void ShowLoader()
        {
            //To show loader with Dependency injection service method
            if (xamarinCustomLoader != null)
            {
                xamarinCustomLoader.ShowCustomLoader(message: "Processing", loaderType: LoaderType.Default);
                CloseLoader();
            }
        }
        private void ShowWaitWindow()
        {
            //Displaying the loader utilizing a method from the Dependency Injection service.
            //if (xamarinCustomLoader != null)
            //    xamarinCustomLoader.ShowCustomLoader(message: "Processing", loaderType: LoaderType.XamarinWaitLoader);

            
            //Displaying the loader without utilizing the Instance method.
            LoaderHandler.ShowCustomLoader(message: "Searching", loaderType: LoaderType.BouncingBallLoader);
        }
        private void CloseLoader()
        {
            Device.StartTimer(TimeSpan.FromSeconds(10), () =>
            {
                //Concealing the loader using a method from the Dependency Injection service.
                //if (xamarinCustomLoader != null)
                //{
                //    xamarinCustomLoader.HideCustomLoader();
                //}

                //To conceal the loader without using the Instance method.
                LoaderHandler.HideCustomLoader();
                return false;
            });
        }
        public ICommand RunLoaderCommand { get; }
    }
}