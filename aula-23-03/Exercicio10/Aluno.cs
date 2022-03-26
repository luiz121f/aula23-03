using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    public struct Aluno
    {
        public string Nome { get; set; }
        public int RA { get; set; }
        public int frequencia { get; set; }

        public decimal NotaUm { get; set; }
        public decimal NotaDois { get; set; }
        public decimal Media { get; set; }


        public Aluno(string name, int regAcademico, int freq, decimal nota1, decimal nota2, decimal med)
        {
            Nome = name;
            RA = regAcademico;
            frequencia = freq;
            NotaUm = nota1;
            NotaDois = nota2;
            Media = med;
        }

        public string dadosAluno()
        {
            return Nome + '-' + 'R' + 'A' + RA;
        }

        public string calculoMedia()
        {
            if (((NotaUm +NotaDois) / 2) < 70)
            {
                return $"Reprovado por média {(NotaUm + NotaDois) / 2} ";
            }
            else
            {
                return $"Aprovado por média {(NotaUm + NotaDois) / 2}";
            }
        }

        public string calculaFrequencia()
        {
            if (frequencia < 15)
            {
                return $"Reprovado por frequência baixa. Frequência : {frequencia}";
            }
            else
            {
                return $"Aprovado. Frequência : {frequencia}";
            }
        }
    }



}
