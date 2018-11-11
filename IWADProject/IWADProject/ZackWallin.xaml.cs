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
	public partial class ZackWallin : ContentPage
	{
		public ZackWallin ()
		{
			InitializeComponent ();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(ZackWallin);

            string img1 = "IWADProject.Assets.Images.Enjoi.zackProfile.zackSkate1.jpg";
            z1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Enjoi.zackProfile.zackSkate2.jpg";
            z2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Enjoi.zackProfile.zackSkate3.jpg";
            z3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Enjoi.zackProfile.zackDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }
    }
}