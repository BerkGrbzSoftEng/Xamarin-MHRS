using MHRS.NavigationPageFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MHRS
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageTest : ContentPage
	{
		public PageTest ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new MainPage()); 
            //İcerisine Sayfa Alan Method await ile bekletilmeli ve async olarak belirlenmeli
            await Navigation.PushAsync(new Page1());
        }
    }
}