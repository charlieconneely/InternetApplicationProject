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
	public partial class IshodWair : ContentPage
	{
		public IshodWair ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(IshodWair);

            string img1 = "IWADProject.Assets.Images.Real.ishodProfile.ishodSkate1.jpg";
            ish1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Real.ishodProfile.ishodSkate2.jpg";
            ish2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Real.ishodProfile.ishodSkate3.jpg";
            ish3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Real.ishodProfile.ishodDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }
    }
}