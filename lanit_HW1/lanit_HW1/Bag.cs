using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanit_HW1
{
    public class Bag
    {
        int PizzaPieces { get; set; }
        int BeerBottles { get; set; }
        double Capacity { get; set; }
        public bool AddPizza(int pizzaPieces, double capacity)
        {
            bool fit = (pizzaPieces * 0.3) < capacity;
            return fit;
        }
        public bool AddBeer(int beerBottles, double capacity)
        {
            bool fit = (beerBottles * 0.5) < capacity;
            return fit;
        }

    }
}
