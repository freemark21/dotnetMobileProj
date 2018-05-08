using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace dotnetMobileProj
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //use app resourcedict for background and font color
            BackgroundColor = (Color)Application.Current.Resources["PageBackgroundColor"];
            lblWelcome.TextColor = (Color)Application.Current.Resources["FontColor"];
        }

        //tap event handler to change text color and nav to next page
        public void WelcomeLabelTapped(object sender, EventArgs e)
        {
            lblWelcome.TextColor = Color.DarkGreen;
            Navigation.PushAsync(new PickColorPage1());
        }
    }
}
