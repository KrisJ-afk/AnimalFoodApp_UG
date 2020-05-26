using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimalFood
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainContentPage();
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
