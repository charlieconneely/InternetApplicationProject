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
            string myImageName = "IWADProject.Assets.Images.deathwish.jpg";
            imageMain.Source = ImageSource.FromResource(myImageName, assembly);
        }
    }
}