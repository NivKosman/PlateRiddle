using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateRiddle
{
     static class Calculator
     {
          private const int NegativeNumber = -1;

          private static int MinAttemptsToFindMinFloor(int FloorsNumber)//the main function of 1.2
          {
               int sum = 1, res = 1;

               while(sum<FloorsNumber)
               {
                    sum = sum + res + 1;
                    res++;
               }

               return res;
          }

          public static int getMinAttemptsToFindMinFloor(int FloorsNumber)
          {
               if (FloorsNumber <= 0)
               {
                    if (FloorsNumber == 0)
                         return 0;
                    else
                         return NegativeNumber;
               }
               else
                    return MinAttemptsToFindMinFloor(FloorsNumber);
          }
     }
}
