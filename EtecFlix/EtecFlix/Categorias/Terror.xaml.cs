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
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");


            btnRs1.Source = ImageSource.FromResource("EtecFlix.Posters.ResidentEvil1.jpg");
            btnRs2.Source = ImageSource.FromResource("EtecFlix.Posters.ResidentEvil2.jpg");
            btnRs5.Source = ImageSource.FromResource("EtecFlix.Posters.ResidentEvil5.jpg");
        }

        private async void btnRs1_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ResidentEvil1());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void btnRs5_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ResidentEvil5());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void btnRs2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ResidentEvil2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }
    }
}