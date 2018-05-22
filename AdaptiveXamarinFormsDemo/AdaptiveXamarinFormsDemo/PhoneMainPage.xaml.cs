using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AdaptiveXamarinFormsDemo
{
	public partial class PhoneMainPage : ContentPage
	{
		public PhoneMainPage()
		{
			InitializeComponent();
		}

	    private void LayoutDemo1_OnTapped(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new LayoutDemo1Page());
	    }

	    private void ViewInfoPage_OnTapped(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new InfoPage());
	    }
	}
}
