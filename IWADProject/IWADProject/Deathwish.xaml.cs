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
    public partial class Deathwish : ContentPage
    {
        public Deathwish()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // want to add an image to the imageMain object
            // to do this, need a handle to the resources
            var assembly = typeof(Deathwish);
            // retrieve image from assembly 
            string myImageName = "IWADProject.Assets.Images.Deathwish.deathwish.jpg";
            imageMain.Source = ImageSource.FromResource(myImageName, assembly);

            string firstPro = "IWADProject.Assets.Images.Deathwish.jamiefoy.jpg";
            pro1.Source = ImageSource.FromResource(firstPro, assembly);

            string secondPro = "IWADProject.Assets.Images.Deathwish.lizardking.jpg";
            pro2.Source = ImageSource.FromResource(secondPro, assembly);

            string thirdPro = "IWADProject.Assets.Images.Deathwish.neenwilliams.jpg";
            pro3.Source = ImageSource.FromResource(thirdPro, assembly);

            string fourthPro = "IWADProject.Assets.Images.Deathwish.jakehayes.jpg";
            pro4.Source = ImageSource.FromResource(fourthPro, assembly);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var assembly = typeof(Deathwish);

            if (sender.Equals(pro1))
            {
                Navigation.PushAsync(new JamieFoy());
            }
            else if (sender.Equals(pro2))
            {
                Navigation.PushAsync(new LizardKing());
            }
            else if (sender.Equals(pro3))
            {
                Navigation.PushAsync(new NeenWilliams());
            }
            else if (sender.Equals(pro4))
            {
                Navigation.PushAsync(new JakeHayes());
            }
        }
    }
}