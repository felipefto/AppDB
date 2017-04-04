using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;
using System.Diagnostics;

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
            MobileCenter.Start("ios=f7f2bc49-9200-48b2-987c-dbc8824de14b;" +
                   "android=74f7eb3a-54f6-4d29-9c2c-0cc9eb676259",
                   typeof(Analytics), typeof(Crashes));
            // Handle when your app starts

            Analytics.Enabled = true;
            Debug.WriteLine("OnStart");
        }

		protected override void OnSleep ()
		{
            // Handle when your app sleeps
            Analytics.TrackEvent("On Sleep", new Dictionary<string, string> { { "Category", "Music" }, { "FileName", "favorite.avi" } });
            Debug.WriteLine("OnSleep");
        }

		protected override void OnResume ()
		{
            // Handle when your app resumes
            Debug.WriteLine("OnResume");
        }
	}
}
