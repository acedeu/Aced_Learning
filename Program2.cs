using System;

namespace ConsoleApplication1
{
    internal class Program2
    {
        public static void Main2(string[] args)
        {
            /*
             This Program
             Rounds
             A Number
             To
             A
             Whole
             */
            double myNumber = 5.7213213232132;

            int myInteger = (int)Math.Ceiling(myNumber);

            Console.WriteLine(Convert.ToString(myInteger));
        }
    }
}