using System;
using Exibicao.src.Classes;

/*
1 Implemente uma classe chamada Aluno na pasta orientacao-a-objetos para definir os objetos
que representarão os alunos de uma escola. Essa classe deve declarar três atributos: o primeiro para
o nome, o segundo para o RG e o terceiro para a data de nascimento dos alunos.


2 Faça uma classe chamada TestaAluno e crie dois objetos da classe Aluno atribuindo valores a
eles. A classe também deve mostrar na tela as informações desses objetos.


3 Em uma escola, além dos alunos temos os funcionários, que também precisam ser representados em nossa aplicação. Então implemente outra classe na pasta orientacao-a-objetos chamada
Funcionario que contenha três atributos: o primeiro para o nome e o segundo para o cargo o terceiro cargo dos funcionários


4 Faça uma classe chamada TestaFuncionario e crie dois objetos da classe Funcionario atribuindo valores a eles. Mostre na tela as informações desses objetos.


5 Em uma escola, os alunos precisam ser divididos por turmas, que devem ser representadas dentro da aplicação. Implemente na pasta orientacao-a-objetos um classe chamada Turma que contenha quatro atributos: o primeiro para o período, o segundo para definir a série, o terceiro para sigla
e o quarto para o tipo de ensino

6 Faça uma classe chamada TestaTurma para criar dois objetos da classe Turma. Adicione informações a eles e depois mostre essas informações na tela.
Relacionamentos: Associação, Agregação 
*/

namespace Exibicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1
            /* 
            Aluno pessoa = new Aluno();

                Console.WriteLine("O nome do aluno: ");
                pessoa.Nome = Console.ReadLine();
                Console.WriteLine("Seu RG (ex: 12.345.678-9): ");                
                pessoa.RG = Console.ReadLine();
                Console.WriteLine("Data de nascimento (ex: 99/99/9999): ");               
                pessoa.Data = Console.ReadLine(); 
            */

            //exercicio 2
            /*
            TestaAluno pessoa = new TestaAluno();

                Console.WriteLine("Digite o nome do aluno: ");
                pessoa.NomeTest = Console.ReadLine();
                Console.WriteLine("Digite sua data de nascimento: ");
                pessoa.DataTest = Console.ReadLine();

                Console.Write("O nome do aluno é: " + pessoa.NomeTest);
                Console.Write("A sua data de nascimento é: " + pessoa.DataTest);
            */

            //exercicio 3
            /*
            Funcionario funcionario = new Funcionario();

                Console.WriteLine("Nome do funcionario: ");
                funcionario.NomeFuncionario = Console.ReadLine();
                Console.WriteLine("Cargo do funcionario: ");
                funcionario.Cargo = Console.ReadLine();
                Console.WriteLine("CPF do funcionario: ");
                funcionario.CPF = Console.ReadLine();
                Console.WriteLine("O nome do funcionario é: " + funcionario.NomeFuncionario);
                Console.WriteLine("O cargo do funcionario é: "+ funcionario.Cargo);
            */

            //exercicio 5
            /*
            Turma pessoa = new Turma();

                Console.WriteLine("Digite o periodo em que está: ");
                pessoa.Periodo = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite a sua serie: ");
                pessoa.Serie = Console.ReadLine();
                Console.WriteLine("Digite a sua sigla: ");
                pessoa.Sigla = Console.ReadLine();
                Console.WriteLine("Digite em qual tipo de ensino você está: ");
                pessoa.TipoEnsino = Console.ReadLine();
            */

            //exercicio 6
            
            TestaTurma pessoa = new TestaTurma();

                Console.WriteLine("Digite sua sigla: ");
                pessoa.SiglaTest = Console.ReadLine();
                Console.WriteLine("Digite seu tipo de ensino: ");
                pessoa.TipoEnsinoTest = Console.ReadLine();
                Console.WriteLine("A turma está associada a sigla: " + pessoa.SiglaTest);
                Console.WriteLine("O tipo de ensino da turma é: " + pessoa.TipoEnsinoTest);
        }
    }
}
