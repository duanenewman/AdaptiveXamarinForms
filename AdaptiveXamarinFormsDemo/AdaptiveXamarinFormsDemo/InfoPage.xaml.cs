using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaptiveXamarinForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdaptiveXamarinFormsDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoPage : AdaptiveContentPage
	{
		public InfoPage ()
		{
		    BindingContext = this;
			InitializeComponent ();
	        IdiomLabel.Text = Device.Idiom.ToString();
		}

	    //protected override void OnSizeAllocated(double width, double height)
	    //{
	    //    base.OnSizeAllocated(width, height);
            
	    //    WidthLabel.Text = width.ToString();
	    //    HeightLabel.Text = height.ToString();
     //   }
	}
}