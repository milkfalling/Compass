﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Compaass
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Greetings();
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
