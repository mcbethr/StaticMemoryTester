using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StaticMemoryTester
{
    class Program
    {

        int number = 0;

        static void Main(string[] args)
        {
            //number = 1 + 1;     

            ///Create a list of numbers
            List<decimal> ListOfNumbers = MathOperations.ReturnListOfNumbers(100);

            //Define the stopwatch
            Stopwatch InstantiateObject = new Stopwatch();

            InstantiateObject.Start();  //start the clock
            Sums MySums = new Sums(); //Create the object
            MySums.SumAList(ListOfNumbers); ///sum the list
            InstantiateObject.Stop();  //stop

            Console.WriteLine("The Object Method took " + InstantiateObject.ElapsedMilliseconds + " Miliseconds.");


            //
            //Just reference the static method
            //

            ///Define the stopwatch
            Stopwatch StaticObject = new Stopwatch();

            StaticObject.Start(); //start the clock
            Sums.SumAStaticList(ListOfNumbers); //Sum the list
            StaticObject.Stop();

            Console.WriteLine("The Static Method took " + StaticObject.ElapsedMilliseconds + " Miliseconds.");


            //
            //Reference the Static method in the Static MathOperations Class
            //

            Stopwatch StaticObjectStaticClass = new Stopwatch();
            StaticObjectStaticClass.Start();
            MathOperations.SumAList(ListOfNumbers);
            StaticObjectStaticClass.Stop();
            Console.WriteLine("The Static Class Static Method took " + StaticObjectStaticClass.ElapsedMilliseconds + " Miliseconds.");



        }
    }



 

    public static class InterestingStaticStuff
    {
        //You can't do this
        //int number = 0;

        public static int addTwoNumbers(int one, int two)
        {
            return one + two;
        }

        public static int addTwoNumbers(string one, string two)
        {
            return Convert.ToInt32(one) + Convert.ToInt32(two);
        }

        /*
        public static virtual int addThreeNumbers(int one, int two, int three)
        {
            return one + two + three;
        }
        */

    }

    /// <summary>
    ///     
    /// You can't do this
    /// </summary>
    //public class OtherStuff : InterestingStaticStuff
    public class OtherStuff
    {

        int _number = 1;

        public static int AddOneToNumber(int Number)
        {

            ///Can't do this
            //return _number + Number;

            return Number + 1;
        }




    }
        
    

}
