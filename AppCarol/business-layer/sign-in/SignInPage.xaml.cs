using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppCarol
{
	public partial class SignInPage : ContentPage
	{
		public SignInPage()
		{
			InitializeComponent();
		}

		public SignInPage(String message)
		{
			InitializeComponent();
			messageLabel.Text = message;
		}

		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage());
		}

		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
			var user = new User
			{
				Email = usernameEntry.Text,
				Password = passwordEntry.Text
			};

			var isValid = AreCredentialsCorrect(user);
			if (isValid)
			{
				App.IsUserLoggedIn = true;
				//App.LoggedUser = formPerson;
				Navigation.InsertPageBefore(new AppCarolPage(), this);
				await Navigation.PopAsync();
			}
			else
			{
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}
		}

		bool AreCredentialsCorrect(User user)
		{
			return user.Email == "USER" && user.Password == "123";
		}
	}
}
