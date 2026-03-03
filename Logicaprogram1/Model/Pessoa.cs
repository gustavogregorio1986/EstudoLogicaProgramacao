using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicaprogram1.Model
{
    public static class PessoaStatic
    {
        public static string chave = "VALOR DA CHAVE";

        public static string Falar()
        {
            return "Falando do metodo static";
        }
    }

    public class Pessoa
    {
        //Propriedades
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {
            
        }

        public Pessoa(int _id, string _nome, DateTime _datanascimento)
        {
            this.Id = _id;
            this.Nome = _nome;
            this.DataNascimento = _datanascimento;
        }

        //metodo publico
        public string Falar()
        {
            return "Falando do metodo";
        }
    }
}
