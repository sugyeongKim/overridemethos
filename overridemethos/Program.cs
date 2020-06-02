using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
        static int power(int input)
        {
            return input * input;
        }

        static int power(int input, int count)
        {
            int num = input;
            for (int i = 1; i < count; i++)
                num *= input;
            return num;
        }

        static int SumAll(int end)
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
                sum += i;
            return sum;
        }

        static int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
                sum += i;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(power(3));
            Console.WriteLine(power(3,4));
            Console.WriteLine(SumAll(10));
            Console.WriteLine(SumAll(2, 7));
        }
    }
}
