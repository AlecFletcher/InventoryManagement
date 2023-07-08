using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlecFletcherInventoryProject
{

    static class Inventory
    {
        public static BindingList<Product> Products = new();
        public static BindingList<Part> AllParts = new();

        
        //Adds Product to Products
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        //Removes product from Products
        public static bool removeProduct(int id)
        {
            for (int i = 0; i < Products.Count(); i++)
            {
                if (Products[i].ProductID == id)
                {
                    Product prod = Products[i];
                    if(prod.AssociatedParts.Count == 0)
                    {
                        Products.Remove(prod);
                        return true;
                    }
                }
            }
            MessageBox.Show("Cannot delete a product that has associated parts.");
            return false;
        }

        //Returns searched product
        static Product lookupProduct(int id)
        {
            for (int i = 0; i < Products.Count(); i++)
            {
                if (Products[i].ProductID == id)
                {
                    return Products[i];
                }
            }
            return Products[0];
        }

        //Replaces product at Products index of passed id with passed newProduct
        public static void updateProduct(int id, Product newProduct)
        {
            int index;
            for (int i = 0; i < Products.Count(); i++)
            {
                if (Products[i].ProductID == id)
                {
                    index = i;
                    Products[index] = newProduct;
                }
            }
        }

        //Adds part to AllParts
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        //Deletes part from AllParts
        public static bool deletePart(Part part)
        {
            AllParts.Remove(part);
            return true;
        }

        //Returns part with given id
        public static Part lookupPart(int id)
        {
            for (int i = 0; i < AllParts.Count(); i++)
            {
                if (AllParts[i].PartID == id)
                {
                    return AllParts[i];
                }
            }
            return AllParts[0];
        }

        //Replaces part at given id with given part. If type is swapped between inhouse and 
        //outsourced, first deletes the original part and adds the new inherited class part
        public static void updatePart(int id, Part part)
        {
            int index;
            for (int i = 0; i < AllParts.Count(); i++)
            {
                if (AllParts[i].PartID == id)
                {
                    index = i;

                    if (part.GetType() == typeof(Inhouse))
                    {
                        Inhouse newPart = (Inhouse)part;

                        AllParts[index] = newPart;
                    }
                    else if (part.GetType() == typeof(Outsourced))
                    {
                        Outsourced newPart = (Outsourced)part;

                        AllParts[index] = newPart;
                    }
                }
            }
        }
    }
}
