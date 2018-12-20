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
    public partial class Foundation : ContentPage
    {
        public Foundation()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {

            var assembly = typeof(Foundation);
            
            string myMainImage = "IWADProject.Assets.Images.Foundation.foundation.jpg";
            imageMain.Source = ImageSource.FromResource(myMainImage, assembly);

            string firstPro = "IWADProject.Assets.Images.Foundation.colewilson.JPG";
            fpro1.Source = ImageSource.FromResource(firstPro, assembly);

            string secondPro = "IWADProject.Assets.Images.Foundation.aidancampbell.JPG";
            fpro2.Source = ImageSource.FromResource(secondPro, assembly);

            string thirdPro = "IWADProject.Assets.Images.Foundation.nickmerlino.jpg";
            fpro3.Source = ImageSource.FromResource(thirdPro, assembly);

            string fourthPro = "IWADProject.Assets.Images.Foundation.coreyglick.jpg";
            fpro4.Source = ImageSource.FromResource(fourthPro, assembly);

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var assembly = typeof(Foundation);

            if (sender.Equals(fpro1))
            {
                Navigation.PushAsync(new ColeWilson());
            }
            else if(sender.Equals(fpro2))
            {
                Navigation.PushAsync(new AidanCampbell());
            }
            else if (sender.Equals(fpro3))
            {
                Navigation.PushAsync(new NickMerlino());
            }
            else if (sender.Equals(fpro4))
            {
                Navigation.PushAsync(new CoreyGlick());
            }
        }

    }
}