using System;

namespace TrocaDeMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Menu();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static int Menu()
        {
            int opcao;
            ConversorDeMoedas selecao = new ConversorDeMoedas();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("PARA VOCÊ QUE DESEJA COMPRAR MOEDAS ESTRANGEIRAS, ESTE PROGRAMA IRÁ TE AJUDAR!!!\n");
            Console.WriteLine("DE ACORDO COM AS OPÇÕES DO MENU, QUAL COMPRA DESEJA EXECUTAR?");

            do
            {
                Console.WriteLine("\t _______________________________");
                Console.WriteLine("\t| $ € £ $ € £  MENU $ € £ $ € £ |");
                Console.WriteLine("\t|                               |");
                Console.WriteLine("\t|  opção 0 : sair               |");
                Console.WriteLine("\t|                               |");
                Console.WriteLine("\t|  opção 1 : DÓLARES em REAIS   |");
                Console.WriteLine("\t|  opção 2 : EUROS em REAIS     |");
                Console.WriteLine("\t|  opção 3 : LIBRAS em REAIS    |");
                Console.WriteLine("\t|_______________________________|");

                Console.Write("\n\tinforme a opção desejada no MENU: ");
                opcao = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                if (opcao < 0 || opcao > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tOPÇÃO INVALIDA! Para voltar ao menu, pressione QUALQUER TECLA!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    switch (opcao)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nvocê escolheu sair.");
                            Console.ForegroundColor = ConsoleColor.White;
                            opcao = 0;
                            break;
                            
                        case 1:
                            selecao.DolaraAmericano();
                            Console.Clear();
                            Menu();
                            break;

                        case 2:
                            selecao.Euro();
                            Console.Clear();
                            Menu();
                            break;

                        case 3:
                            selecao.LibraEsterlina();
                            Console.Clear();
                            Menu();
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                return opcao;
            } while (opcao != 0);
        }
    }
}
