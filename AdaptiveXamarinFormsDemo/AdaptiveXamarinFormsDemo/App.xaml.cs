using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AdaptiveXamarinFormsDemo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

		    MainPage = new NavigationPage(GetIdiomMainPage());
		}

        public Page GetIdiomMainPage()
        {
            switch (Device.Idiom)
            {
                case TargetIdiom.Desktop:
                    return new PhoneMainPage();
                case TargetIdiom.Tablet:
                    return new PhoneMainPage();
                default: //TargetIdiom.Phone/Tv/Etc
                    return new PhoneMainPage();
            }
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
