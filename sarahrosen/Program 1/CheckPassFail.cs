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
            
            while (!string.IsNullOrEmpty(Console.ReadLine()))
          
            {
                int mark = Convert.ToInt32(Console.ReadLine());
                if (mark >= 50)
                {
                    Console.WriteLine("Pass");
                   
                }
                else
                {
                    Console.WriteLine("Fail");
                   
                 }
                
            }
        }
    }
}
