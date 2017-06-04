using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace AppCarol
{
	public partial class App : Application
	{


		public static Person LoggedUser { get; set;}
		public static bool IsUserLoggedIn { get; set; }

		public App()
		{
			InitializeComponent();


			DataBaseUtils db = new DataBaseUtils();

			db.DropAllTables();
			db.CreateAllTables();

			//MainPage = new AppCarolPage();
			if (!IsUserLoggedIn)
			{
				MainPage = new NavigationPage(new SignInPage());
			}
			else
			{
				MainPage = new NavigationPage(new AppCarolPage());
			}
		}

		protected override void OnStart()
		{
			// Handle when your app starts

			//Integration with Visual Studio Mobile Center
			MobileCenter.Start(typeof(Analytics), typeof(Crashes));
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
