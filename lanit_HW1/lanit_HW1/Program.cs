namespace lanit_HW1
{
    public class Program
    {
        public static void Main()
        {
            Student student = new Student();
            Console.WriteLine("Введите информацию о студенте\nИмя:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Возраст (количество полных лет):");
            student.Age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Вместимость сумки в литрах:");
            student.StudentBag = new Bag();
            student.StudentBag.Capacity = double.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кусков пиццы взял студент?");
            student.StudentBag.PizzaPieces = byte.Parse(Console.ReadLine());
            bool fit_bag = student.StudentBag.AddPizza(student.StudentBag.PizzaPieces, student.StudentBag.Capacity);
            if (!fit_bag)
            {
                Console.WriteLine("Пицца не поместилась в сумку");
            }
            else
            {
                double remaining_capacity = student.StudentBag.Capacity - student.StudentBag.PizzaPieces;
                Console.WriteLine("Сколько бутылок пива взял студент?");
                student.StudentBag.BeerBottles = byte.Parse(Console.ReadLine());
                fit_bag = student.StudentBag.AddBeer(student.StudentBag.BeerBottles, remaining_capacity);
                if (!fit_bag)
                {
                    Console.WriteLine("Пиво не поместилось в сумку");
                }
                else
                {
                    string fullPizza =  student.CountSatiety(student);
                    string fullBeer = student.CountDrunk(student);
                    Console.WriteLine($"Студент {student.Name} купил {student.StudentBag.PizzaPieces} кусков пиццы и {student.StudentBag.BeerBottles} бутылок пива.\nПотребив все купленное, студент {student.Name} {fullPizza} и {fullBeer}.");
                }
            }
        }
    }
}

