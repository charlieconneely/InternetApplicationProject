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
	public partial class NeenWilliams : ContentPage
	{
		public NeenWilliams ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(NeenWilliams);

            string img1 = "IWADProject.Assets.Images.Deathwish.neenProfile.neenSkate3.jpg";
            neen1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Deathwish.neenProfile.neenSkate2.jpg";
            neen2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Deathwish.neenProfile.neenSkate1.jpg";
            neen3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Deathwish.neenProfile.neenDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }

    }
}