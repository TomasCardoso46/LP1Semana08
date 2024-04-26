using System;
using System.Collections.Generic;

namespace PlayerManager1
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


    }
}
