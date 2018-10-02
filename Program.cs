using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_bib;

namespace ConsoleApp1
{
   public class Program
    {
      public static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine(calc.Count(4, 5, Calculator_bib.Action.Div));

            Console.ReadLine();

        }  
    }
}
