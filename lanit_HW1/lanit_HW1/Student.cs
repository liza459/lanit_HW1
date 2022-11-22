using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanit_HW1
{
    public class Student
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public Bag StudentBag { get; set; }

        public string CountSatiety(Student student)
        {
            string full_pizza;
            if ((student.Age < 16 && student.StudentBag.PizzaPieces < 3) || (student.Age < 25 && student.Age >=16 && student.StudentBag.PizzaPieces < 5) || (student.Age < 55 && student.Age >= 25 && student.StudentBag.PizzaPieces < 4) || (student.Age >= 55 && student.StudentBag.PizzaPieces < 3))
            {
                full_pizza = "остался голодым";
            }
            else if ((student.Age < 16 && student.StudentBag.PizzaPieces > 5) || (student.Age < 25 && student.Age >= 16 && student.StudentBag.PizzaPieces > 8) || (student.Age < 55 && student.Age >= 25 && student.StudentBag.PizzaPieces > 7) || (student.Age >= 55 && student.StudentBag.PizzaPieces > 6))
            {
                full_pizza = "переел";
            }
            else
            {
                full_pizza = "наелся";
            }
            return full_pizza;
        }
        public string CountDrunk(Student student)
        {
            string full_beer;
            if ((student.Age < 16 && student.StudentBag.BeerBottles < 2) || (student.Age < 25 && student.Age >= 16 && student.StudentBag.BeerBottles < 4) || (student.Age < 55 && student.Age >= 25 && student.StudentBag.BeerBottles < 3) || (student.Age >= 55 && student.StudentBag.BeerBottles < 2))
            {
                full_beer = "остался трезвый";
            }
            else if ((student.Age < 16 && student.StudentBag.BeerBottles > 3) || (student.Age < 25 && student.Age >= 16 && student.StudentBag.BeerBottles > 6) || (student.Age < 55 && student.Age >= 25 && student.StudentBag.BeerBottles > 7) || (student.Age >= 55 && student.StudentBag.BeerBottles > 6))
            {
                full_beer = "перепил";
            }
            else
            {
                full_beer = "захмелел";
            }
            return full_beer;
        }
    }
}
