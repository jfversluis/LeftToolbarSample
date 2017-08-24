using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LeftToolbarSample
{
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
