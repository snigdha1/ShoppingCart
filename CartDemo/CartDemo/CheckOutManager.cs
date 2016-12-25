using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CartDemo
{
    public class CheckOutManager
    {
        private static double  appleCost = 0.45;
        private static double orangeCost = 0.65;

        public double CheckOut(List<string> cartItems)
        {
            double total = 0;
            total += DiscountManager.Instance.ApplyDiscount("Apples",frequency(cartItems,"Apples"),appleCost);
            total += DiscountManager.Instance.ApplyDiscount("Oranges", frequency(cartItems, "Oranges"), orangeCost);
            return total;
        }

        private int frequency(List<string> cartItems, string type){
            var items = cartItems.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            return items.Keys.Contains(type) ?  items[type] :0;
        }

    }
}
