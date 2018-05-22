using System;
using Xamarin.Forms;

namespace AdaptiveXamarinFormsDemo
{
    public class MainPage : ContentPage
    {

        protected void LayoutDemoGrid_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutDemoGridPage());
        }

        protected void ViewInfoPage_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InfoPage());
        }

        protected void LayoutDemoFlex_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutDemoFlexPage());
        }

        protected void LayoutVsmBuiltIn_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VisualStateManagerBuiltInDemoPage());
        }

        protected void LayoutVsmOrientation_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VisualStateManagerOrientationDemoPage());
        }

        protected void TabbedPage_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedContentPage());
        }

        protected void ScrollingPage_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollingContentViewPage());
        }

        protected void GridPage_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridContentViewPage());
        }

    }
}
