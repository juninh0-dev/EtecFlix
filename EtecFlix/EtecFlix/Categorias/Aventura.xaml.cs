using EtecFlix.Filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");



            btnHomemAranhaAtravesdoMultiverso.Source = ImageSource.FromResource("EtecFlix.Posters.HomemAranhaNoAranhaVerso2.jpg");
            btnOnePieceRed.Source = ImageSource.FromResource("EtecFlix.Posters.OnePieceRed.jpg");
            Minions.Source = ImageSource.FromResource("EtecFlix.Posters.Minions.jpg");
        }

        private async void btnHomemAranhaAtravesdoMultiverso_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new HomemAranhaNoAranhaverso2());
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void btnOnePieceRed_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new OnePieceRed());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "OK");
            }
        }

        private async void Minions_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Minions());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n" , ex.Message, "OK");
            }//PAREI AQUI, FAZER ISSO COM COMEDIA, DRAMA E TERROR!
        
        }
    }
}