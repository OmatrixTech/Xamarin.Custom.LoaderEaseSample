using System;
using System.Windows.Input;
using Xamarin.Custom.LoaderEase.Interfaces;
using Xamarin.Custom.LoaderEase.Utility;
using Xamarin.Forms;

namespace Xamarin.Custom.LoaderEaseSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private readonly IXamarinCustomLoader xamarinCustomLoader = null;
        public AboutViewModel(IXamarinCustomLoader xamarinCustomLoader)
        {
            Title = "About";
            OpenWebCommand = new Command(()=>ShowLoader());
            this.xamarinCustomLoader = xamarinCustomLoader;
            ShowWaitWindow();
            CloseLoader();
        }
        private  void ShowLoader()
        {
            if (xamarinCustomLoader != null)
            {
                xamarinCustomLoader.ShowCustomLoader(message: "Processing", loaderType: LoaderType.VividVortexSpinnerLoader);
                CloseLoader();
            }
        }
        private void ShowWaitWindow()
        {
            if (xamarinCustomLoader != null)
                xamarinCustomLoader.ShowCustomLoader(message: "Processing", loaderType: LoaderType.XamarinWaitLoader);

            //LoaderHandler.ShowCustomLoader(message: "Searching", loaderType: LoaderType.TurboTransitLoader);
        }
        private void CloseLoader()
        {
            Device.StartTimer(TimeSpan.FromSeconds(10), () =>
            {
                if (xamarinCustomLoader != null)
                {
                    xamarinCustomLoader.HideCustomLoader();
                }

                //LoaderHandler.HideCustomLoader();
                return false;
            });
        }
        public ICommand OpenWebCommand { get; }
    }
}