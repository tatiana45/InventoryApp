using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int id)
        {
            try
            {
                Products.Remove(LookupProduct(id));
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public static Product LookupProduct(int id)
        {
            return Products.SingleOrDefault(product => product.ProductID == id);
        }

        public static void UpdateProduct(int id, Product product)
        {
            try
            {
                var originalProduct = LookupProduct(id);
                var productIndex = Products.IndexOf(originalProduct);
                Products[productIndex] = product;
            } catch (Exception)
            {
                
            }
        }

        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            try
            {
                Parts.Remove(LookupPart(part.PartID));
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public static Part LookupPart(int id)
        {
            return Parts.SingleOrDefault(part => part.PartID == id);
        }

        public static void UpdatePart(int id, Part part)
        {
            try
            {
                var originalPart = LookupPart(id);
                var partIndex = Parts.IndexOf(originalPart);
                Parts[partIndex] = part;
            } catch (Exception)
            {

            }
        }
    }
}
