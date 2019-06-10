using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Newtonsoft.Json;
using TuanHa.Models;
using System.Diagnostics;

namespace TuanHa
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaPage : ContentPage
	{
        public ListaPage()
        {
            InitializeComponent();
            ShowList();

        }

        protected async void ShowList()
        {
            listView.ItemsSource = await App.DManager.GetDataAsync();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var DataItem = e.SelectedItem as DataModel;
            var IndexPage = new IndexLista(DataItem.id);
            Navigation.PushAsync(IndexPage);
        }

        async void Button_Pressed(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            StackLayout ListItem = (StackLayout)btn.Parent;
            Label label = (Label)ListItem.Children[1];
            DataModel x = (DataModel)label.BindingContext;

            double.TryParse(x.gegrLat, out double lat);
            double.TryParse(x.gegrLon, out double lon);

            await Map.OpenAsync(lat, lon);
        }

        async void FindByName_Completed(object sender, EventArgs e)
        {
            int.TryParse(FindByName.Text, out int z);

            List<DataModel> DataList = await App.DManager.GetDataAsync();
            if (DataList.Exists(x => x.id == z))
            {
                var IndexPage = new IndexLista(z);
                await Navigation.PushAsync(IndexPage);
            }
        }
    }
}
