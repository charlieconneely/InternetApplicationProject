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
	public partial class LouieBarletta : ContentPage
	{
		public LouieBarletta ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(LouieBarletta);

            string img1 = "IWADProject.Assets.Images.Enjoi.louieProfile.louieSkate1.jpg";
            lou1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Enjoi.louieProfile.louieSkate2.jpg";
            lou2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Enjoi.louieProfile.louieSkate3.jpg";
            lou3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Enjoi.louieProfile.louieDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }
    }
}