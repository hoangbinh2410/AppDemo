using AppDemo.Services;
using AppDemo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDemo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Login();
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
