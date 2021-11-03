using Band.ViewModels.Catalog.LoaiVe;
using Band.ViewModels.Catalog.Show;
using Band.ViewModels.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Band.ManageApp.Services
{
    class ShowApiClient : IShowApiClient
    {
        private readonly string uri = "https://localhost:44315/api/show/";

        public bool AddingImages(ImagesShowAddRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            var response = client.UploadString(uri + "adding-images", "POST", json);
            if (response == "true") return true;
            return false;
        }

        public List<ShowGetAllViewModel> GetAll()
        {
            WebClient client = new WebClient();
            var response = client.DownloadString(uri + "all");
            List<ShowGetAllViewModel> result = JsonConvert.DeserializeObject<List<ShowGetAllViewModel>>(response);
            return result;
        }

        public List<ByteArrayImageObject> GetAllImgById(int idShow)
        {
            WebClient client = new WebClient();
            client.QueryString.Add("idShow", idShow.ToString());
            var response = client.DownloadString(uri + "all-img");
            List<ByteArrayImageObject> byeImageList = JsonConvert.DeserializeObject<List<ByteArrayImageObject>>(response);
            return byeImageList;
        }

        public List<LoaiVeViewModel> GetAllLoaiVe()
        {
            WebClient client = new WebClient();
            var response = client.DownloadString(uri + "loai-ve");
            List<LoaiVeViewModel> result = JsonConvert.DeserializeObject<List<LoaiVeViewModel>>(response);
            return result;
        }
    }
}
