using Band.ViewModels.Catalog.LoaiVe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.ManageApp.Services
{
    interface IShowsApiClient
    {
        List<LoaiVeViewModel> GetAllLoaiVe();
    }
}
