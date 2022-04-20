using System;

//lembre-se que para iniciar o programa em C# é necessario digitar no console dotnet run
// mas existe também dotnet new, e logo após, dotnet console new para criar um novo console
// caso se esqueça de dotnet -h e olhe os projetos

namespace P_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0, c=0, m=0;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            m = (((a*2) + (b*3) + (c*5))/10);
            Console.WriteLine(string.Format("MEDIA = {0:0.0}", m));
        }
    }
}