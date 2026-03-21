using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyBanHang.Data
{
    public class HangSanXuat
    {
        public int ID { get; set; }
        public string TenHangSanXuat { get; set; }
        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}