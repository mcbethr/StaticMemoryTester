using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StaticMemoryTester
{
    public class Sums
    {

        public Sums()
        {
        }

        public decimal SumAList(List<decimal> ListToSum)
        {
            return ListToSum.Sum();
        }

        public static decimal SumAStaticList(List<decimal> ListToSum)
        {
            return ListToSum.Sum();
        }

    }
}
