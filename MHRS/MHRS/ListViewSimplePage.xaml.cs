using MHRS.Data;
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
	public partial class ListViewSimplePage : ContentPage
	{
        List<Users> myRealList = new List<Users>();
		public ListViewSimplePage ()
		{
			InitializeComponent ();
            //var myList = new List<String>
            //{
            //    "Anıl",
            //    "Hakkı",
            //    "İsimsiz"
            //};
            var myList = new List<Users>
            {
                new Users {userName="Anıl",userId="007",imageUrl="https://s3-eu-west-1.amazonaws.com/wbm.thumbnail/dissolve/1200/713853.jpg"},
                new Users {userName="Ahmet",userId="008",imageUrl="https://image.shutterstock.com/image-photo/portrait-happy-businessman-arms-crossed-260nw-388786822.jpg"}
            };
            myRealList = myList;
            myListView.ItemsSource = myRealList;
           
		}

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }

        private void OnDelete_Clicked(object sender, EventArgs e)
        {
            var myMenuItem = (MenuItem)sender;
            var userID = myMenuItem.CommandParameter.ToString();
            myRealList.RemoveAll(r => r.userId == userID);
            myListView.ItemsSource = null;
            myListView.ItemsSource = myRealList;

        }

        private async void MyListView_Refreshing(object sender, EventArgs e)
        {
            myListView.IsRefreshing = true;
            await Task.Delay(200);
            myListView.IsRefreshing = false;
        }
    }
}