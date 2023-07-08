using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlecFletcherInventoryProject
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, int instock, decimal price, int min, int max)
        {
            this.ProductID = id;
            this.Name = name;
            this.Price = price;
            this.InStock = instock;
            this.Min = min;
            this.Max = max;
        }

        //Adds passed part to current instance's AssociatedParts
        public void addAssociatedPart(Part part)
        {
            this.AssociatedParts.Add(part);
        }

        //Removes associated part from current instance's associated parts
        public bool removeAssociatedPart(int id)
        {
            foreach (Part part in this.AssociatedParts)
            {
                if(part.PartID == id)
                {
                    this.AssociatedParts.Remove(part);
                }
            }
            return false;

        }

        //Returns part based on passed id
        Part lookupAssociatedPart(int id)
        {
            foreach(Part part in this.AssociatedParts)
            {
                if (part.PartID == id)
                {
                    return part;
                }
            }
            return this.AssociatedParts[-1];
        }
    }
}
