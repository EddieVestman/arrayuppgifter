using System;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temp = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
            double sum = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                sum += temp[i];
            }
            double average = sum / temp.Length;
            Console.WriteLine(average);

        }
    }
}
