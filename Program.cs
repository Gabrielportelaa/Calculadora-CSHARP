using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("1 - somar");
                Console.WriteLine("2 - subtrair");
                Console.WriteLine("3 - multiplicar");
                Console.WriteLine("4 - dividir");
                Console.WriteLine("5 - sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite um valor para ser somado");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro valor para ser somado");
                        double b = double.Parse(Console.ReadLine());
                        double resp = a + b;
                        Console.WriteLine(resp);
                        break;

                    case 2:
                        Console.WriteLine("Digite um valor para ser subtraído");
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro valor para ser subtraído");
                        double d = double.Parse(Console.ReadLine());
                        resp = c - d;
                        Console.WriteLine(resp);
                        break;

                    case 3:
                        Console.WriteLine("Digite um valor para ser multiplicado");
                        double e = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro valor para ser multiplicado");
                        double f = double.Parse(Console.ReadLine());
                        resp = e * f;
                        Console.WriteLine(resp);
                        break;

                    case 4:
                        Console.WriteLine("Digite um valor para ser dividido");
                        double g = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro valor para ser dividido");
                        double h = double.Parse(Console.ReadLine());
                        if (h != 0)
                        {
                            resp = g / h;
                            Console.WriteLine(resp);
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Encerrando a calculadora");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }


            } while (opcao != 5);

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}