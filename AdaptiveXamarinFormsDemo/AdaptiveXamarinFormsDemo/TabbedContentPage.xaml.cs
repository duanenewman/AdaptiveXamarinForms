﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdaptiveXamarinFormsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedContentPage : TabbedPage
    {
        public TabbedContentPage ()
        {
            InitializeComponent();
        }
    }
}