using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um valor");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numero; i++)
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            else if(i%5 == 0)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
