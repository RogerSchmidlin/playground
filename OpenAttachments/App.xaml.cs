using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace OpenAttachments
{
	public partial class App : Application
	{
		VideoDetailsViewModel video = new VideoDetailsViewModel { Name = "Just a Video Name", Notes = "any notes that are important to the video", ViewCounter = 0 };
		public App()
		{
			InitializeComponent();

			MainPage = new VideoDetailsPage(video);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
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

