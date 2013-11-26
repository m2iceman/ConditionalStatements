using System;

//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.


namespace TwoIntsExchangesValues
{
    class TwoIntsExchangesValues
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            int c = new int();

            if (a > b)
            {
                c = b;
                b = a;
                a = c;

                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
    }
}
