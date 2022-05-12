using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            Console.Write("Número de dados a lançar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int dsoma = 0;
            
            for (int i = 0; i < n; i++)
            {
                int d = random.Next(1,7);
                Console.WriteLine(d);
                dsoma += d;
            }
            Console.Write("Soma: ");
            Console.Write(dsoma);
        }
    }
}
