using System;
using Xamarin.Forms;

namespace AppCarol
{
	public partial class AppCarolPage : ContentPage
	{
		public AppCarolPage()
		{
			InitializeComponent();
		}

		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new SignInPage(), this);
			await Navigation.PopAsync();
		}
	}
}
