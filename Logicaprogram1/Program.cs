using Logicaprogram1.Model;
using System;
using System.Collections.Generic;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa joao = new Pessoa();
            Console.WriteLine("------------ João ---------------");
            joao.Nome = "João Santos";
            joao.DataNascimento = DateTime.Today;
            Console.WriteLine(joao.Nome);
            Console.WriteLine(joao.DataNascimento);
            var falando = joao.Falar();
            Console.WriteLine(falando);

            Pessoa maria = new Pessoa();
            Console.WriteLine("------------ Maria ---------------");
            maria.Nome = "Maria Silva";
            maria.DataNascimento = DateTime.Today;
            Console.WriteLine(maria.Nome);
            Console.WriteLine(maria.DataNascimento);
            falando = maria.Falar();
            Console.WriteLine(falando);

            Pessoa pedro = new Pessoa(1,"João", new DateTime(2000,05,01), "Brasileiro");
            Console.WriteLine(pedro.Nome);
            Console.WriteLine(pedro.DataNascimento);

            var retorno = PessoaStatic.Falar();
            Console.WriteLine(retorno);

            var chave = PessoaStatic.chave;
            Console.WriteLine(chave);
            Console.WriteLine(pedro.Nacionalidade);

            PessoaSelada pessoa = new PessoaSelada();
            pessoa.Nome = "Teste";
        }
    }
}

