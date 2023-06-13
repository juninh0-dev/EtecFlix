using EtecFlix.Filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.jpg");

            btnTitanic.Source = ImageSource.FromResource("EtecFlix.Posters.titanic.jpg");
            btn1917.Source = ImageSource.FromResource("EtecFlix.Posters.Guerra1917.jpg");
            btnCreed3.Source = ImageSource.FromResource("EtecFlix.Posters.cred.jpg");
        }

        private async void btnTitanic_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Titanic());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void btn1917_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filme1917());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void btnCreed3_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Creed3());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }
    }
}