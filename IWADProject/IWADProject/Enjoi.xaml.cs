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
    public partial class Enjoi : ContentPage
    {
        public Enjoi()
        {
            InitializeComponent();
            SetUpImages();
        }

        private void SetUpImages()
        {
            // want to add an image to the imageMain object
            // to do this, need a handle to the resources
            var assembly = typeof(Enjoi);
            // retrieve image from assembly 
            string myImageName = "IWADProject.Assets.Images.enjoi.jpg";
            imageMain.Source = ImageSource.FromResource(myImageName, assembly);
        }
    }
}