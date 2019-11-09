using MHRS.Data;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MHRS.RealmDBProjectPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreatePage : ContentPage
	{
		public CreatePage ()
		{
			InitializeComponent ();
		}

        private void BtnCreate_Clicked(object sender, EventArgs e)
        {
            var realmDB = Realm.GetInstance();
            var myEmployees = realmDB.All<Employess>().ToList();
            var maxStudentId = 0;
            if(myEmployees.Count!=0)
            {
                maxStudentId = myEmployees.Max(m => m.EmployeeId) + 1;
            }
            var Employer = new Employess
            {
                EmployeeId = maxStudentId,
                EmployeeName = EmployeeName.Text,
                EmployeeSurname=EmployeeSurname.Text,
                EmployeeAge = EmployeeAge.Text,
                EmployeeCountry = EmployeeCountry.Text
            };

            realmDB.Write(() =>
            {
                realmDB.Add(Employer);

            });
            var employeeList = realmDB.All<Employess>().ToList();
            lstCreate.ItemsSource = employeeList;
        }
    }
}