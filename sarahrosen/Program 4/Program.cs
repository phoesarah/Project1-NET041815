using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int counter = 0;
            while ( number <= 110)
            {
                            
                if (number % 3 == 0 && number % 5 ==-0)
                {
                    Console.Write(" CozaLoza ");
                    
                }
                else if (number % 3 == 0)
                {
                    Console.Write(" Coza ");

                }
                else if (number % 5 == 0)
                {
                    Console.Write(" Loza ");

                }
                else if (number % 7 == 0)
                {
                    Console.Write(" Woza ");

                }
                else 

                {
                Console.Write(" " + Convert.ToString(number));
                               
                 }

                counter = counter + 1;
                number += 1;
                if (counter % 11 == 0)
                {
                    Console.WriteLine();
                }
               
                
            }
            Console.ReadLine();
            
        }
    }
}
