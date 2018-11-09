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
	public partial class JakeHayes : ContentPage
	{
		public JakeHayes ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(JakeHayes);

            string img1 = "IWADProject.Assets.Images.Deathwish.jakeProfile.jakeSkate1.jpg";
            jake1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Deathwish.jakeProfile.jakeSkate2.jpg";
            jake2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Deathwish.jakeProfile.jakeSkate3.jpg";
            jake3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Deathwish.jakeProfile.jakeDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }

    }
}