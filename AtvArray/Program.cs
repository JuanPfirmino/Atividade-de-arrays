using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente[] Fila = new Cliente[10];
            while (int i = 0; i < Fila.Length; i++)
            {
                Console.WriteLine("Bem vindo ao sistema\nO que voce quer fazer agora?\n verificar a fila[1]\ninserir um novo cliente na fila[2]\norganizar a fila[3]\nRemover o cliente atendido[4]\n Digite 'Q' para sair do programa  ");
                char opc = char.Parse(Console.ReadLine());
                switch (opc)
                {
                    case '1':
                        if(Fila.Length <=0) 
                        {
                            Console.WriteLine("Não a clientes na fila");

                        }
                        else
                        {
                            for (int j =0; j < Fila.Length; j++)
                            {
                                Console.WriteLine(j + "Pessoas na fila:" + Fila[i].nome + "Idade:" + Fila[i].idade);
                            };
                            Console.WriteLine("Fim da fila");
                        };
                    break;

                    case '2':
                        

                    break;

                    case '3':

                    break;

                    case '4':

                    break;

                        default:
                        Console.WriteLine("Opção inválida, digite outro valor");
                        break;

                }
            }

        }
    }
}
