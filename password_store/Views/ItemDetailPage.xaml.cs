using password_store.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace password_store.Views
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