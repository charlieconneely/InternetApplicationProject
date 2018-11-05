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
	public partial class MasonSilva : ContentPage
	{
		public MasonSilva ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(MasonSilva);

            string img1 = "IWADProject.Assets.Images.Element.masonProfile.masonSkate1.jpeg";
            mason1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Element.masonProfile.masonSkate2.jpg";
            mason2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Element.masonProfile.masonSkate3.jpg";
            mason3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Element.masonProfile.masonDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        } 

    }
}