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
	public partial class XamarinElementPage : ContentPage
	{
		public XamarinElementPage ()
		{
			InitializeComponent ();
		}

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            myEnrty.Text = "Merhaba Xamarin Forms!";
            myLabel.Text = "Merhaba Xamarin!";
            slider.Value = 50;
            myDatePicker.Date = new DateTime(2019, 5, 3);
            myTimePicker.Time = new TimeSpan(4, 45, 34);
            mySwitch.IsToggled  = true;
            myButton.Text = "You Pushed Me";

            var myList = new List<string>();
            myList.Add("First Item");
            myList.Add("Second Item");
            myList.Add("Third Item");
            myList.Add("Fourth Item");
            myPicker.ItemsSource = myList;

        }

        private void MyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            myEnrty.Text = myPicker.SelectedItem.ToString();
        }
    }
}