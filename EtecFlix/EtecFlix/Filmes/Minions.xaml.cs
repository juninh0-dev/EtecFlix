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
    public partial class Minions : ContentPage
    {
        public Minions()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.Minions.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/ly-GueGW3_s?controls=0' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            sinopse.Text = "Seres amarelos milenares, os minions têm uma missão:" +
                           "servir aos maiores vilões. Em depressão desde a morte de"+
                           "seu antigo mestre, eles tentam encontrar um novo chefe."+
                           "Três voluntários, Kevin, Stuart e Bob vão até uma"+
                           "convenção de vilões nos Estados Unidos e lá se encantam"+
                           "com Scarlet Overkill, que ambiciona ser a primeira mulher"+
                           "a dominar o mundo.";
        }
    }
}