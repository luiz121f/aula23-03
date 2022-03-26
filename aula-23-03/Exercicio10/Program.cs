using System;

namespace Exercicio10
{
    class Program
    {
        public static string nome;
        public static decimal nota1;
        public static decimal nota2;
        public static decimal media;
        public static int frequencia;
        public static int RA;

        static void Main(string[] args)
        {


            Console.WriteLine("Digite o nome do aluno:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o RA do aluno:");
            RA =  int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota:");
            nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2 = decimal.Parse(Console.ReadLine());

            media = (nota1 * nota2) / 2;

            Console.WriteLine("Digite o número de aulas frequentadas:");
            frequencia = int.Parse(Console.ReadLine());



            Aluno aluno = new Aluno(nome, RA, frequencia, nota1, nota2, media);

            Console.Write($"{aluno.dadosAluno()}\n {aluno.calculaFrequencia()}\n {aluno.calculoMedia()}");
        }
    }
}
