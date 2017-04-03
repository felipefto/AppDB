using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppDB
{
	public partial class App : Application
	{
		public App ()
		{
            DependencyService.Register<ViewModels.Services.ICredentialProvider, Views.CredentialProvider>();
            DependencyService.Register<ViewModels.Services.IMessageService, Views.Services.MessageService>();

			InitializeComponent();

            MainPage = new NavigationPage(new Views.LoginPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
