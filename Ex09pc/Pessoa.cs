using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public Endereco endereco { get; set; }

        public Pessoa(string nome, Endereco endereco)
        {
            this.Nome = nome;
            this.endereco = endereco;


        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n{endereco}";
        }
    }
}