using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace GacxepBookstore.Models
{
    public class CartItem
    {
        DBGacXepEntities db = new DBGacXepEntities();
        public int ProductID { get; set; }
        public string NamePro { get; set; }
        public string ImagesPro { get; set; }
        public decimal Price { get; set; }
        public int QUantity {  get; set; }

        public decimal FinalPrice()
        {
            return QUantity * Price; 
        }

        public CartItem(int ProductID)
        {
            this.ProductID = ProductID;
            var productDB = db.Products.Single(s => s.ProductID == this.ProductID);
            this.NamePro = productDB.NamePro;
            this.ImagesPro = productDB.ImagePro;
            this.Price = (decimal)productDB.Price;
            this.QUantity = 1;
        }
    }
}