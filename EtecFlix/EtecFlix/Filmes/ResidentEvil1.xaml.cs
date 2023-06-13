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
    public partial class ResidentEvil1 : ContentPage
    {
        public ResidentEvil1()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlix.Img.ImgEtecFlix.png");
            poster.Source = ImageSource.FromResource("EtecFlix.Posters.ResidentEvil1.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='560' height='315' src='https://www.youtube.com/embed/HhBAIDHvRTc?controls=0' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            sinopse.Text = "Alice e Rain Ocampo têm a missão de destruir um" +
                           "laboratório genético operado pela poderosa corporação" +
                           "Umbrella, um dos maiores conglomerados do mundo, onde" +
                           "um vírus foi disseminado, matando seu criador e ressurgindo como uma criatura demoníaca, que sente uma fome incontrolável e transforma todas as suas vítimas em zumbis. O time tem apenas três horas para evitar que o vírus invada a Terra.";
        }
    }
}