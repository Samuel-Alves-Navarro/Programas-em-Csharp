using System;


namespace P1_1019
{
    class Program
    {
        static void Main(string[] args)
        {
           int id=0;
           double a=0, m=0, d=0;

           id = Convert.ToInt32(Console.ReadLine());
            a = (id / 360);
            id = id % 360;
            m = id / 30;
            id = id % 30;
            d = id / 1;
            Console.WriteLine(string.Format("{0:0} ano", a));
            Console.WriteLine(string.Format("{0:0} mes(es)", m));
            Console.WriteLine(string.Format("{0:0} dia", d));
        }
    }
}
