using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StaticMemoryTester
{
    public static class MathOperations
    {


        public static decimal SumAList(List<decimal> ListToSum)
        {

            return ListToSum.Sum();
        }


        public static List<decimal> ReturnListOfNumbers(int NumberToIncreaseTo)
        {

            List<decimal> NumberedList = new List<decimal>();
            //populatebigobject
            for (int i = 0; i < NumberToIncreaseTo; i++)
            {
                NumberedList.Add(i);
            }

            return NumberedList;

        }
    }
}
