using System;
using Jogador_Exercicio.Classes;

namespace Jogador_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorAtaque jA = new JogadorAtaque();
            JogadorDefesa jD = new JogadorDefesa();
            JogadorMeioCampo jM = new JogadorMeioCampo();

            Console.WriteLine(@"
            Em qual posição você joga
            1 - Ataque
            2 - Defesa
            3 - MeioCampo");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                Console.WriteLine("Qual o seu nome?");
                jA.Nome = Console.ReadLine();

                Console.WriteLine("Em que ano você nasceu?");
                jA.DataNasc = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a sua nascionalidade?");
                jA.Nacionalidade = Console.ReadLine();

                Console.WriteLine("Qual a sua altura?");
                jA.Altura = Console.ReadLine();

                Console.WriteLine("Qual o seu peso?");
                jA.Peso = Console.ReadLine();

                Console.WriteLine($"Você se aposentará em {jA.Aposentar()} anos");
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;
            }
            
        }
    }
}
