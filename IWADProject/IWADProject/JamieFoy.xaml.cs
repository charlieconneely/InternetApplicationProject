﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IWADProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class JamieFoy : ContentPage
	{
		public JamieFoy ()
		{
			InitializeComponent ();
            SetUpImages();
		}

        private void SetUpImages()
        {
            var assembly = typeof(JamieFoy);

            string img1 = "IWADProject.Assets.Images.Deathwish.jamieProfile.jamieSkate1.jpg";
            jamie1.Source = ImageSource.FromResource(img1, assembly);

            string img2 = "IWADProject.Assets.Images.Deathwish.jamieProfile.jamieSkate2.jpg";
            jamie2.Source = ImageSource.FromResource(img2, assembly);

            string img3 = "IWADProject.Assets.Images.Deathwish.jamieProfile.jamieSkate3.jpg";
            jamie3.Source = ImageSource.FromResource(img3, assembly);

            // DECKS
            string img4 = "IWADProject.Assets.Images.Deathwish.jamieProfile.jamieDeck.jpg";
            deck.Source = ImageSource.FromResource(img4, assembly);
        }
    }
}