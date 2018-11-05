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
	public partial class EvanSmith : ContentPage
	{
        public EvanSmith()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(EvanSmith);

            string img1 = "IWADProject.Assets.Images.Element.evanProfile.evanSkate1.jpg";
            evan1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Element.evanProfile.evanSkate2.jpg";
            evan2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Element.evanProfile.evanSkate3.jpg";
            evan3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Element.evanProfile.evanDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }
    }
}