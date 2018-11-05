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
	public partial class NyjahHuston : ContentPage
	{
		public NyjahHuston ()
		{
			InitializeComponent ();
            SetUpImages();

        }

        private void SetUpImages()
        {
            var assembly = typeof(NyjahHuston);

            string img1 = "IWADProject.Assets.Images.Element.nyjahProfile.nyjahSkate3.jpg";
            nyjahH1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Element.nyjahProfile.nyahSkate2.jpg";
            nyjahH2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Element.nyjahProfile.nyjahSkate1.jpg";
            nyjahH3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Element.nyjahProfile.nyjahDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }

    }
}