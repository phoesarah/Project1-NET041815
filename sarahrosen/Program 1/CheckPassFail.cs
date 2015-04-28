using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CheckPassFail
    {

        
        static void Main(string[] args)
        {
            
           Console.WriteLine("Enter a grade");
           int mark = Convert.ToInt32(Console.ReadLine());
           while (!string.IsNullOrEmpty(mark.ToString()))
          
            {                
                if (mark >= 50)
                {
                    Console.WriteLine("Pass");
                    Console.WriteLine("Enter a grade");
                    Console.ReadLine();
                 }
                else
                {
                    Console.WriteLine("Fail");
                    Console.WriteLine("Enter a grade");
                    Console.ReadLine();
                }
                
                
            }
        }
    }
}
