using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Adapter_Pattern
{
    public interface ISanPhamDataProvider
    {
        List<string> LaySanPhamMoi(int soluong);
    }
}