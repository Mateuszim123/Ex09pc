using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }



        public Endereco(string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep)
        {
            this.Rua = rua;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Uf = uf;
            this.Cep = cep;
        }


        public override string ToString()
        {
            return $"Rua: {Rua}\nNumer: {Numero}\nComplemento: {Complemento}\nBairro: {Bairro}\nCidade: {Cidade}\nUF: {Uf}\nCEP: {Cep.ToString()}";
        }


    }
}