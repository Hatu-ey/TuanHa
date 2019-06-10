using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TuanHa.Models;
using TuanHa.Data;

namespace TuanHa.Data
{
    public class RestService
    {
        HttpClient httpClient;

        public List<DataModel> Data { get; set; }
        public IndexModel Index { get; set; }

        public RestService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<DataModel>> RefreshDataAsync()
        {
            var uri = new Uri(string.Format(Constants.RestUrlMain, string.Empty));
            Data = new List<DataModel>();
            try
            {
                var response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Data = JsonConvert.DeserializeObject<List<DataModel>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return Data;
        }

        public async Task<IndexModel> GetIndexAsync(int idx)
        {
            string fullUri = Constants.RestUrlGetIndex + idx.ToString();             
            var uri = new Uri(string.Format(fullUri, string.Empty));
            Index = new IndexModel();
            try
            {
                var response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    Index = JsonConvert.DeserializeObject<IndexModel>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return Index;
        }
    }
}
