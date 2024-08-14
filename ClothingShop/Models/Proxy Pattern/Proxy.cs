using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor.Tokenizer.Symbols;

namespace ClothingShop.Models.Proxy_Pattern
{
    public class Proxy : SanPhamManagement
    {
        SanPhamManagement sanPhamManagement;
        public override List<Product> FilterSP_Type(List<Product> listSP, int type)
        {
            if (sanPhamManagement == null)
                sanPhamManagement = new ConcreteSanPham();
            return sanPhamManagement.FilterSP_Type(listSP, type);
        }
        public override List<Product> FilterSP_Name(List<Product> listSP, string keyword)
        {
            if (sanPhamManagement == null)
                sanPhamManagement = new ConcreteSanPham();
            return sanPhamManagement.FilterSP_Name(listSP, keyword);
        }
    }
}