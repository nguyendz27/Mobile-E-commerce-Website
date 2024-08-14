using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using System.Web.Razor.Tokenizer.Symbols;

namespace ClothingShop.Models.Proxy_Pattern
{
    public class ConcreteSanPham : SanPhamManagement
    {

        public override List<Product> FilterSP_Type(List<Product> listSP, int type)
        {
            if (type == -1)
            {
                return listSP;
            }
            else
                listSP = listSP.Where(sanpham => sanpham.CategoryID == type).ToList();
            return listSP;
        }
        public override List<Product> FilterSP_Name(List<Product> listSP, string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return listSP;
            }
            else
                listSP = listSP.Where(sanpham => sanpham.ProductName.ToLower().Contains(keyword.ToLower())).ToList();
            return listSP;
        }
    }
}