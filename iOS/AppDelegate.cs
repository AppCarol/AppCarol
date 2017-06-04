using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace AppCarol.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			//Xamarin.Calabash.Start();
#endif

			//Integration with Visual Studio Mobile Center
			MobileCenter.Configure("7fa6e580-707b-4aca-8dde-9cb133150e33");

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
