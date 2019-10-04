using System;

namespace ArrayUppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] t = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Vänligen skriv in 1 heltal: ");
                t[i] = int.Parse(Console.ReadLine());
            }
            for(int i = t.Length-1; i >= 0; i--)
            {
                Console.WriteLine("Nr: " + t[i]);

            }
        }
    }
}
