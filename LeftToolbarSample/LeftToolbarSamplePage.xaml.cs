using Xamarin.Forms;

namespace LeftToolbarSample
{
    public partial class LeftToolbarSamplePage : ContentPage
    {
        public LeftToolbarSamplePage()
        {
            InitializeComponent();
        }

        private void HandleRight_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NextPage());
        }

		private void HandleWrong_Clicked(object sender, System.EventArgs e)
		{
            Navigation.PushAsync(new NavigationPage(new NextPage()));
		}
    }
}
