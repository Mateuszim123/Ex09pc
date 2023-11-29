using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    public class ItemBiblioteca
    {
        int Identificacao;
        string Titulo;
        string Situacao;

        public ItemBiblioteca(int identificacao, string titulo, string situacao)
        {
            this.Identificacao = identificacao;
            this.Titulo = titulo;
            this. Situacao = situacao;
        }

        public override string ToString()
        {
            return $"IDENTIFICAÇÃO: {Identificacao}\nTITULO: {Titulo}\nSITUAÇÃO: {Situacao}";
        }
    }
}
