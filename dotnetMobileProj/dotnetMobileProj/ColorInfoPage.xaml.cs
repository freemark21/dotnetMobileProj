using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dotnetMobileProj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorInfoPage : ContentPage
    {
        public ColorInfoPage()
        {
            InitializeComponent();
        }

        public void PalettonButtonTapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://paletton.com/#uid=12h0u0kllllaFw0g0qFqFg0w0aF"));
        }

    }
}