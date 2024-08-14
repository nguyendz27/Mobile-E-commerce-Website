using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Proxy_Pattern
{
    public abstract class SanPhamManagement
    {
        public abstract List<Product> FilterSP_Name(List<Product> listSP, string keyword);
        public abstract List<Product> FilterSP_Type(List<Product> listSP, int type);
    }
}