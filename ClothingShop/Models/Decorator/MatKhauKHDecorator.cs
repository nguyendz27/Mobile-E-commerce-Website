using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Decorator
{
    public class MatKhauKHDecorator : AbstractDecorator
    {
        Customer kh1;
        public MatKhauKHDecorator(AbstractKhachHang kh, string matKhau, Customer kh1) : base(kh)
        {
            this.kh1 = kh1;
            Matkhau = matKhau;
        }
        public override Customer MakeKhachHang()
        {
            base.MakeKhachHang();
            Customer kh = kh1;
            kh.Password = Email;

            return base.MakeKhachHang();
        }
    }
}