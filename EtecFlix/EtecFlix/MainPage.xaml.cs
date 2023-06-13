using EtecFlix.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EtecFlix.Categorias;
using System;
using Xamarin.Forms;

namespace EtecFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try 
            { 
                Navigation.PushAsync(new Aventura());
            } catch (Exception ex) 
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Comedia());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Drama());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Terror());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {

        }
    }
}
