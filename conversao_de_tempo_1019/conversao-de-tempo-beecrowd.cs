using System;

// dotnet new console = cria um console para compilação
// dotnet run = compila o código pelo console criado 

namespace P1_1019
{
    class Program
    {
        static void Main(string[] args)
        {
           int n=0, h=0, m=0, s=0;

            n = Convert.ToInt32(Console.ReadLine());
            h = (n / 60) / 60;
            m = (n / 60) % 60;
            s = m / 60;

            Console.Write(string.Format("{0:0}:{0:0}:{0:0}", h, m, s));
        }
    }
}