using System.ComponentModel;
using Xamarin.Custom.LoaderEaseSample.ViewModels;
using Xamarin.Forms;

namespace Xamarin.Custom.LoaderEaseSample.Views
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