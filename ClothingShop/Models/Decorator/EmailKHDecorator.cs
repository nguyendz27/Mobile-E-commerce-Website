using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Decorator
{
    public class EmailKHDecorator : AbstractDecorator
    {
        Customer kh1;
        public EmailKHDecorator(AbstractKhachHang kh, string email, Customer kh1) :base (kh)
        {
            this.kh1 = kh1;
            Email = email;
        }
        public override Customer MakeKhachHang()
        {
             base.MakeKhachHang();
            Customer kh = kh1;
            kh.EmailCus = Email;

            return kh;
        }
    }
}