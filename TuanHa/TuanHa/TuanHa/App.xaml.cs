using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TuanHa.Data;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TuanHa
{
    public partial class App : Application
    {
        public static DataManager DManager { get; private set; }
        public App()
        {
            
            DManager = new DataManager(new RestService());
            MainPage = new NavigationPage(new MainPage());
            InitializeComponent();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
