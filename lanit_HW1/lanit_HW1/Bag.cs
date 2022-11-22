using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanit_HW1
{
    public class Bag
    {
        public byte PizzaPieces { get; set; }
        public byte BeerBottles { get; set; }
        public double Capacity { get; set; }
        public bool AddPizza(byte pizzaPieces, double capacity)
        {
            bool fit = (pizzaPieces * 0.3) < capacity;
            return fit;
        }
        public bool AddBeer(byte beerBottles, double capacity)
        {
            bool fit = (beerBottles * 0.5) < capacity;
            return fit;
        }

    }
}
