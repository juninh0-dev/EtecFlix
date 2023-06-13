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
    public partial class Titanic : ContentPage
    {
        public Titanic()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.titanic.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/IH6_CA_ocqY?controls=0' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            sinopse.Text = "Um artista pobre e uma jovem rica se conhecem e se" +
                           "apaixonam na fatídica viagem inaugural do Titanic em" +
                           "1912. Embora esteja noiva do arrogante herdeiro de uma" +
                           "siderúrgica, a jovem desafia sua família e amigos em busca do verdadeiro amor.";
        }
    }
}