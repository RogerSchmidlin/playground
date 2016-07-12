using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Foundation;
using UIKit;

namespace OpenAttachments.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}

		public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			Debug.WriteLine("Received an URL: {0}:{1}", url.Scheme, url.AbsoluteString);
			return true;
		}
	}
}

