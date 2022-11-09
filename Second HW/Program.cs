using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Mega Man Petrovich";
            byte age = 25;
            string email = "megaman@gmail.com";
            double programmScore = 55;
            double mathScore = 36;
            double physicsScore = 14;
            string pattern = "Ф.И.О. {0}, \nвозраст {1}, \nпочта {2}, \nбаллы по программированию {3}, \nбаллы по математике {4}, \nбаллы по физике {5}";

            Console.WriteLine(pattern,
                fullName,
                age,
                email,
                programmScore,
                mathScore,
                physicsScore);
            Console.ReadKey();
            double total = programmScore + mathScore + physicsScore;
            Console.WriteLine(total);
            double middle = total / 3;
            Console.WriteLine(middle);
            Console.ReadKey();
        }
    }
}
