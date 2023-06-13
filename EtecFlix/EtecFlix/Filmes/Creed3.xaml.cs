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
    public partial class Creed3 : ContentPage
    {
        public Creed3()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.cred.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/oRrY3jEUogA?controls=0' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            sinopse.Text = "Depois de dominar os ringues, Adonis Creed tem" +
                           "prosperado com sua carreira e família. Quando um amigo" +
                           "uma longa sentença na prisão, o campeão fica ansioso" +
                           "para provar que merece sua chance. O confronto entre ex-amigos é mais do que apenas uma luta. Para acertar as contas, Adonis deve colocar seu futuro em risco para enfrentar Damian, um lutador que não tem nada a perder.";
        }
    }
}