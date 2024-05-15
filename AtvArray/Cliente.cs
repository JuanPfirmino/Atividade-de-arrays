using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvArray
{
    internal class Cliente
    {
        public string nome; 
        public int idade;
        public string cpf;
        public string rg;
        public int senha;
        public bool spec;
        public bool acompanhante;
        public bool cadastro;
        public enum condicao
        {
            Leve,
            Moderada,
            Grave
        };

    }
}
