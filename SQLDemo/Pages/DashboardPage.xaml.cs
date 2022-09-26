using System;
using System.Collections.Generic;
using SQLDemo.ViewModel;
using Xamarin.Forms;

namespace SQLDemo.Pages
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
            BindingContext = new DashboardPageViewModel();
        }
    }
}
