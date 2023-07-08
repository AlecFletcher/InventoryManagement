using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlecFletcherInventoryProject
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


    }

    class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse()
        {

        }

        public Inhouse(int partID, string name,int instock, decimal price, int min, int max, int machineID)
        {
            this.PartID = partID;
            this.Name = name;
            this.InStock = instock;
            this.Price = price;
            this.Min = min;
            this.Max = max;
            this.MachineID = machineID;
        }

    }


    class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced()
        {
            CompanyName = string.Empty;
        }
        public Outsourced(int partID, string name,  int instock, decimal price, int min, int max, string companyName)
        {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = instock;
            this.Min = min;
            this.Max = max;
            this.CompanyName = companyName;
        }
    }
}
