using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Facade_Pattern
{
    public class ProductInfo
    {
        public ProductInfo(int productID, int? categoryID, int? nsxID, string productName, string descriptionPro, decimal? PRICE, string imgPro, int? quantity)
        {
            ProductID = productID;
            CategoryID = categoryID;
            IDnsx = nsxID;
            ProductName = productName;
            DescriptionPro = descriptionPro;
            price = PRICE;
            ImagePro = imgPro;
            Quantity = quantity;
        }
        int ProductID { get; set; }
        int? CategoryID { get; set; }
        int? IDnsx { get; set; }
        string ProductName { get; set; }
        string DescriptionPro { get; set; }
        decimal? price { get; set; }
        string ImagePro { get; set; }
        int? Quantity { get; set; }
        public void SetInfo(Product product)
        {
            product.ProductID = ProductID;
            product.CategoryID = CategoryID;
            product.IDnsx = IDnsx;
            product.ProductName = ProductName;
            product.DecriptionPro = DescriptionPro;
            product.price = price;
            product.ImagePro = ImagePro;
            product.Quantity = Quantity;
        }
    }
}