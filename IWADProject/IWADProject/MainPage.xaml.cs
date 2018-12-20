using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IWADProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(MainPage);

            string img1 = "IWADProject.Assets.Images.MainPage.wallpaper.jpg";
            p1.Source = ImageSource.FromResource(img1, assembly);

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkateBrands());
        }
    }
}
