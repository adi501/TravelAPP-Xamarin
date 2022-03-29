using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {

           
            if (string.IsNullOrEmpty(entryEmail.Text)|| string.IsNullOrEmpty(entryPWD.Text))
            {

            }
            else
            {

                await Navigation.PushAsync(new HomePage());
            }
        }
    }
}
