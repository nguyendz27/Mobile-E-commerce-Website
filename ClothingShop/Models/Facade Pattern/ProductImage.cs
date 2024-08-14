using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingShop.Models.Facade_Pattern
{
    public class ProductImage
    {
        string FileImage;
        public ProductImage(string FileImage)
        {
            this.FileImage = FileImage; 
        }
        public void SetImage(Product product)
        {
            product.ImagePro = FileImage;
        }
    }
}