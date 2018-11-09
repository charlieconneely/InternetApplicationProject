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
	public partial class RobbieBrockel : ContentPage
	{
		public RobbieBrockel ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(RobbieBrockel);

            string img1 = "IWADProject.Assets.Images.Real.robbieProfile.robbieSkate1.jpg";
            rob1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Real.robbieProfile.robbieSkate2.jpg";
            rob2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Real.robbieProfile.robbieSkate3.jpg";
            rob3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Real.robbieProfile.robbieDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }

    }
}