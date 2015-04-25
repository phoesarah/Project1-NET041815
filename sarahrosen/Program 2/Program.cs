using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Your number is One");
            }
            else if (number == 2)
            {
                Console.WriteLine("Your number is Two");
            }
            else if (number == 3)
            {
                Console.WriteLine("Your number is Three");
            }
            else if (number == 4)
            {
                Console.WriteLine("Your number is Four");
            }
            else if (number == 5)
            {
                Console.WriteLine("Your number is Five");
            }
            else if (number == 6)
            {
                Console.WriteLine("Your number is Six");
            }
            else if (number == 7)
            {
                Console.WriteLine("Your number is Seven");
            }
            else if (number == 8)
            {
                Console.WriteLine("Your number is Eight");
            }
            else if (number == 9)
            {
                Console.WriteLine("Your number is Nine");
            }
            else
            {
                Console.WriteLine("Your number is Not 1-9");
            }
            switch (number)
            {
                case 1:
                    Console.WriteLine("Your number is One");
                    break;

                case 2:
                    Console.WriteLine("Your number is Two");
                    break;
                case 3:
                    Console.WriteLine("Your number is Three");
                    break;
                case 4:
                    Console.WriteLine("Your number is Four");
                    break;
                case 5:
                    Console.WriteLine("Your number is five");
                    break;
                case 6:
                    Console.WriteLine("Your number is Six");
                    break;
                case 7:
                    Console.WriteLine("Your number is seven");
                    break;
                case 8:
                    Console.WriteLine("Your number is eight");
                    break;
                case 9:
                    Console.WriteLine("Your number is nine");
                    break;
                default:
                    Console.WriteLine("Your number is Other");
                    break;
            }
            Console.ReadLine();
        }
    }
}
