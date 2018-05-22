using System;
using Xamarin.Forms;

namespace AdaptiveXamarinForms
{ 
    public class AdaptiveContentPage : ContentPage
    {
        private StackOrientation _orientation;
        public StackOrientation Orientation
        {
            get { return _orientation; }
            private set
            {
                if (_orientation == value) return;
                _orientation = value;
                OrientationChanged();
                OnPropertyChanged();
            }
        }

        public virtual void OrientationChanged()
        {

        }

        public AdaptiveContentPage() : base()
        {
            SizeChanged += OnSizeChanged;
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            Orientation = Width > Height ? StackOrientation.Horizontal : StackOrientation.Vertical;
        }
    }
}
