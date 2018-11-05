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
	public partial class CoreyGlick : ContentPage
	{
		public CoreyGlick ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(CoreyGlick);

            string corey1 = "IWADProject.Assets.Images.Foundation.coreyProfile.coreySkate1.jpg";
            coreyG1.Source = ImageSource.FromResource(corey1, assembly);

            string corey2 = "IWADProject.Assets.Images.Foundation.coreyProfile.coreySkate2.jpg";
            coreyG2.Source = ImageSource.FromResource(corey2, assembly);

            // DECKS
            string corey3 = "IWADProject.Assets.Images.Foundation.coreyProfile.coreyDeck.jpg";
            deck.Source = ImageSource.FromResource(corey3, assembly);
        }

    }
}