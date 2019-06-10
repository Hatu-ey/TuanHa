using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TuanHa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Lista.Source = ImageSource.FromResource("TuanHa.PowietrzeID.jpg");
        }

        async void Lista_Pressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaPage());
        }
    }
}
