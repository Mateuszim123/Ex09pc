using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    public class Usuario : Pessoa
    {


        string Matricula { get; set; }
        string Curso { get; set; }



        public Usuario(string Nome, Endereco endereco, string matricula, string curso) : base(Nome, endereco)
        {
            this.Matricula = matricula;
            this.Curso = curso;


        }


        public override string ToString()
        {
            return $"Nome: {Nome}\nMatricula: {Matricula}\nCurso: {Curso} \n{endereco}";
        }




    }
}