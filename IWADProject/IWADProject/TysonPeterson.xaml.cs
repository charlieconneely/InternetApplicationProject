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
	public partial class TysonPeterson : ContentPage
	{
		public TysonPeterson ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(TysonPeterson);

            string img1 = "IWADProject.Assets.Images.Element.tysonProfile.tysonSkate1.jpg";
            tyson1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Element.tysonProfile.tysonSkate2.jpg";
            tyson2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Element.tysonProfile.tysonSkate3.jpg";
            tyson3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Element.tysonProfile.tysonDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }

    }
}