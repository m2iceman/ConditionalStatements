using System;
/*Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. Use switch statement.
 */

namespace SwitchVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose:\n1- for Int Variable\n2- for Double Variable\n3- for String Variable\n... and then enter some variable.");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    int number = int.Parse(Console.ReadLine());
                    number++;
                    Console.WriteLine("{0}", number);
                    break;

                case 2:
                    double number2 = double.Parse(Console.ReadLine());
                    number2++;
                    Console.WriteLine("{0}", number2);
                    break;

                case 3:
                    string str = Console.ReadLine();
                    Console.WriteLine("{0}*", str);
                    break;

                default: Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }
}
