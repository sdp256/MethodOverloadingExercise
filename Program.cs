using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The sum is ");
            Console.Write(Add(87, 99));
            Console.WriteLine("");
            Console.Write("The sum is ");
            Console.Write(Add(834.31m, 9087.23m));
            Console.WriteLine("");
            Add(234, 182, false);
            Add(0, 1, true);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static void Add(int x, int y, bool z)
        {
            var dollars = x + y;
            if (z == true)
            {
                Console.WriteLine($"The total is {dollars} dollar.");
            }
            if (z ==  false)
            {
                Console.WriteLine($"The total is {dollars} dollars");
            }
            
        }
    }
}
