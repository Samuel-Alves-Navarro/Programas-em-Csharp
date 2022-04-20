using System;

namespace P1_1011
{
    class Program
    {
        static void Main(string[] args)
        {
           double pi=3.14159, r=0, v=0;

            r = Convert.ToDouble(Console.ReadLine());
            v = (4.0/3) * pi * (r*r*r);
            
            Console.WriteLine(string.Format("VOLUME = {0:0.000}", v));
        }
    }
}