using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Adapter_Pattern
{
    public class HyperTechDatabaseAdapter :ISanPhamDataProvider
    {
        ISanPhamDataProvider _sanPhamAdapter;
        public HyperTechDatabaseAdapter(ISanPhamDataProvider sanPhamAdapter)
        {
            _sanPhamAdapter = sanPhamAdapter;
        }
        public List<string> LaySanPhamMoi(int soluong)
        {
            return _sanPhamAdapter.LaySanPhamMoi(soluong);
        }
    }
}