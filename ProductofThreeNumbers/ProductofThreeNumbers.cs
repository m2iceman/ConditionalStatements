using System;
//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

namespace ProductofThreeNumbers
{
    class ProductofThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool aCheckSign = a > 0;
            bool bCheckSign = b > 0;
            bool cCheckSign = c > 0;

            if (aCheckSign ^ bCheckSign ^ cCheckSign)
            {
                Console.WriteLine("The sign will be \"+\"");
            }
            else
            {
                Console.WriteLine("The sign will be \"-\"");
            }
        }
    }
}
