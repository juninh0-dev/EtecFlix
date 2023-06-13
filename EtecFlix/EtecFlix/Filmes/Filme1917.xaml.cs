using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Filme1917 : ContentPage
    {
        public Filme1917()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.Guerra1917.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/_3gy6K7LXHg?controls=0' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            sinopse.Text = "Na Primeira Guerra Mundial, dois soldados britânicos" +
                           "recebem ordens aparentemente impossíveis de cumprir." +
                           "Em uma corrida contra o tempo, eles precisam atravessar o" +
                           "território inimigo e entregar uma mensagem que pode salvar 1.600 de seus companheiros.";
        }
    }
}