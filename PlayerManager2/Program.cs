using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayerManager2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player("Player1", 100),
                new Player("Player2", 200)
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir jogador");
                Console.WriteLine("2. Listar todos os jogadores");
                Console.WriteLine("3. Listar jogadores com Score maior que um valor indicado");
                Console.WriteLine("4. Sair");

                Console.Write("Escolha uma opçao: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InsertPlayer(players);
                        break;
                    case "2":
                        ListAllPlayers(players);
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan(players);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            }
        }
        static void InsertPlayer(List<Player> players)
        {
            Console.Write("Nome do jogador: ");
            string name = Console.ReadLine();
            Console.Write("Pontuaçao do jogador: ");
            int score = Convert.ToInt32(Console.ReadLine());

            players.Add(new Player(name, score));
            Console.WriteLine("Jogador adicionado!");
        }
        static void ListAllPlayers(List<Player> players)
        {
            Console.WriteLine("\nLista de todos os jogadores:");
            foreach (var player in players)
            {
                Console.WriteLine($"Nome: {player.Name}, Score: {player.Score}");
            }
        }
        static void ListPlayersWithScoreGreaterThan(List<Player> players)
        {
            Console.Write("Digite o valor do Score mínimo: ");
            int minScore = Convert.ToInt32(Console.ReadLine());

            IEnumerable<Player> playersWithScoreGreaterThan = GetPlayersWithScoreGreaterThan(players, minScore);

            Console.WriteLine($"\nJogadores com Score maior que {minScore}:");
            foreach (var player in playersWithScoreGreaterThan)
            {
                Console.WriteLine($"Nome: {player.Name}, Score: {player.Score}");
            }
        }

        static IEnumerable<Player> GetPlayersWithScoreGreaterThan(List<Player> players, int minScore)
        {
            return players.Where(player => player.Score > minScore);
        }



    }
}
