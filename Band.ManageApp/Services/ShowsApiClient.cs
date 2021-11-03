using Band.ViewModels.Catalog.LoaiVe;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Band.ManageApp.Services
{
    class ShowsApiClient : IShowsApiClient
    {
        private readonly string uri = "https://localhost:44315/api/show/";
        public List<LoaiVeViewModel> GetAllLoaiVe()
        {
            WebClient client = new WebClient();
            var response = client.DownloadString(uri + "loai-ve");
            List<LoaiVeViewModel> result = JsonConvert.DeserializeObject<List<LoaiVeViewModel>>(response);
            return result;
        }
    }
}
