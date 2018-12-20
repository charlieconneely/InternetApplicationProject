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
    public partial class Element : ContentPage
    {
        public Element()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            var assembly = typeof(Element);
            
            string myImageName = "IWADProject.Assets.Images.Element.element.jpg";
            imageMain.Source = ImageSource.FromResource(myImageName, assembly);

            string firstPro = "IWADProject.Assets.Images.Element.nyjahhuston.jpg";
            pro1.Source = ImageSource.FromResource(firstPro, assembly);

            string secondPro = "IWADProject.Assets.Images.Element.evansmith.jpg";
            pro2.Source = ImageSource.FromResource(secondPro, assembly);

            string thirdPro = "IWADProject.Assets.Images.Element.tysonpeterson.jpg";
            pro3.Source = ImageSource.FromResource(thirdPro, assembly);

            string fourthPro = "IWADProject.Assets.Images.Element.masonsilva.jpg";
            pro4.Source = ImageSource.FromResource(fourthPro, assembly);

            string fifthPro = "IWADProject.Assets.Images.Element.madarsapse.jpg";
            pro5.Source = ImageSource.FromResource(fifthPro, assembly);

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var assembly = typeof(Element);

            if (sender.Equals(pro1))
            {
                Navigation.PushAsync(new NyjahHuston());
            }
            else if (sender.Equals(pro2))
            {
                Navigation.PushAsync(new EvanSmith());
            }
            else if (sender.Equals(pro3))
            {
                Navigation.PushAsync(new TysonPeterson());
            }
            else if (sender.Equals(pro4))
            {
                Navigation.PushAsync(new MasonSilva());
            }
            else if (sender.Equals(pro5))
            {
                Navigation.PushAsync(new MadarsApse());
            }
        }
    }
}