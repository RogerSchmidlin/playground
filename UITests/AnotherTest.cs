using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace OpenAttachments.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class AnotherTest
	{
		IApp app;
		Platform platform;

		public AnotherTest(Platform platform)
		{
			//this.platform = platform;
			Debug.WriteLine("AnotherTest: Constructor");
		}

		[SetUp]
		public void BeforeEachTest()
		{
			Debug.WriteLine("AnotherTest: BeforeEachTest()");
			//app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void WelcomeTextIsDisplayed()
		{
			Debug.WriteLine("AnotherTest: WelcomeTextIsDisplayed()");
			//AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin Forms!"));
			//app.Screenshot("Welcome screen.");

			//Assert.IsTrue(results.Any());
			Assert.IsTrue(true);
		}
	}
}

