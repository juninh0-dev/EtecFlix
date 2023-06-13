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
    public partial class ResidentEvil5 : ContentPage
    {
        public ResidentEvil5()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.ResidentEvil5.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/abCoRJHSr7s?controls=0' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            sinopse.Text = "Alice acorda misteriosamente em outra realidade, como se" +
                           "nada tivesse acontecido, mas as sequelas do vírus logo" +
                           "aparecem na forma de zumbis, e ela descobre fazer parte" +
                           "de um novo experimento. Nas instalações da Umbrella, Alice descobre que um antigo inimigo pode ser o segredo para salvar não só ela, mas também seus antigos companheiros de luta. Só existe um problema: Jill Valentine e Rain Ocampo, sob as ordens da poderosa Rainha Vermelha, não estão dispostas a facilitar as coisas para o grupo.";
        }
    }
}