using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Decorator
{
    public class AbstractDecorator : AbstractKhachHang
    {
        AbstractKhachHang kh;
        public AbstractDecorator(AbstractKhachHang kh)
        {
            this.kh = kh;
        }
        public override Customer MakeKhachHang()
        {
            return kh.MakeKhachHang();
        }
    }
}