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
    public partial class Enjoi : ContentPage
    {
        public Enjoi()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(Enjoi);
            // retrieve image from assembly 
            string myImageName = "IWADProject.Assets.Images.Enjoi.enjoi.jpg";
            imageMain.Source = ImageSource.FromResource(myImageName, assembly);

            string firstPro = "IWADProject.Assets.Images.Enjoi.louiebarletta.jpg";
            pro1.Source = ImageSource.FromResource(firstPro, assembly);

            string secondPro = "IWADProject.Assets.Images.Enjoi.zachwallin.jpg";
            pro2.Source = ImageSource.FromResource(secondPro, assembly);

            string thirdPro = "IWADProject.Assets.Images.Enjoi.benraemers.jpg";
            pro3.Source = ImageSource.FromResource(thirdPro, assembly);

            string fourthPro = "IWADProject.Assets.Images.Enjoi.jacksonpilz.jpg";
            pro4.Source = ImageSource.FromResource(fourthPro, assembly);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
            if (sender.Equals(pro1))
            {
                Navigation.PushAsync(new LouieBarletta());
            }
            else if (sender.Equals(pro2))
            {
                Navigation.PushAsync(new ZackWallin());
            }
            else if (sender.Equals(pro3))
            {
                Navigation.PushAsync(new BenRaemers());
            }
            else if (sender.Equals(pro4))
            {
                Navigation.PushAsync(new JacksonPilz());
            }
        }
    }
}