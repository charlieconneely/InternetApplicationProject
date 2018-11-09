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
	public partial class ZionWright : ContentPage
	{
		public ZionWright ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(ZionWright);

            string img1 = "IWADProject.Assets.Images.Real.zionProfile.zionSkate1.jpg";
            z1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Real.zionProfile.zionSkate2.jpg";
            z2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Real.zionProfile.zionSkate3.jpg";
            z3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Real.zionProfile.zionDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }
    }
}