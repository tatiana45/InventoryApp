using System;
using System.ComponentModel;
using System.Linq;

namespace InventoryApp
{
    public class Product : ICloneable
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public Product() {
            ProductID = util.GetUniqueId();
        }
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int id)
        {
            try
            {
                AssociatedParts.Remove(LookupAssociatedPart(id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Part LookupAssociatedPart(int id)
        {
            return AssociatedParts.SingleOrDefault(part => part.PartID == id);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}