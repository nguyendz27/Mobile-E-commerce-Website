using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Decorator
{
    public class ConcreteKhachHang : AbstractKhachHang
    {
        public ConcreteKhachHang()
        {
            HoTenKH = "";
            Email = "";
            Matkhau = "";
        }
        public override Customer MakeKhachHang()
        {
            Customer kh = new Customer();
            kh.CustomerName = HoTenKH;
            kh.EmailCus = Email;
            kh.Password = Matkhau;
            return kh;
        }
    }
}