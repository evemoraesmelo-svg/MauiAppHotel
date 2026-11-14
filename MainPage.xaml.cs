using MauiAppHotel.Views;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Sobre));
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ContratacaoHospedagem));
        }
    }
}