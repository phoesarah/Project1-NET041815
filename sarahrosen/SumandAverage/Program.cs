using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumandAverage
{
    class Program
    {
        static void Main(string[] args)
        {
           /* This is for Original program and Try 1
            
            Console.WriteLine("Enter your high number");
            Double upperbound = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            double average = 0.0;
            double count = 0;
            */




           /* this is original program 
            * 
            for (double i = 1; i <= upperbound; i++)
            {
                sum = sum + i;
                count = count + 1;
                               
            }
            average = sum / count;
            Console.WriteLine("The sum is " + Convert.ToString(sum));
            Console.WriteLine("The Average is " + Convert.ToString(average));
            Console.ReadLine();  */
            



           /* This is Try 1
            
            * double i = 1;
            while (i <= upperbound)
            {
                sum = sum + i;
                count = count + 1;
                i++;
            }

            average = sum / count;
            Console.WriteLine("The sum is " + Convert.ToString(sum));
            Console.WriteLine("The Average is " + Convert.ToString(average));
            Console.ReadLine();
            */

            /* This is Try 2
            

            double count = 111;
            double sum = 0;
            double avg = 0.0;
            while (count < 8900)
            {
                sum += count;
                count += 1;
                avg = sum / count;
               
            }

            Console.WriteLine(Convert.ToString(avg));
            
            Console.ReadLine();
              */




            /* This is try 3 */
            double avg = 0;
            double sum = 0;
            double num = 1;
            double count = 0;
            while (num < 101 )
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
                num +=1;
                count += 1;
            }
            avg = sum / count;
            Console.WriteLine(Convert.ToString(avg));
            Console.ReadLine();
        }
        
    }
}
