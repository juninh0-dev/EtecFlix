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
    public partial class ResidentEvil2 : ContentPage
    {
        public ResidentEvil2()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.ResidentEvil2.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/nzF3yoF7N_E?controls=0' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            sinopse.Text = "A heroína Alice tenta livrar Raccoon City de um segundo" +
                           "ataque de zumbis, mas a diabólica Umbrella Corporation e" +
                           "os militares têm uma nova arma secreta. Os sobreviventes " +
                           "Jill Valentine, Carlos Oliviera e Nicholai lutam ao lado de Alice contra um novo e melhorado Matt Addison de codinome Nemesis.";
        }
    }
}