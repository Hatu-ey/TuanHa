using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TuanHa.Models;

namespace TuanHa.Data
{
    public class DataManager
    {
        RestService restService;

        public DataManager(RestService _restService)
        {
            restService = _restService;
        }

        public Task<List<DataModel>> GetDataAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task<IndexModel> GetIndexAsync(int idx)
        {
            return restService.GetIndexAsync(idx);
        }
    }
}
