using System;

namespace kalp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aleyna";
            string metin = Console.ReadLine();
            Console.WriteLine("\n");
            for(int i = 0, m=1; i<30; i++)
            {
                for(int l=0; l<new[] { 5,6,7,6,8,10,3,10,4,13,1,13,1,87,1,27,4,23,
                7,20,11,16,16,11,20,7,24,3,27,1}[i]; l++, m++)
                {
                    Console.Write((i % 2 > 0 ? metin[m % metin.Length] : ' ') + (m % 29 > 0 ? "" : "\n"));
                }
            }
            Console.ReadLine();
        }
    }
}
