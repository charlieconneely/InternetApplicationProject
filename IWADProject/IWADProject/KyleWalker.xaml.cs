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
	public partial class KyleWalker : ContentPage
	{
		public KyleWalker ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(KyleWalker);

            string img1 = "IWADProject.Assets.Images.Real.kyleProfile.kyleSkate1.jpg";
            ky1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Real.kyleProfile.kyleSkate2.jpg";
            ky2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Real.kyleProfile.kyleSkate3.jpg";
            ky3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Real.kyleProfile.kyleDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }
    }
}