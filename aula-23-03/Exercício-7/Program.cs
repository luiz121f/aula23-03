using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a sua data de nascimento:");
                var idade = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(FaixaEtaria(nome, idade));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: { e.Message}");
            }
        }

        private static string FaixaEtaria(string nome, DateTime idade)
        {
            var age = DateTime.Today.Year - idade.Year;

            if (age >= 20 && age <= 59)
            {
                return $"Você é adulto! Idade: {age } anos";
            }
            else if (age >= 60)
            {
                return $"Você é idoso! Idade: {age } anos";
            }
            return $"Você é jovem! Idade: {age } anos";
        }
    }
}