using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Adapter_Pattern
{
    public class AP_HyperTech :ISanPhamDataProvider
    {
        public string HinhAnh { get; set; }
        public string ProductName { get; set; }
        public decimal? price { get; set; }

        public AP_HyperTech(string productName, decimal? PRICE, string hinhAnh)
        {
            ProductName = productName;
            price = PRICE;
            HinhAnh = hinhAnh;
        }
        public List<string> LaySanPhamMoi(int soluong)
        {
            return new List<string>()
            {
                ProductName,
                price.ToString(),
                HinhAnh
            };
        }
    }
}