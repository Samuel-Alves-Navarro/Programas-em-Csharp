using System;

namespace P1_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, c=0, d=0, calc=0;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            calc = a*b - c*d;
            Console.WriteLine(string.Format("DIFERENCA = {0:0}", calc));
        }
    }
}