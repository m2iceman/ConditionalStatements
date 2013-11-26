using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subset
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            bool sumZero = false;
            for (int i = 0; i < 5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i] + array[j] == 0 && i != j)
                    {
                        sumZero = true;
                        Console.WriteLine(sumZero);
                        Console.WriteLine("{0}+{1} = 0", array[i], array[j]);
                        return;
                    }
                    for (int c = 0; c < 5; c++)
                    {
                        if (array[i] + array[j] + array[c] == 0 && i != j && i != c && j != c)
                        {
                            sumZero = true;
                            Console.WriteLine(sumZero);
                            Console.WriteLine("{0}+{1}+{2} = 0", array[i], array[j], array[c]);
                            return;
                        }
                        for (int k = 0; k < 5; k++)
                        {
                            if (array[i] + array[j] + array[c] + array[k] == 0 && i != j && i != c && i != k && j != c && j != k && c != k)
                            {
                                sumZero = true;
                                Console.WriteLine(sumZero);
                                Console.WriteLine("{0}+{1}+{2}+{3} = 0", array[i], array[j], array[c], array[k]);
                                return;
                            }
                            for (int d = 0; d < 5; d++)
                            {
                                if (array[i] + array[j] + array[c] + array[k] + array[d] == 0 && i != j && i != c && i != k && i != d && j != c && j != k && j != d && c != k && c != d && k != d)
                                {
                                    sumZero = true;
                                    Console.WriteLine(sumZero);
                                    Console.WriteLine("{0}+{1}+{2}+{3}+{4} = 0", array[i], array[j], array[c], array[k], array[d]);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}