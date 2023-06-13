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
    public partial class KungFusao : ContentPage
    {
        public KungFusao()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.KungFusao.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/KdkTGnXqQLg?controls=0' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            sinopse.Text = "Ao tentarem enganar os residentes de Pig Sty Alley," +
                           "fingindo ser de uma gangue, o estranho Sing e seu amigo" +
                           "idiota Bones são surpreendidos pelos verdadeiros" +
                           "bandidos. Ameaçados, são defendidos por um grande mestre em artes marciais.";
        }
    }
}