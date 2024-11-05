using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Torres
{
    internal class DadosTorre
    {
        public static void CadastrarDados()
        {
            // Pergunta sobre o tamanho da torre
            int tamanhoTorre = ObterTamanhoQuadro();

            if (tamanhoTorre == 0)
            {
                Console.WriteLine("Saindo da aplicação...");
                Environment.Exit(0);
            }

            Console.WriteLine($"Tamanho da Torre selecionado: {tamanhoTorre}");
        }

        public int TamanhoQuadro { get; set; }
        //public int Niveis { get; set; }

        private static int ObterTamanhoQuadro()
        {
            int tamanho = -1;

            while (true)
            {
                Console.WriteLine("\nQual o tamanho da torre:");
                Console.WriteLine("1 - 100");
                Console.WriteLine("2 - 125");
                Console.WriteLine("3 - 155");
                Console.WriteLine("4 - 175");
                Console.WriteLine("0 - Sair");

                string input = Console.ReadLine();

                if (int.TryParse(input, out tamanho) && (tamanho >= 0 && tamanho <= 4))
                {
                    if (tamanho == 0)
                    {
                        return 0; // Sai do programa se a opção for 0
                    }
                    return tamanho;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }

        }
    }
}
