﻿using System;
using SQLDemo.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DashboardPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
