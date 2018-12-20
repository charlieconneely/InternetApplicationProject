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
            var assembly = typeof(Real);

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

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var assembly = typeof(Real);

            if (sender.Equals(pro1))
            {
                Navigation.PushAsync(new ZionWright());
            }
            else if (sender.Equals(pro2))
            {
                Navigation.PushAsync(new KyleWalker());
            }
            else if (sender.Equals(pro3))
            {
                Navigation.PushAsync(new RobbieBrockel());
            }
            else if (sender.Equals(pro4))
            {
                Navigation.PushAsync(new IshodWair());
            }
        }

    }
}