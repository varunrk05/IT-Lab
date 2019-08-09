using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOne
{
    public delegate void PriceChangedEventHandler();
    public class Item
    {
        string itemName;
        decimal itemPrice;

        public Item(string name, decimal price)
        {
            this.itemName = name;
            this.itemPrice = price;
        }

        public event PriceChangedEventHandler PriceChanged;
        public decimal ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
                if(PriceChanged != null)
                {
                    PriceChanged();
                }
            }
        }

    }

    class Program
    {
        //Item obj = new Item("Desktop stand", 999);
        public static void changeDetected()//decimal x)
        {
            //if(obj.ItemPrice != x)
                Console.WriteLine("The price has changed!\n");
        }

        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a price:");
            string x = Console.ReadLine();
            decimal xval;
            decimal.TryParse(x, out xval);*/
            //obj.Price = xval;
            Item obj = new Item("Desktop stand", 999);
            obj.PriceChanged += changeDetected;
            obj.ItemPrice = 1000;
            Console.WriteLine("The new price is: {0}", obj.ItemPrice);
            Console.Read();
        }
    }
}
