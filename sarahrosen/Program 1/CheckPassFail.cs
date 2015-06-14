using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CheckPassFail
    {
        //Write a program called CheckPassFail which prints "PASS" if the
        //int variable mark is more than or equal to 50; or prints "FAIL" otherwise.
        
        static void Main(string[] args)
        {
            
            bool quit = false;
            while(!quit)
            {
             Console.WriteLine("Please enter a grade");
             string mark = Console.ReadLine();
             Console.WriteLine(Calculate(mark));
            }

           
         }

        private static string Calculate(string input)
        {
            try
            {
                int mark = Convert.ToInt32(input);
                if (mark >=50)
                {
                    return "PASS";
                }
                else 
                {
                    return "FAIL";
                }
                
            }
            catch(FormatException e)
            {
                return ("I'm sorry, that input is unrecognized, please enter a number");
               
            }
        }


    }
}
