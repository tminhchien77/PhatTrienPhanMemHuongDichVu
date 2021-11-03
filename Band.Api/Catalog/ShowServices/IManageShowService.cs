using Band.ViewModels.Catalog.Show;
using Band.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Band.Api.Catalog.ShowServices
{
    public interface IManageShowService
    {
        Task<int> Create(ShowCreateRequest request);
        Task<List<ShowGetAllViewModel>> GetAll();
        Task<NewListOfByteArrayImage> GetAllImgById(int idShow);
        Task<int> AddingImages(ImagesShowAddRequest request);
    }
}
