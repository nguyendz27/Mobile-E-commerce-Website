using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Factory
{
    public abstract class DangNhapFactory <T>
    {
        public abstract ILogin<T> CreateLogin();
    }
}