using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresses
{
   public class BabyDressUtility
    {
        public void AddDressToCart(BabyDress dress)
        {
             Program_Class.DressesCart.Add(dress);
            

        }
        public bool RemoveDressFromCart(string brand)
        {
            foreach (var dress in Program_Class.DressesCart)
            {
                if (dress.Brand == brand)
                {
                    Program_Class.DressesCart.Remove(dress);
                    return true;
                }
                return false;
            }
            return false;
            

       }

        
    }
}
