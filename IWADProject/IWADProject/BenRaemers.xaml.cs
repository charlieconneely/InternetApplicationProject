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
	public partial class BenRaemers : ContentPage
	{
		public BenRaemers ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(BenRaemers);

            string img1 = "IWADProject.Assets.Images.Enjoi.benProfile.benSkate1.jpg";
            p1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Enjoi.benProfile.benSkate2.jpg";
            p2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Enjoi.benProfile.benSkate3.jpg";
            p3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Enjoi.benProfile.benDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }
    }
}