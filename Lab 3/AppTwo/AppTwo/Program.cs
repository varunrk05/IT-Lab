using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTwo
{
    class Item
    {
        string itemName;
        decimal itemCost;

        public string ItemName { get; set; }
        public decimal ItemCost
        {
            get
            {
                return itemCost;
            }

            set
            {
                if (value > 0)
                    itemCost = value;
                else
                    Console.WriteLine("Invalid cost");
            }
        }
    }

    class Program
    {
        static public decimal CalcGST(decimal x)
        {
            return (decimal)0.08 * x;
        }

        static void Main(string[] args)
        {
            Item obj = new Item();
            //obj.ItemName = "Abc";
            //obj.ItemCost = 25;
            Console.WriteLine("Enter the name and cost of the Item:");
            obj.ItemName = Console.ReadLine();
            string costVal = Console.ReadLine();
            decimal cv;
            decimal.TryParse(costVal, out cv);//out obj.ItemCost);
            obj.ItemCost = cv;

            Console.WriteLine("The GST on product is: {0}", CalcGST(obj.ItemCost));
            Console.Read();
        }
    }
}
