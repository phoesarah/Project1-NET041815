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
            Console.WriteLine("Enter your high number");
            Double upperbound = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            double average = 0.0;
            double count = 0;
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
            
            double i = 1;
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
        }
        
    }
}
