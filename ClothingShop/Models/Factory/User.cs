using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothingShop.Models.Factory
{
    public class User : Controller, ILogin<Customer>
    {
        [HttpGet]
        public bool Login(string taiKhoan)
        {
            return taiKhoan != null;
        }
        [HttpPost]
        public bool Login(Customer x, ref object taikhoan)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(x.EmailCus))
                    ModelState.AddModelError(string.Empty, "Tên đăng nhập không được trống");
                if (string.IsNullOrEmpty(x.Password))
                    ModelState.AddModelError(string.Empty, "Mật khẩu không được trống");
                if (ModelState.IsValid)
                {
                    var khach = DBDatabase.Instance.Customers.FirstOrDefault(k => k.EmailCus == x.EmailCus && k.Password == x.Password);
                    if(khach != null)
                    {
                        taikhoan = khach;
                        return true;
                    }
                    else
                    {
                        ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
                        return false;
                    }
                }
            }
            return false;
        }
    }
}