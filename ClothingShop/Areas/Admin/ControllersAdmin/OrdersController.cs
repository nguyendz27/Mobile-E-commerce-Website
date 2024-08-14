using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClothingShop.Models;
using PagedList;

namespace ClothingShop.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        private ClothingStore1Entities db = new ClothingStore1Entities();

        // GET: Admin/Orders
        public ActionResult Index(int? page)
        {
            int pageSize = 5;
            int pageNum = (page ?? 1);
            var orders = db.DonHangs.Include(o => o.Customer);
            return View(orders.ToList());
        }

        // GET: Admin/Orders/Details/5
        public ActionResult Details(int id)
        {
            var detailList = db.OrderDetails.Where(item => item.IDOrder == id).ToList();
            ViewBag.Detail = detailList;

            decimal total = 0;
            foreach (var item in detailList)
            {
                total += item.UnitPrice.GetValueOrDefault();
            }
            ViewBag.Total = total;
            var order = db.DonHangs.FirstOrDefault(item => item.IDOrder == id);
            return View(order);
        }

        public ActionResult ConfirmOrder(int id)
        {
            var order = db.DonHangs.FirstOrDefault(item => item.IDOrder == id);
            order.Status = 1;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
