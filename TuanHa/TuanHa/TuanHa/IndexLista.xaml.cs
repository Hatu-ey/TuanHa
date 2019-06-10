using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TuanHa.Models;

namespace TuanHa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IndexLista : ContentPage
	{
        public IndexLista(int idx)
        {
            InitializeComponent();
            ShowIndex(idx);
        }

        public async void ShowIndex(int idx)
        {
            IndexModel indexModel = await App.DManager.GetIndexAsync(idx);
            data.Text = indexModel.stCalcDate;
            indeks.Text = indexModel.stIndexLevel.indexLevelName;
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}