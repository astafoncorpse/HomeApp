using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HomeApp.Pages;

namespace HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            // инициализация интерфейса
            InitializeComponent();
            // Инициализация главного экрана
            MainPage = new PaddingPage(); // new LoadingPage();  new MainPage(); new LoginPage();
                                            // new RegisterPage(); DevicesPage(); ClimatePage();new AboutPage();new GridPage();
           // new MergeGridPage();
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
