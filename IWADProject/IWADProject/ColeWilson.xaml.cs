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
	public partial class ColeWilson : ContentPage
	{
		public ColeWilson ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(ColeWilson);

            string cole1 = "IWADProject.Assets.Images.Foundation.coleProfile.coleSkate1.jpg";
            coleW1.Source = ImageSource.FromResource(cole1, assembly);

            string cole2 = "IWADProject.Assets.Images.Foundation.coleProfile.coleSkate2.jpg";
            coleW2.Source = ImageSource.FromResource(cole2, assembly);

            string cole3 = "IWADProject.Assets.Images.Foundation.coleProfile.coleSkate3.jpg";
            coleW3.Source = ImageSource.FromResource(cole3, assembly);

            // DECKS
            string cole4 = "IWADProject.Assets.Images.Foundation.coleProfile.coleDecks.coleDeck1.jpg";
            deck.Source = ImageSource.FromResource(cole4, assembly);
        }

    }
}