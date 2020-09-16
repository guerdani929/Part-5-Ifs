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
                else if (age <= 18)
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
                Console.WriteLine("Please enter a valid input");
            }
           
            
            













            Console.ReadLine();





        }
    }
}
