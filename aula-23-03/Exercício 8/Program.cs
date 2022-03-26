using System;
using System.Linq;

namespace Exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;

            const string consoantes = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";

            try
            {
                Console.WriteLine("Digite o seu nome:");
                frase = Console.ReadLine();

                int contador = frase.Count(x => consoantes.Contains(x));

                Console.WriteLine($"O seu nome contém {contador} consoantes.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
