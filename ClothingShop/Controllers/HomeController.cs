using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothingShop.Models;
using ClothingShop.Models.Proxy_Pattern;

namespace ClothingShop.Controllers
{
    public class HomeController : Controller
    {
        SanPhamManagement sanPhamManagement;
        ClothingStore1Entities db = new ClothingStore1Entities();
        public ActionResult Index()
        {
           /* sanPhamManagement = new Proxy();
            List<Product> listSP = sanPhamManagement.FilterSP_Name(sanphamX)*/
            var prod = db.Products.ToList().Take(9);
            return View(prod);
        }
      
        public ActionResult TinTuc()
        {
            return View();
        }

        public ActionResult GioiThieu()
        {
            return View();
        }
    }
}