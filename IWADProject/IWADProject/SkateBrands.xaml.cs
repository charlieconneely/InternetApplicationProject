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
    public partial class SkateBrands : TabbedPage
    {
        public SkateBrands()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            ToolbarItem current = (ToolbarItem)sender;
            if (current.Text == "Add")
            {
                Navigation.PushAsync(new NewItemPage());
            }
        }
    }
}