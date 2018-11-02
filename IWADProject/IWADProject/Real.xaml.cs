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
    public partial class Real : ContentPage
    {
        public Real()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // want to add an image to the imageMain object
            // to do this, need a handle to the resources
            var assembly = typeof(Real);
            // retrieve image from assembly 
            string myImageName = "IWADProject.Assets.Images.Real.real.jpg";
            imageMain.Source = ImageSource.FromResource(myImageName, assembly);

            string firstPro = "IWADProject.Assets.Images.Real.zionwright.jpg";
            pro1.Source = ImageSource.FromResource(firstPro, assembly);

            string secondPro = "IWADProject.Assets.Images.Real.kylewalker.jpg";
            pro2.Source = ImageSource.FromResource(secondPro, assembly);

            string thirdPro = "IWADProject.Assets.Images.Real.robbiebrockel.jpg";
            pro3.Source = ImageSource.FromResource(thirdPro, assembly);

            string fourthPro = "IWADProject.Assets.Images.Real.ishodwair.jpg";
            pro4.Source = ImageSource.FromResource(fourthPro, assembly);

        }
    }
}