using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dresses
{
    public  class BabyDress
    {
        public int Size {  get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Price {  get; set; }
        

         public BabyDress(int Size,string Color,string Brand,double Price)
        {
            this.Size = Size;
            this.Color = Color;
            this.Brand = Brand;
            this.Price = Price;

            
        }

        
    }
    

}
