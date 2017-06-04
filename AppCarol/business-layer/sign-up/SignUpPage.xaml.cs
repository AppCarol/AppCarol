using System;
using System.Linq;

using Xamarin.Forms;

namespace AppCarol
{
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage()
		{
			InitializeComponent();
		}

		public SignUpPage(String message)
		{
			InitializeComponent();
			messageLabel.Text = message;
		}

		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{

			var formPerson = new Person(emailEntry.Text, passwordEntry.Text, completeNameEntry.Text, 
			                            birthDateEntry.Date, phoneEntry.Text);


			var valid = validateForm(formPerson);

			if (valid)
			{
				try
				{
					PersonBusiness business = new PersonBusiness();

					business.addPerson(formPerson);
                    navigate(new SignInPage());
				}
				catch(BusinessException ex) 
				{
					navigate(new SignInPage(ex.Message));
				}

			}
			else
			{
				//throw view error
				messageLabel.Text = "Form isn´t valid";
			}
		}

		async void navigate(Page page) 
		{
				var rootPage = Navigation.NavigationStack.FirstOrDefault();
				if (rootPage != null)
				{

					Navigation.InsertPageBefore(page, Navigation.NavigationStack.First());
					await Navigation.PopToRootAsync();
				}
		}

		bool validateForm(Person person)
		{
			return (!string.IsNullOrWhiteSpace(person.User.Email) 
			        && !string.IsNullOrWhiteSpace(person.User.Password) 
			        && !string.IsNullOrWhiteSpace(person.CompleteName) 
			        && new DateTime() != person.BirthDate
			        && !string.IsNullOrWhiteSpace(person.Phone)
					&& person.User.Email.Contains("@"));
		}
	}
}
