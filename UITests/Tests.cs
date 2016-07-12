using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace OpenAttachments.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			//this.platform = platform;
			Debug.WriteLine("Tests: Constructor");
		}

		[SetUp]
		public void BeforeEachTest()
		{
			Debug.WriteLine("Tests: BeforeEachTest()");
			//app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void WelcomeTextIsDisplayed()
		{
			Debug.WriteLine("Tests: WelcomeTextIsDisplayed()");
			//AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin Forms!"));
			//app.Screenshot("Welcome screen.");

			//Assert.IsTrue(results.Any());
			Assert.IsTrue(true);
		}

		[Test]
		public void ReceivingURLFromWebBrowser()
		{
			Debug.WriteLine("Tests: ReceivingURLFromWebBrowser()");
			//AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin Forms!"));
			//app.Screenshot("Welcome screen.");

			//Assert.IsTrue(results.Any());
			Assert.IsTrue(false);
		}
	}
}

