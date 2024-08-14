using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Decorator
{
    public class HoTenKHDecorator : AbstractDecorator
    {
        Customer kh1;
        public HoTenKHDecorator(AbstractKhachHang kh, string hoTen, Customer kh1) : base(kh)
        {
            this.kh1 = kh1;
            HoTenKH = hoTen;
        }
        public override Customer MakeKhachHang()
        {
            base.MakeKhachHang();
            Customer kh = kh1;
            kh.CustomerName = Email;

            return kh;
        }
    }
}