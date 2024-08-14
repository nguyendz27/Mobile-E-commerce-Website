using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Facade_Pattern
{
    public class ProductFacade
    {
        ProductImage productImage;
        ProductInfo productInfo;
        public ProductFacade(string FileImage, int productID, int? categoryID, int? nsxID, string productName, string descriptionPro, decimal? PRICE, string imgPro, int? quantity)
        {
            productImage = new ProductImage(FileImage);
            productInfo = new ProductInfo(productID, categoryID, nsxID, productName, descriptionPro, PRICE, imgPro, quantity); 
        }
        public void ConstructProduct(Product product)
        {
            productImage.SetImage(product);
            productInfo.SetInfo(product);
        }
    }
}