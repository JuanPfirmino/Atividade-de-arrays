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
            int contador = 0;
            char prog = '1';
            do
            {
                Console.WriteLine("\nUm cliente Apareceu\n O que você deseja fazer?\n Ver estado atual da fila[1]\n Inserir o Cliente na fila[2]\nOrganizar Fila[3]\nAtender o primeiro Cliente da fila[4]\n");
                char opt = char.Parse(Console.ReadLine().ToLower());
                if (opt == 'q')
                {
                    prog = '0';
                    break;

                }
                switch (opt)
                {
                    case '1':
                        if (contador == 0)
                        {
                            Console.WriteLine("Não há clientes na fila\n");
                        }
                        else
                        {
                            for (int i = 0; i < contador; i++)
                            {
                                if (Fila[i] != null)
                                {
                                    Console.WriteLine($"\n {i + 1} ° Nome: {Fila[i].Nome} Idade: {Fila[i].Idade}\n Possui Alguma condição especial? [{Fila[i].Spec}]\n");

                                }
                            }
                        }
                        break;

                    case '2':
                        if (contador < 10)
                        {
                            Cliente novoCli = new Cliente();
                            novoCli.cadastro();
                            Fila[contador] = novoCli;
                            contador++;
                            Console.WriteLine("\nCadastro concluido\n O cliente foi adicionado na fila");

                        }
                        else
                        {
                            Console.WriteLine("A fila está cheia, não foi possível adicionar um novo cliente a fila.");
                        }
                        break;
                    case '3':
                        if (contador == 0)
                        {
                            Console.WriteLine("Não há clientes na fila");
                        }
                        else
                        {
                            Console.WriteLine("\nDe que modo você deseja oraganizar a fila?\nPor idade[1]\nPor condições especiais[2]");
                            char org = char.Parse(Console.ReadLine().ToLower());
                            if (org == 'q')
                            {
                                prog = '0';

                            }
                            else
                            {
                                switch (org)
                                {
                                    case '1':
                                        for (int i = 0; i < contador; i++)
                                        {
                                            for (int j = i + 1; j < contador; j++)
                                            {
                                                if (Fila[i] != null && Fila[j] != null && Fila[i].Idade < Fila[j].Idade)
                                                {
                                                    Cliente temp = Fila[i];
                                                    Fila[i] = Fila[j];
                                                    Fila[j] = temp;
                                                }
                                            }
                                        }
                                        break;
                                    case '2':
                                        for (int i = 0; i < contador - 1; i++)
                                        {
                                            for (int j = i + 1; j < contador; j++)
                                            {
                                                if (Fila[i] != null && Fila[j] != null && Fila[i].Spec && Fila[j].Spec)
                                                {
                                                    Cliente temp = Fila[i];
                                                    Fila[i] = Fila[j];
                                                    Fila[j] = temp;
                                                }
                                            }
                                        }
                                        break;
                                }
                            }

                        }
                        Console.WriteLine("\nLista Organizada com sucesso\n");
                        break;
                
                    case '4':
                        if (contador > 0)
                        {
                            Cliente atendido = Fila[0];
                            for (int i = 0; i < Fila.Length - 1; i++)
                            {
                                Fila[i] = Fila[i + 1];
                            }
                            Fila[contador] = null;
                            contador--;
                            Console.WriteLine("Cliente atendido: " + atendido.Nome);

                        }
                        else
                        {
                            Console.WriteLine("Não há mais clientes para atender");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção Inválida, tente novamente");
                        break;

                }
                

            } while (prog != '0');


        }
    }
}
