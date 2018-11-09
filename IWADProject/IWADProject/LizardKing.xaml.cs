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
	public partial class LizardKing : ContentPage
	{
		public LizardKing ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(LizardKing);

            string img1 = "IWADProject.Assets.Images.Deathwish.lizardProfile.lizardSkate1.jpg";
            liz1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Deathwish.lizardProfile.lizardSkate2.jpg";
            liz2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Deathwish.lizardProfile.lizardSkate3.jpg";
            liz3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Deathwish.lizardProfile.lizardDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }
    }
}