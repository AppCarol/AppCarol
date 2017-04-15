using System;
using Xamarin.Forms;

namespace AppCarol
{
	public partial class AppCarolPage : ContentPage
	{
		public AppCarolPage()
		{
			InitializeComponent();
			idLabel.Text = App.LoggedUser.Id.ToString();
			emailLabel.Text = App.LoggedUser.User.Email;
			dataLabel.Text = App.LoggedUser.BirthDate.ToString();
		}

		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new SignInPage(), this);
			await Navigation.PopAsync();
		}
	}
}
