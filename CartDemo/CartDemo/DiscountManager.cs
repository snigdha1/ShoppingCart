using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CartDemo
{
    public  class DiscountManager
    {
        private static DiscountManager _instance;
        public static DiscountManager Instance{
            get{
                if(_instance == null)
                    _instance = new DiscountManager();
                return _instance;
            }
        }
        public double ApplyDiscount(string name, int numberOfItems, double price)
        {
            switch (name)
            {
                case "Apples":
                    return buyOneGetOneFree(numberOfItems,price);
                    break;
                case "Oranges":
                    return buyThreeForPriceTwo(numberOfItems, price);
                    break;
                default:
                    return 0;
            }
        }

        private double buyOneGetOneFree(int numberOfItems, double price)
        {
            if(numberOfItems == 0)
                return 0;
            return (numberOfItems /2)* price + (numberOfItems %2)* price;
        }

        private double buyThreeForPriceTwo(int numberOfItems, double price)
        {
            if(numberOfItems == 0)
                return 0;
            return (numberOfItems / 3) * 2 * price + (numberOfItems % 3) * price;
        }
    }
}
