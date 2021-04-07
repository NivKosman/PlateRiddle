using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateRiddle
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(String.Format("The minimum attempts of 100-floor building is {0}.",
                    Calculator.getMinAttemptsToFindMinFloor(100)));//1.1

               Console.WriteLine("please enter a number to find the minimum attempts.(and press after enter)");
               int inputUser = int.Parse(Console.ReadLine());

               Console.WriteLine(String.Format("The minimum attempts of {0}-floor building is {1}.",
                    inputUser,Calculator.getMinAttemptsToFindMinFloor(inputUser)));                             
          }
     }
}
