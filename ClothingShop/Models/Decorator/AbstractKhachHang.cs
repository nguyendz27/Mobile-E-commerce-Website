using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Decorator
{
    public abstract class AbstractKhachHang
    {
        public int MaTK { get; set; }
        public string HoTenKH { get; set; }
        public string Email { get; set; }
        public string Matkhau { get; set; }

        public abstract Customer MakeKhachHang();
    }
}