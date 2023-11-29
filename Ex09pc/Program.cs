using System;

namespace Exercicio09

{
    internal class Program
    {
       

        public Program()
        {
            Endereco endereco = new Endereco("joao", 200, "casa", "ana rech", "Caxias do Sul", "RS", "95060360");
            Console.WriteLine(endereco);
            // Pessoa Nome = new Pessoa("Mateus Cosma", endereco);

            Usuario Usuario = new Usuario("Mateus Cosma", endereco, "121354", "TI");
            Console.WriteLine();


            Console.WriteLine("Cadastro ATT2:");
            Console.WriteLine(Usuario.Nome);


            Console.WriteLine();
            Console.WriteLine("Cadastro ATT3:");
            Console.WriteLine(Usuario.ToString());

            Console.WriteLine();
            ItemBiblioteca itemBiblioteca = new ItemBiblioteca(123, "COSMA", "EM USO");
            Console.WriteLine(itemBiblioteca);


        }

        static void Main(string[] args)
        {
            Program tst = new Program();
            Console.ReadLine();


        }




    }
}