using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IWADProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AidanCampbell : ContentPage
    {
        public AidanCampbell()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(AidanCampbell);

            string aidan1 = "IWADProject.Assets.Images.Foundation.aidanProfile.aidanSkate1.jpg";
            aidanC1.Source = ImageSource.FromResource(aidan1, assembly);

            string aidan2 = "IWADProject.Assets.Images.Foundation.aidanProfile.aidanSkate2.jpg";
            aidanC2.Source = ImageSource.FromResource(aidan2, assembly);

            // DECKS
            string aidan3 = "IWADProject.Assets.Images.Foundation.aidanProfile.aidanDeck.jpg";
            deck.Source = ImageSource.FromResource(aidan3, assembly);
        }
    }
}