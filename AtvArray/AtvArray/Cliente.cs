using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtvArray
{
    internal class Cliente
    {
        private string nome; 
        private int idade;
        private string cpf;
        private string rg;
        private int senha;
        private bool spec;
        public void cadastro()
        {
            Console.WriteLine("\n Qual o nome do cliente?");
            this.nome = Console.ReadLine();
            Console.WriteLine("Qual a idade do cliente?");
            this.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o cpf do cliente?");
            this.cpf = Console.ReadLine();
            Console.WriteLine("Qual o RG do cliente");
            this.rg = Console.ReadLine();
            Console.WriteLine("O cliente possui alguma condição especial?(Gestante, Deficiente físico ou mental, Lactante e Etc)\nSim[1]\tNão[qualquer tecla]");
            char esp = char.Parse(Console.ReadLine());
            if (esp == '1')
            {
                this.spec = true;
            }
            else
            {
                this.spec = false;
            };
            Console.WriteLine("Qual a senha do cliente?");
            this.senha = int.Parse(Console.ReadLine());
        }
            public string Nome { get { return this.nome; } }
            public int Idade { get { return this.idade; } }
            public string Cpf {  get { return this.cpf; } }
            public int Senha { get { return this.senha; } }
            public string Rg {  get { return this.rg; } }
            public bool Spec { get { return this.spec;} }




    }
}
