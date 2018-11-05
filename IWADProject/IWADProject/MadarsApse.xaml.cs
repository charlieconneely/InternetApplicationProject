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
	public partial class MadarsApse : ContentPage
	{
		public MadarsApse ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(MadarsApse);

            string img1 = "IWADProject.Assets.Images.Element.madarsProfile.madarsSkate1.jpg";
            madars1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Element.madarsProfile.madarsSkate2.jpg";
            madars2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Element.madarsProfile.madarsSkate3.jpg";
            madars3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Element.madarsProfile.madarsDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }

    }
}