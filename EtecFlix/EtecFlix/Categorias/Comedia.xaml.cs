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
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");


            btnbranquelas.Source = ImageSource.FromResource("EtecFlix.Posters.branquelas.jpg");
            btnKungFusao.Source = ImageSource.FromResource("EtecFlix.Posters.KungFusao.jpg");
            btnShaolinSoccer.Source = ImageSource.FromResource("EtecFlix.Posters.ShaolinSoccer.jpg");
        }


        private async void btnbranquelas_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AsBranquelas());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void btnKungFusao_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new KungFusao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void btnShaolinSoccer_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ShaolinSoccer());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }
    }
}