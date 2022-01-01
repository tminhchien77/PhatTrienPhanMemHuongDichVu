using Band.ViewModels.Catalog.LoaiVe;
using Band.ViewModels.Catalog.Show;
using Band.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Band.ManageApp.Services
{
    interface IShowApiClient
    {
        List<LoaiVeViewModel> GetAllLoaiVe();
        List<ShowGetAllViewModel> GetAll();
        List<ByteArrayImageObject> GetAllImgById(int idShow);
        bool AddingImages(ImagesShowAddRequest request);
        bool Create(ShowCreateRequest request);
        ShowViewModel GetById(int idShow);
        bool UpdateShowInfor(ShowInfoUpdateRequest request);
        bool UpdateTicketInfor(TicketInfoUpdateRequest request);
        bool Delete(int idShow);
    }
}
