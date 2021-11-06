using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Band.Data.Entities
{
    public partial class Ve
    {
        public int IdVe { get; set; }

        public int IDHoaDon { get; set; }
        public HoaDon HoaDon { set; get; }
        public string MaSoVe { set; get; }
    }
}