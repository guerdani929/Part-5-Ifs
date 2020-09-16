using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_Ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int age;
            string inp;
            int cat;

            Console.Write("Please enter your age: ");
            input = Console.ReadLine();



            if (int.TryParse(input, out age))
            {
                Console.WriteLine($"You are {age} correct?");
                Console.ReadLine();

                if (age > 18)
                {
                    Console.WriteLine("You're an adult");
                }
                else if (age > 12)
                {
                    Console.WriteLine("You're a teen");
                }
                else if (age <= 5) 
                {
                    Console.WriteLine("You're a toddler");
                }
                else if (age <= 10) 
                {
                    Console.WriteLine("You're a child");
                }
                else if (age <= 12)
                {
                    Console.WriteLine("You're a preteen");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input Press Enter to Close");
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.Write("Enter 1,2,3,4 or 5 for a Category hurricane: ");
            inp = Console.ReadLine();
            int.TryParse(inp, out cat);


            switch (cat)
            {
                case 1:
                    Console.WriteLine("It's a Category 1 Hurricane!");
                    Console.WriteLine("It's going 84 mph/72.9 kts/135 kmph");
                    break;
                case 2:
                    Console.WriteLine("It's a Category 2 Hurricane!");
                    Console.WriteLine("It's going 98 mph/85 kts/157.7 kmph");
                    break;
                case 3:
                    Console.WriteLine("It's a Catehory 3 Hurricane!");
                    Console.WriteLine("It's going 123 mph/106.8 kts/197.9 kmph");
                    break;
                case 4:
                    Console.WriteLine("It's a Category 4 Hurricane!");
                    Console.WriteLine("It's going 154 mph/133.8 kts/247.8 kmph");
                    break;
                case 5:
                    Console.WriteLine("It's a Category 5 Hurricane!");
                    Console.WriteLine("It's going 437 mph/379.7 kts/702.2 kmph");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");








            Console.ReadLine();





        }
    }
}
