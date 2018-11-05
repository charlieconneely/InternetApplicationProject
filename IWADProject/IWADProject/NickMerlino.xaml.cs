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
	public partial class NickMerlino : ContentPage
	{
		public NickMerlino ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(NickMerlino);

            string nickm1 = "IWADProject.Assets.Images.Foundation.nickProfile.nickSkate2.jpg";
            nick1.Source = ImageSource.FromResource(nickm1, assembly);

            string nickm2 = "IWADProject.Assets.Images.Foundation.nickProfile.nickSkate1.jpg";
            nick2.Source = ImageSource.FromResource(nickm2, assembly);

            string nickm3 = "IWADProject.Assets.Images.Foundation.nickProfile.nickSkate3.jpg";
            nick3.Source = ImageSource.FromResource(nickm3, assembly);

            // DECKS
            string nickm4 = "IWADProject.Assets.Images.Foundation.nickProfile.nickdeck.jpg";
            deck.Source = ImageSource.FromResource(nickm4, assembly);
        }

    }
}