using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal struct Livro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public decimal Valor { get; set; }

        public Livro(string titulo, string autor, decimal valor)
        {
            Titulo = titulo ?? throw new ArgumentNullException();
            Autor = autor ?? throw new ArgumentNullException();
            Valor = valor ;
        }

        public override string ToString() => $"Titulo : {Titulo} \nAutor : {Autor}, \nValor: {Valor}";

    }
}
