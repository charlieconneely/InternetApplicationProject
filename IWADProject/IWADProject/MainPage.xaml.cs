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
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            // bool isUserEmpty, isPwdEmpty;
            //isUserEmpty = String.IsNullOrEmpty(entUsername.Text);
            //isPwdEmpty = String.IsNullOrEmpty(entPassWord.Text);

            Navigation.PushAsync(new SkateBrands());

            /*
            if(isUserEmpty || isPwdEmpty)
            {
                // message
            }
            else
            {
                // navigation
            }
            */
        }
    }
}
