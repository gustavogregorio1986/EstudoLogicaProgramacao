using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicaprogram1.Model
{
    public class Aluno : Pessoa
    {
        public decimal Nota { get; set; }

        public Aluno(int _id, string _nome, DateTime _dataNascimento, decimal _nota) : base(_id, _nome, _dataNascimento, "Brasileiro")
        {
            Nota = _nota;
        }

        public override string Falar(string texto)
        {
            return "Aluno Falando: " + texto;
        }
    }
}
