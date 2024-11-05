using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Torres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                
                Console.WriteLine("\t---Composição de Torres---\n");
                Console.WriteLine("Bem-vindo(a). Escolha uma das opções abaixo para prosseguir:");
                Console.WriteLine("1 - Criar uma nova composição de torre;");
                Console.WriteLine("0 - Sair.");

                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    DadosTorre.CadastrarDados();
                    //Console.ReadKey();
                }

                else if (opcao == "0")
                {
                    Console.WriteLine("Fechando o programa.");
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida, tente novamente!\n");

                }

            }


        }




    }
}

