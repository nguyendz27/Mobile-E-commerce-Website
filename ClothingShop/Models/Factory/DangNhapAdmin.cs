using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Factory
{
    public class DangNhapAdmin : DangNhapFactory<admin>
    {
        public override ILogin<admin> CreateLogin()
        {
            return new Admin();
        }
    }
}